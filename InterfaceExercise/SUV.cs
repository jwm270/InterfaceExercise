namespace InterfaceExercise;

public class SUV : ICompany, IVehicle
{
  

    /* Create 2 members that are specific to each class
     * Example for Car: public bool HasTrunk { get; set; }
     * Example for SUV: public int NumberOfSeats { get; set; }
     *
     * Then, Set each class to inherit from both IVehicle and ICompany and implement their members.
     */
    public int Year { get; set; }
    
    public string Make { get; set; }
    
    public string Model { get; set; }
    
    public string Class { get; set; }
    public bool Has3RdRow { get; set; }
    public bool IsAllWheelDrive { get; set; }
    public string Name { get; set; }
    public string Motto { get; set; }
}