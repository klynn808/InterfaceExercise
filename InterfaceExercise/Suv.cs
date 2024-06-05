using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercise
{
    public class Suv : ICompany , IVehicle
    {
        public Suv()
        {

        }
        public bool HasSurfRacks { get; set; } = true;

        public bool OffRoad { get; set; } = true;
        public int NumberOfDoors { get; set; } = 4;
        public bool IsForSale { get; set; } = true;
        public string Make { get; set; } = "Jeep";
        public string Model { get; set; } = "Wrangler";
        public string YearFounded { get; set; } = "2020";
        public string CompanyName { get; set; } = "SUV's R'Us";
        public bool HasChangedGears { get; set; }

        public void Drive()
        {
            Console.WriteLine($"{GetType().Name} is now driving to the next location.");
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
            if(HasChangedGears == true)
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

        /*public void DisplayDetails()
        {
            Console.WriteLine($")
        }*/
    }
}
