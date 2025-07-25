namespace InterfaceExercise;

public interface ICompany : IVehicle
{
    public void MethodB();
    /* Create 2 members that are specific to each every company
     * regardless of vehicle type.
     * Example: public string Logo { get; set; }
     */
    public string Name { get; set; }
    public string Motto { get; set; }

    public void Logo();
}