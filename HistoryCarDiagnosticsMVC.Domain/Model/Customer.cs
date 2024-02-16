using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace HistoryCarDiagnosticsMVC.Domain.Model
{
    public class Customer
    {
        public int Id { get; set; }

        public string FirstName { get; set; }

        public string SecondName { get; set; }
        
        public string Password { get; set; }

        public string Pesel {  get; set; }
        
        public string NIP { get; set; }

        public string REGON { get; set; }

        public string PhoneNumber { get; set; }

        public string AddressEmail { get; set; }

        public bool isActive { get; set; }
    }
}
