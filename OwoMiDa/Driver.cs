using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OwoMiDa
{
    internal class Driver
    {

        public string VehicleFee()
        {
            Console.WriteLine("\nWhat type of vehicle do you drive?\n");
            Console.WriteLine("Big Bus\nSmall Bus\nTricycle\nMotorcycle\n");
            string vehicleType = Console.ReadLine();
            switch (vehicleType.ToLower())
            {
                case "big bus":
                    return "500";

                case "small bus":
                    return "400";

                case "tricycle":
                    return "300";

                case "motorcycle":
                    return "200";

                default:
                    Console.WriteLine( "Wrong Input");
                    return "0";
            }
        }

        public double Membership()
        {
            Console.WriteLine("Are you a member of NURTW? - Yes or No");

            string membershipType = Console.ReadLine();

            switch (membershipType)
            {
                case "yes":
                    return 0.7;

                case "no":
                    return 1;
                default:
                    return 1;
            }

        }

        public string CalculateFee()
        {
            double totalFee = 0;
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"For driver {i+1} \n");
                Console.WriteLine("\nEnter number of trips\n");
                string trips = Console.ReadLine();
                int numOfTrips;
                int.TryParse(trips, out numOfTrips);

                double discount = Membership();
                double vehicleFee = Convert.ToDouble(VehicleFee());

                double total = numOfTrips * discount * vehicleFee;
                Console.WriteLine($"The total for driver {i+1} is {total}");
                totalFee += total;

            }
            return "The total fee is " + totalFee;
        }
    }
}
