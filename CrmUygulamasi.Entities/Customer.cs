using CrmUygulamasi.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrmUygulamasi.Entities
{
    [Table("Customers")]
    public class Customer : EntityBase
    {
        [Required(ErrorMessage = "Firma Adı alanı boş geçilemez!")]
        [DisplayName("Firma Adı")]
        public string CompanyName { get; set; }

        [Required(ErrorMessage = "E-mail alanı boş geçilemez!")]
        [DataType(DataType.EmailAddress, ErrorMessage = "E-mail adresi hatalı girildi!")]
        public string Email { get; set; }

        [MaxLength(11, ErrorMessage = "Telefon alanı en fazla 11 karakter olabilir. Örn: 05445876551")]
        [DisplayName("Telefon")]
        public string? Phone { get; set; }

        [DisplayName("Vergi Dairesi")]
        public string? TaxAdmin { get; set; }

        [DisplayName("Vergi Numarası")]
        public string? TaxNumber { get; set; }
    }
}
