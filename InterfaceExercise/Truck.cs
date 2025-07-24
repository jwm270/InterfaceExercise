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
    public string Name { get; set; }
    public string Motto { get; set; }
    
    public int Year { get; set; }
    
    public string Make { get; set; }
    
    public string Model { get; set; }
    
    public string Class { get; set; }
}