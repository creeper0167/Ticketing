using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ticketing.Domain
{
    public class TicketReply
    {
        [Key]
        public int TicketReplyId { get; set; }
        [ForeignKey("Ticket")]
        public int TicketId { get; set; }
        public string Description { get; set; }

        public virtual Ticket Ticket { get; set; }
    }
}
