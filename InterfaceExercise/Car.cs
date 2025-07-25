using System;
using System.Security.AccessControl;

namespace InterfaceExercise;

public class Car : ICompany, IVehicle
{
    /* Create 2 members that are specific to each class
     * Example for Car: public bool HasTrunk { get; set; }
     * Example for SUV: public int NumberOfSeats { get; set; }
     *
     * Then, Set each class to inherit from both IVehicle and ICompany and implement their members.
     */
    public bool HasTrunk { get; set; }
    public string Type { get; set; }
    public void MethodB()
    {
        Console.WriteLine("MethodB");
    }

    public string Name { get; set; }
    public string Motto { get; set; }
    public void Logo()
    {
        Console.WriteLine("Car Logo");
    }

    public void MethodA()
    {
        Console.WriteLine("Method A");
    }

    public int Year { get; set; }
    
    public string Make { get; set; }
    
    public string Model { get; set; }
    
    public string Class { get; set; }

    public void DisplayDetails()
    {
        string trunkSpace = HasTrunk ? "trunk is spacious" : "lack of a trunk is problematic";
        
        Console.WriteLine($"My car is a {Year} and it's {trunkSpace}.");
    }

}