using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.DataTransferObjects
{
   public record MatchDto
    {
        public int Id { get; set; }
        public int WinnerId { get; set; }
        public int LoserId { get; set; }
        public DateTime TimeStamp { get; set; }
    }
}
