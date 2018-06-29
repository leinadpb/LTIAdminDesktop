using System;
using System.Collections.Generic;

namespace LTIAdminDesktop.Models
{
    public partial class Admins
    {
        public int AdminId { get; set; }
        public int TeacherId { get; set; }

        public Teachers Teacher { get; set; }
    }
}
