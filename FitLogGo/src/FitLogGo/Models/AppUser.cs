using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FitLogGo.Models
{
    public class AppUser
    {
        [Key]
        public int AppUserId { get; set; }

        [MaxLength(20)]
        [MinLength(3)]
        [RegularExpression(@"^[a-zA-Z\d]+[-_a-zA-Z\d]{0,2}[a-zA-Z\d]+")]
        public string Username { get; set; }
        public string Email { get; set; }
        public int InitialWeight { get; set; }
        public int Age { get; set; }
        public DateTime JoinDate { get; set; }



        public ICollection<Session> Sessions { get; set; }
    }
}
