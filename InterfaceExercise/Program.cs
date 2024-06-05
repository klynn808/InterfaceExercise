using System;
using System.Collections.Generic;

namespace InterfaceExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            #region InterfaceRegion

            Suv myFirstSuv = new Suv { HasSurfRacks = true, IsForSale = true, Make = "Jeep", Model = "Grand Cherokee", CompanyName = "Jeep Town USA", 
                NumberOfDoors = 4, OffRoad = true, YearFounded = "1987" };
            
            Truck myFirstTruck = new Truck { IsForSale = true, Make = "Toyota", Model = "Takoma", CompanyName = "Truck Town USA", 
                NumberOfDoors = 4, YearFounded = "1991", HasBedCover = true, RelativeSize = "Huge" };
            
            Car myFirstCar = new Car { IsForSale = true, Make = "Audi", Model = "Four Circls", CompanyName = "Jeep Town USA", 
                NumberOfDoors = 4, YearFounded = "1998", CarType = "Something Snazzy", HasTrunk = true };  

            List<IVehicle> vehicles = new List<IVehicle>();

            vehicles.Add(myFirstCar);
            vehicles.Add(myFirstSuv);
            vehicles.Add(myFirstTruck);

            foreach (IVehicle vehicle in vehicles)
            {
                vehicle.Drive();
                vehicle.ChangeGears(false);
                vehicle.Reverse();
               
            }

            #endregion

            //TODO Be sure to follow BEST PRACTICES when creating classes and interfaces

            //Create 2 Interfaces called IVehicle & ICompany DONE

            //Create 3 classes called Car , Truck , & SUV DONE

            //In your IVehicle:

            /* Create 4 members that Car, Truck, & SUV all have in common.
             * Example: public int NumberOfWheels { get; set; } DONE
             */


            //In ICompany: 

            /* Create 2 members that are specific to each every company
             * regardless of vehicle type.
             * Example: public string Logo { get; set; } DONE
             */

            //In each of your Car, Truck, and SUV classes

            /* Create 2 members that are specific to each class
             * Example for Car: public bool HasTrunk { get; set; }
             * Example for SUV: public int NumberOfSeats { get; set; } D
            ONE
             *
             * Then, Set each class to inherit from both IVehicle and ICompany and implement their members.
             * DONE
             */

            //Now, create objects of your 3 classes and give their members values. DONE
            //Creatively display and organize their values

            //Option for displaying values: 
            //Create a stubbed out method called DisplayDetails in your IVehicle interface. DONE
            //Implement the stubbed out method in the derived classes.
            //In the scope of them method, use string interpolation to display property values.
            //In order to also interpolate values from ICompany, research how to extend interfaces.

        }
    }
}
