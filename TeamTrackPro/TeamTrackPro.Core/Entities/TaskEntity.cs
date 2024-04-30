using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeamTrackPro.Core.Enums;

namespace TeamTrackPro.Core.Entities
{
    public class TaskEntity
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime DueDate { get; set; }
        public Guid AssigneeId { get; set; }
        public Guid ProjectId { get; set; }
        public Guid CreatedByUserId { get; set; }
        public Priority Priority { get; set; }
        public Status Status { get; set; }
    }
}
