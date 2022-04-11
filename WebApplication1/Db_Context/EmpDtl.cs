using System;
using System.Collections.Generic;

#nullable disable

namespace WebApplication1.Db_context
{
    public partial class EmpDtl
    {
        public int EmpId { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public long? MbNo { get; set; }
    }
}
