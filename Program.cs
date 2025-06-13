namespace VanityPlates
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Plate plate = new Plate();

            string plateNumber = Console.ReadLine();

            plateNumber = plate.PlateNumber(plateNumber);
        }
    }
}