using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorName.Shared
{
    public class RandomService
    {
        public Guid RandomId { get; } = Guid.NewGuid();
        public int RandomStart { get; set; }
    }
}