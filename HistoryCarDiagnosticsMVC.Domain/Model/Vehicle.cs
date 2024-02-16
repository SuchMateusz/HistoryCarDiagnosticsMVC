using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HistoryCarDiagnosticsMVC.Domain.Model
{
    public class Vehicle
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string VIN { get; set; }

        public string EngineId { get; set; }

        public int YearOfProduction { get; set; }

        public int CarMileage { get; set; }

        public DateTime FirstRegistrationDate { get; set; }

        public bool isActive { get; set; }
    }
}
