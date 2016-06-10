using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Gradudate_project.Entities
{
    public class User : IEntityBase
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public bool? IsOnline { get; set; }
        public bool IsLock { get; set; }
        public bool IsDelete { get; set; }
        public bool IsActive { get; set; }
        public string AvatarUrl { get; set; }
        public DateTime? LastLogout { get; set; }
        public DateTime? LastLogin { get; set; }
        public int? LoginFailureCount { get; set; }
        public DateTime? FirstLoginFalureDate { get; set; }
        public DateTime? Birthday { get; set; }
        public virtual ICollection<UserRole> UserRoles { get; set; }
        public User()
        {
            IsLock = false;
            IsDelete = false;
            IsActive = false;

            UserRoles = new List<UserRole>();
        }
    }
}
