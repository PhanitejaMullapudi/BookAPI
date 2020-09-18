namespace BookAPI.DBRepo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("BOOK")]
    public partial class BOOK
    {
        public int ID { get; set; }

        [StringLength(500)]
        public string Title { get; set; }

        [StringLength(200)]
        public string Author { get; set; }
    }
}
