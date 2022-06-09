using System;
using System.Collections.Generic;

namespace trevel
{
    public partial class Task
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string Desck { get; set; } = null!;
        public DateTime PublicDate { get; set; }
        public int IdOwner { get; set; }
        public int IdWorker { get; set; }
        public int IdStatusTask { get; set; }

        public virtual User IdOwnerNavigation { get; set; } = null!;
        public virtual StatusTask IdStatusTaskNavigation { get; set; } = null!;
        public virtual User IdWorkerNavigation { get; set; } = null!;
    }
}
