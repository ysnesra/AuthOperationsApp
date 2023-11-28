using AuthOperationsApp.Domain.Entities.Common;

namespace AuthOperationsApp.Domain.Entities
{
    public class User : BaseEntity
    {
        public string FullName { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
    }
}
