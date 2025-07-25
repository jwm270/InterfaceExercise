using System;

namespace InterfaceExercise;

public class SUV : ICompany, IVehicle
{
  

    /* Create 2 members that are specific to each class
     * Example for Car: public bool HasTrunk { get; set; }
     * Example for SUV: public int NumberOfSeats { get; set; }
     *
     * Then, Set each class to inherit from both IVehicle and ICompany and implement their members.
     */
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
        string rowStuff = Has3RdRow ? "three rows of seats" : "no third row of seats";
        
        Console.WriteLine($"My SUV is a {Year} and has {rowStuff}.");
    }

    public bool Has3RdRow { get; set; } //string rowStuff = Has3rdRow ? "three rows!" : "no third row"; static void Print(string text)
    //{
    //    Console.Write(text);
    //}
    public bool IsAllWheelDrive { get; set; }
    public void MethodB()
    {
        Console.WriteLine("Method B");
    }

    public string Name { get; set; }
    public string Motto { get; set; }
    public void Logo()
    {
        Console.WriteLine("SUV Logo");
    }
    
    
}