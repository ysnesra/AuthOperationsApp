using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AuthOperationsApp.Application.DTOs.RoleGroup
{
    public class UnassignGroupRequestDto
    {
        public string RoleId { get; set; }
        public string GroupId { get; set; }

    }
}
