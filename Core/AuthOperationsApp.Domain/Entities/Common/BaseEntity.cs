
using AuthOperationsApp.Domain.Interfaces.Common;
using System.ComponentModel.DataAnnotations;


namespace AuthOperationsApp.Domain.Entities.Common
{
    public class BaseEntity : IBaseEntity
    {
        [Key]
        public Guid Id { get; set; }
    }
}
