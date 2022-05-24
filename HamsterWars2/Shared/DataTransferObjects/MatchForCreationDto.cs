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
        public int WinId { get; set; }
        [Required]
        public int LossId { get; set; }

    }
}
