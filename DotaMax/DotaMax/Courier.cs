using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotaMax
{
    public class Courier
    {
        private static readonly Lazy<Courier>
           lazy = new Lazy<Courier>(() => new Courier());
        public static Courier Instance => lazy.Value;

        public bool HasLoggedIn { get; set; } = false;
        public long MaxId { get; set; } = 0;
    }
}
