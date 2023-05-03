using CrmUygulamasi.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrmUygulamasi.Entities
{
    [Table("Products")]
    public class Product : EntityBase
    {
        [Required(ErrorMessage = "Ürün Adı alanı boş geçilemez!")]
        [DisplayName("Ürün Adı")]
        public string ProductName { get; set; }

        [DisplayName("Birim Fiyatı")]
        public decimal UnitPrice { get; set; }

        [DisplayName("KDV Oranı")]
        public int VatRate { get; set; }

        [DisplayName("Stok Miktarı")]
        public int StockAmount { get; set; }

        [DisplayName("Ürün Resmi")]
        public string? ImageUrl { get; set; }
    }
}
