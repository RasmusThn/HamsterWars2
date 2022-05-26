using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.DataTransferObjects
{
    public record MatchForCreationDto
    {
        [Required]
        public int WinnerId { get; set; }
        [Required]
        public int LoserId { get; set; }

    }
}
