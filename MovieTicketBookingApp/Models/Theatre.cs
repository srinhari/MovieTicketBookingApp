using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MovieTicketBookingApp.Models {
    public class Theatre {
        [Key]
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.None)]
        public int Id { get; set; }
        public string Name { get; set; }

        public string City { get; set; }


        public int TotalSeats { get; set;  }

        public ICollection<Show> Shows { get; set; }

    }
}
