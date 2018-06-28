using System;
using System.Collections.Generic;

namespace LTIAdminDesktop.Models
{
    public partial class Claims
    {
        public int ClaimId { get; set; }
        public string ClaimText { get; set; }
        public int? StudentId { get; set; }
        public int? TeacherId { get; set; }

        public Students Student { get; set; }
        public Teachers Teacher { get; set; }
    }
}
