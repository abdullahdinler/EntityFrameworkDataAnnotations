using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkDataAnnotations.Entites
{
    [Table("Customers")]                                             // Tabloyu Customers olarak kaydet
    public class Customer
    {
        [Key]                                                          // Id belirledik
        [Column("CustomerID")]                                    // Id yerine Tabloda CustomerId olarak kaydet
        [MaxLength(5)]                                               //  Id maksimum karekter sayısını 5 yaptık
        public string ID { get; set; }


        [Required]                                                  // Zorunlu alan belirledik
        [Column("ContactName")]
        [MaxLength(50)]
        [ConcurrencyCheck]                                          // ConcurrencyCheck özniteliği, bir özelliğin eşzamanlılık yönetiminin bir parçası olarak UPDATE veya DELETE deyimindeki WHERE yan tümcesine dahil edilmesi gerektiğini belirtmek için kullanılır.
        public string Name { get; set; }


        [Required]
        [Column("CompanyName")]
        [MaxLength(50)]
        public string Company { get; set; }


        [Column("City")]
        [MaxLength(50)]
        public string City { get; set; }


        [Column("Country")]
        [MaxLength(50)]
        public string Country { get; set; }


        [NotMapped]                                                  // Bu tablonun veri tabanında oluşmasına izin vermez.
        public string CityAndCountry { get; set; }

        [Timestamp]                                                 //  TimeStamp özelliği, bir özelliğin eşzamanlılık yönetiminde yer alması gerektiğini belirtmek için kullanılır. TimeStamp özniteliği, yalnızca bir bayt dizisi olan bir özelliğe uygulandığında geçerlidir.Bunun nasıl uygulanacağı, geçerli veritabanı sağlayıcısına bağlıdır. SQL Server'da bu, bir satır sürümü türüyle eşlenir.
        public byte[] TimeStamp { get; set; }



        public List<Order> Orders { get; set; }
    }
}
