using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DB_First_VSCODE.Entities
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