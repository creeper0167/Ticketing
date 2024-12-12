using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ticketing.Domain
{
    public class Ticket
    {
        [Key]
        public int TicketId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Attachment { get; set; }

        public virtual ICollection<TicketReply> TicketReplies { get; set; }
    }
}
