using System;
using System.Collections.Generic;

namespace Hack
{
    public partial class FileCatalog
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public int MomId { get; set; }
        public string Mode { get; set; } = null!;
        public double Width { get; set; }
        public double Height { get; set; }
    }
}
