//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace _DataLayer
{
    using System;
    using System.Collections.Generic;
    
    public partial class Movy
    {
        public int MovieId { get; set; }
        public string MovieName { get; set; }
        public string DirectorName { get; set; }
        public Nullable<int> GenreId { get; set; }
        public string VisionStartD { get; set; }
        public string VisionFinishD { get; set; }
    
        public virtual Genre Genre { get; set; }
    }
}
