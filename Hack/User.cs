using System;
using System.Collections.Generic;

namespace Hack
{
    public partial class User
    {
        public User()
        {
            PrintValues = new HashSet<PrintValue>();
        }

        public int Id { get; set; }
        public string Fullname { get; set; } = null!;
        public string Login { get; set; } = null!;
        public string Password { get; set; } = null!;

        public virtual ICollection<PrintValue> PrintValues { get; set; }
    }
}
