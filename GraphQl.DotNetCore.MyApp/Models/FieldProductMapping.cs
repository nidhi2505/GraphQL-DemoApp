using System;
using System.Collections.Generic;

namespace GraphQl.DotNetCore.MyApp.Models
{
    public partial class FieldProductMapping
    {
        public int Id { get; set; }
        public int FieldId { get; set; }
        public int ProductId { get; set; }

        public Fields Field { get; set; }
        public ProductStates Product { get; set; }
    }
}
