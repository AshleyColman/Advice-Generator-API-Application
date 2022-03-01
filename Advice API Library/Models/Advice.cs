using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advice_API_Library.Models
{
    public sealed class Advice : IAdvice
    {
        public Slip slip { get; set; }
    }
}
