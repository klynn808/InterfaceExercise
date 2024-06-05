using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercise
{
    public class Truck : IVehicle , ICompany
    {
        public Truck()
        {

        }
        public bool HasBedCover { get; set; } = true;
        public string RelativeSize { get; set; } = "large";
        public int NumberOfDoors { get; set; } = 4;
        public bool IsForSale { get; set; } = true;
        public string Make { get; set; } = "Toyota";
        public string Model { get; set; } = "Tacoma";
        public string YearFounded { get; set; } = "1990";
        public string CompanyName { get; set; } = "Trucks R'Us";
        public bool HasChangedGears { get; set; } = false;

        public void Drive()
        {
            if (HasBedCover == true)
            {
                Console.WriteLine($"The covered {GetType().Name} is now driving to the next location.");
            }
            else
            {
                Console.WriteLine($"The topless {GetType().Name} is now driving to the next location.");
            }
            
        }

        public void Park()
        {
            if (HasChangedGears == true)
            {
                if (HasChangedGears == true)
                {
                    Console.WriteLine($"{GetType().Name} is now in park");
                    HasChangedGears = false;
                }
                else
                {
                    Console.WriteLine("Can't park, haven't changed gears.");
                }
            }
        }

        public void Reverse()
        {
            if (HasChangedGears == true)
            {
                Console.WriteLine($"{GetType().Name} is now reversing");
                HasChangedGears = false;
            }
            else
            {
                Console.WriteLine("Can't reverse, still in drive");
            }
        }

        public void ChangeGears(bool isChanged)
        {
            HasChangedGears = isChanged;
        }
    }
}
