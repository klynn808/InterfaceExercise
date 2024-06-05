using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercise
{
    public interface IVehicle
    {
        public int NumberOfDoors { get; set; }
        public bool IsForSale { get; set; }
        public string Make {  get; set; }
        public string Model { get; set; }
        public bool HasChangedGears { get; set; }

        public void Drive();
        public void Reverse();
        public void ChangeGears(bool isChanged);
        public void Park();

    }
}
