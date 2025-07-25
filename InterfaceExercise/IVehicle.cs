namespace InterfaceExercise;

public interface IVehicle
{
    
    public void MethodA();
    
    /* Create 4 members that Car, Truck, & SUV all have in common.
     * Example: public int NumberOfWheels { get; set; }
     */
    public int Year { get; set; }
    public string Make { get; set; }
    public string Model { get; set; }
    public string Class { get; set; }
    
    public void DisplayDetails();
   
}