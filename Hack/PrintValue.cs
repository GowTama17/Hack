using System;
using System.Collections.Generic;

namespace Hack
{
    public partial class PrintValue
    {
        public int Id { get; set; }
        public int? UserId { get; set; }
        public float Speed { get; set; }
        public float Force { get; set; }

        public virtual User? User { get; set; }
    }
}
