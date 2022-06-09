using System;
using System.Collections.Generic;

namespace trevel
{
    public partial class User
    {
        public User()
        {
            TaskIdOwnerNavigations = new HashSet<Task>();
            TaskIdWorkerNavigations = new HashSet<Task>();
        }

        public int Id { get; set; }
        public string FirstName { get; set; } = null!;
        public string SecondName { get; set; } = null!;
        public string LastName { get; set; } = null!;
        public string Login { get; set; } = null!;
        public string Pass { get; set; } = null!;
        public string Phone { get; set; } = null!;

        public virtual ICollection<Task> TaskIdOwnerNavigations { get; set; }
        public virtual ICollection<Task> TaskIdWorkerNavigations { get; set; }
    }
}
