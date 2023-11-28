using AuthOperationsApp.Application.Repositories;
using MediatR;
using System.Transactions;

namespace AuthOperationsApp.Application.Behaviors
{
    public sealed class UnitOfWorkBehavior<TRequest, TResponse> : IPipelineBehavior<TRequest, TResponse> where TRequest : IRequest<TResponse>
    {
        private readonly IUnitOfWork _unitOfWork;

        public UnitOfWorkBehavior(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<TResponse> Handle(TRequest request, RequestHandlerDelegate<TResponse> next, CancellationToken cancellationToken)
        {
            if (IsNotCommand())
                return await next();

            using var transactionScope = new TransactionScope(TransactionScopeAsyncFlowOption.Enabled);

            TResponse response = default;
            Exception? exception = null;
            try
            {
                response = await next();
            }
            catch (Exception e)
            {
                exception = e;
                await _unitOfWork.RollbackAsync(cancellationToken);
            }

            await _unitOfWork.SaveChangesAsync(cancellationToken);
            if (_unitOfWork.IsCommit)
                transactionScope.Complete();
            else
                transactionScope.Dispose();
            if (exception is not null)
                throw exception;

            return response;
        }

        private static bool IsNotCommand()
        {
            return !typeof(TRequest).Name.Contains("Command");
        }
    }
}
