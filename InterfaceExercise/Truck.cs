using System;

namespace InterfaceExercise;

public class Truck : ICompany, IVehicle
{
    /* Create 2 members that are specific to each class
     * Example for Car: public bool HasTrunk { get; set; }
     * Example for SUV: public int NumberOfSeats { get; set; }
     *
     * Then, Set each class to inherit from both IVehicle and ICompany and implement their members.
     */
    public bool Is4WheelDrive { get; set; }
    public bool Is2WheelDrive { get; set; }
    public void MethodB()
    {
        Console.WriteLine("Method B");
    }

    public string Name { get; set; }
    public string Motto { get; set; }
    public void Logo()
    {
        Console.WriteLine("Truck Logo");
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
        string range = Is4WheelDrive ? "four wheel drive" : "two wheel drive";
        
        Console.WriteLine($"My Truck is a {Year} and has {range}!");
    }

  }