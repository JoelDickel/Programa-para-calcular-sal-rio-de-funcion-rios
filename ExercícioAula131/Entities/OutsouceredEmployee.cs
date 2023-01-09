using System;
using System.Collections.Generic;
using System.Text;

namespace ExercícioAula131.Entities
{
    class OutsouceredEmployee : Employee
    {
        public double AditionarCharg { get; set; }

        public OutsouceredEmployee()
        {

        }

        public OutsouceredEmployee(string name, int hours, double valuePerHour, double aditionarCharg) : base (name, hours, valuePerHour)
        {
            AditionarCharg = aditionarCharg;
        }

        public override double Payment()
        {
            return base.Payment() + 1.1 * AditionarCharg;
        }


    }
}
