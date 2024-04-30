using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeamTrackPro.Core.Entities
{
    public class Comment
    {
        public Guid Id { get; set; }
        public string Text { get; set; }
        public Guid TaskId { get; set; }
        public Guid Userid { get; set; }
        public DateTime Created { get; set; }
    }
}
