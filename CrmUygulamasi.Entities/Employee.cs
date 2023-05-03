using CrmUygulamasi.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrmUygulamasi.Entities
{
    public class Employee : EntityBase
    {
        [DisplayName("İşe Giriş Tarihi")]
        public DateTime? EnterenceDate { get; set; }
        
        [DisplayName("Adı Soyadı")]
        [Required(ErrorMessage = "İsim soyisim alanının girilmesi zorunlu!")]
        public string NameSurname { get; set; }

        [DisplayName("Kimlik Numarası")]
        public int? CitizienNumber { get; set; }

        [DisplayName("Maaş Bilgisi")]
        public int? Salary { get; set; }

        [DisplayName("E-mail")]
        [Required(ErrorMessage = "Mail alanı zorunlu")]
        public string Email { get; set; }

        [DisplayName("Telefon")]
        public string? Phone { get; set; }

        [DisplayName("Durumu")]
        public bool Status { get; set; }

        [DisplayName("Yetki")]
        public string Role { get; set; }

        [DisplayName("Şifre")]
        [Required(ErrorMessage = "Şifre girilmesi zorunludur")]
        public string Password { get; set; }
    }
}
