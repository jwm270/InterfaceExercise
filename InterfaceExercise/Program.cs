using System;
using System.Collections.Generic;

namespace InterfaceExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO Be sure to follow BEST PRACTICES when creating classes and interfaces

            //Create 2 Interfaces called IVehicle & ICompany

            //Create 3 classes called Car , Truck , & SUV

            //In your IVehicle:
            
                /* Create 4 members that Car, Truck, & SUV all have in common.
                 * Example: public int NumberOfWheels { get; set; }
                 */
            

            //In ICompany: 
            
                /* Create 2 members that are specific to each every company
                 * regardless of vehicle type.
                 * Example: public string Logo { get; set; }
                 */

            //In each of your Car, Truck, and SUV classes

                /* Create 2 members that are specific to each class
                 * Example for Car: public bool HasTrunk { get; set; }
                 * Example for SUV: public int NumberOfSeats { get; set; }
                 *
                 * Then, Set each class to inherit from both IVehicle and ICompany and implement their members.
                 */

            //Now, create objects of your 3 classes and give their members values.
            //Creatively display and organize their values
            
            var carOne = new Car();
            carOne.Year = 2025;
            carOne.Make = "Chevy";
            carOne.Model = "Corvette";
            carOne.Class = "Sports Car";
            carOne.Name = "Matilda";
            carOne.Motto = "Chevy Tries...";
            carOne.Type = "Speedster";
            carOne.HasTrunk = true;
            
            var truckOne = new Truck();
            truckOne.Year = 2012;
            truckOne.Make = "Ford";
            truckOne.Model = "F-350";
            truckOne.Class = "Super-Duty";
            truckOne.Name = "Lariat";
            truckOne.Motto = "Ford Strong!";
            truckOne.Is2WheelDrive = false;
            truckOne.Is4WheelDrive = true;

            var suvOne = new SUV();
            suvOne.Year = 2010;
            suvOne.Make = "Dodge";
            suvOne.Model = "Flex";
            suvOne.Class = "Leisure";
            suvOne.Name = "Dingo";
            suvOne.Motto = "Ram Tough!";
            suvOne.Has3RdRow = true;
            suvOne.IsAllWheelDrive = true;
            
            var parkingLot = new List<IVehicle>() { carOne, truckOne, suvOne };

            foreach (var ride in parkingLot)
            {
                Console.WriteLine($"This is a {ride.Year}, {ride.Make}, {ride.Model}...from our {ride.Class} line of vehicles.\n");
            }


            //Option for displaying values: 
            //Create a stubbed out method called DisplayDetails in your IVehicle interface.
            //Implement the stubbed out method in the derived classes.
            //In the scope of them method, use string interpolation to display property values.
            //In order to also interpolate values from ICompany, research how to extend interfaces.

        }
    }
}
