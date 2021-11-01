using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CoffeeShop.Models
{
    public class User
    {
        [Key]
        public int Id { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string email { get; set; }
        public string passWord { get; set; }
        public DateTime Birthday { get; set; }
        public bool HadCoffee { get; set; }

        //NO CONSTRUCTORS!!! BREAKS CODE!!!!
        //public User(string first, string last, string eMail, string password)
        //{
        //    firstName = first;
        //    lastName = last;
        //    email = eMail;
        //    passWord = password;
        //}
    }
}
