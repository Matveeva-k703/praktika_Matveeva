namespace praktika
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Author")]
    public partial class Author
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id { get; set; }

        [Required]
        [StringLength(20)]
        public string login { get; set; }

        [Required]
        [StringLength(20)]
        public string password { get; set; }

        public int position { get; set; }

        public virtual Worker Worker { get; set; }

        public virtual Position Position1 { get; set; }

        public string PositionTitle { get => Position1.title; }
    }
}
