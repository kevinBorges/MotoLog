namespace MotoLog.Business.Entity
{
    public class Moto : Base
    {
        public string Year { get; set; }
        public string Model { get; set; }
        public string Plate { get; set; }

        public ICollection<Location> locations { get; set; }
    }
}
