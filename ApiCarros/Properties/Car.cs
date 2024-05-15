public class Car{
    public string Name{ get; set; } = default;
    public int Year{ get; set; }

    public Car(string Name, int Year) {
        this.Name = Name;
        this.Year = Year;
    }
}