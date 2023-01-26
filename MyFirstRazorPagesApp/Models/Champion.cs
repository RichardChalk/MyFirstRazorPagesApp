using System;
using System.Collections.Generic;

namespace MyFirstRazorPagesApp.Models
{
    public partial class Champion
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Type { get; set; }
        public string? Damage { get; set; }
        public int? ReleaseYear { get; set; }
    }
}
