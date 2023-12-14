using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PosManager.Model.User
{
    public class PermissionModel
    {
        public Guid? FunctionId { get; set; }
        public string? FunctionName { get; set; }
        public string? UserId { get; set; }
        public bool? HasView { get; set; }
        public bool? HasCreate { get; set; }
        public bool? HasUpdate { get; set; }
        public bool? HasDelete { get; set; }
    }
    public class PermissionUpdateModel
    {
        public string? UserId { get; set; }
        public Guid? FunctionId { get; set; }
        public string? Command { get; set; }
        public bool? NewValue { get; set; }
    }
}
