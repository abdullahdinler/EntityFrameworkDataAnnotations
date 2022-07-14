using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkDataAnnotations.Entites
{
    public class Order
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]                       // Id değerini otomatik artan yaptık.
        public int ID { get; set; }


        [MaxLength(5)]
        public string CustomerID { get; set; }

        [MaxLength(40)]
        public string ShipName { get; set; }

        [MaxLength(15)]
        public string ShipCity { get; set; }

        [MaxLength(15)]
        public string ShipCountry { get; set; }

        [ForeignKey("CustomerID")]                              // Foreignkey belirledik
        public Customer Customer { get; set; }
    }
}
