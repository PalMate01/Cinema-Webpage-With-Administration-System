//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CinArk.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class movies
    {
        public int id { get; set; }
        public string title { get; set; }
        public string genre { get; set; }
        public string rating { get; set; }
        public string lenght { get; set; }
        public string release_date { get; set; }
        public int room { get; set; }
        public byte[] img { get; set; }
    }
}
