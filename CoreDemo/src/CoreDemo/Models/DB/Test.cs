using System;
using System.Collections.Generic;

namespace CoreDemo.Models.DB
{
    public partial class Test
    {
        public int Id { get; set; }
        public int? Mid { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Mob { get; set; }
        public string Address { get; set; }
    }
}
