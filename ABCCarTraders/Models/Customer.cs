using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABCCarTraders.Models
{
    public class Customer : User
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Tp { get; set; }

    }
}
