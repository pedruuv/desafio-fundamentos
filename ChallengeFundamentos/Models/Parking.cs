using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChallengeFundamentos.Models
{
    public class Parking
    {
        public decimal InitialPrice = 0;
        public decimal PricePerHour = 0;
        private List<string> Vehicles = new();

        public Parking(decimal initialPrice, decimal pricePerHour)
        {
            this.InitialPrice = initialPrice;
            this.PricePerHour = pricePerHour;
        }

        public void AddVehicle()
        {
            Console.WriteLine("Enter the license plate: ");
            string licensePlate = Console.ReadLine();
            Vehicles.Add(licensePlate);
        }

        public void RemoveVehicle()
        {
            Console.WriteLine("Enter the license plate: ");
            string licensePlate = Console.ReadLine();

           if(Vehicles.Any(v => v.ToUpper() == licensePlate.ToUpper()))
            {
                Console.WriteLine("Type the amount of time it was parked: ");
                int hours = Convert.ToInt32(Console.ReadLine());
                decimal price = InitialPrice + (PricePerHour * hours);

                Vehicles.Remove(licensePlate);

                Console.WriteLine($"The vehicle {licensePlate} was removed and the total price was R$ {price}");
            }
            else
            {
                Console.WriteLine("Sorry, this license plate is not parked here. Check if you typed correctly");
            }
        }

        public void ListVehicles()
        {
            if (Vehicles.Any())
            {
                Console.WriteLine("The vehicles parked here are: ");
                Vehicles.ForEach(Console.WriteLine);
            }
            else
            {
                Console.WriteLine("There are no vehicles parked here");
            }
        }


    }
}
