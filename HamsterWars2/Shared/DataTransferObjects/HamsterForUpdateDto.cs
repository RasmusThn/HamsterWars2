using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.DataTransferObjects
{
    public record HamsterForUpdateDto
    {
        public int Wins { get; set; }
        public int Losses { get; set; }
        public int Games { get; set; }

    }
}
