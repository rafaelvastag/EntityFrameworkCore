using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ModBasic.Entities
{
    [Table("PRODUCTS")]
    public class Product
    {
        [Key]
        [Column("ID")]
        public int Id { get; set; }

        [Column("NAME")]
        public string Name { get; set; }

        [Column("PRICE")]
        public decimal Price { get; set; }

        [Column("CATEGORY")]
        public string Category { get; set; }

    }
}
