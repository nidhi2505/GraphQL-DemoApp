using System;
using System.Collections.Generic;

namespace GraphQl.DotNetCore.MyApp.Models
{
    public partial class Reference
    {
        public int Id { get; set; }
        public string Type { get; set; }
        public int Key { get; set; }
        public string Value { get; set; }
    }
}
