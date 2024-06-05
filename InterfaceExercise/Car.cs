using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercise
{
    public class Car : IVehicle , ICompany
    {
        public Car()
        {

        }
        public string CarType {  get; set; }
        public bool HasTrunk { get; set; }
        public int NumberOfDoors { get; set; } = 4;
        public bool IsForSale { get; set; } = true;
        public string Make { get; set; } = "Audi";
        public string Model { get; set; } = "Something Real Nice";
        public string YearFounded { get; set; } = "1995";
        public string CompanyName { get; set; } = "Nice Cars Land";
        public bool HasChangedGears { get; set; }

        public void ChangeGears(bool isChanged)
        {
            throw new NotImplementedException();
        }

        public void Drive()
        {
            Console.WriteLine($"Driving in my {GetType().Name}");
        }

        public void Park()
        {
            throw new NotImplementedException();
        }

        public void Reverse()
        {
            throw new NotImplementedException();
        }
    }
}
