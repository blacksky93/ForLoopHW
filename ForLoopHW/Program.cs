namespace ForLoopHW
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter comma-separated list of first names: ");
            string stringCsv = Console.ReadLine();
            List<string> stringList = new List<string>(stringCsv.Split(','));
            for (int firstNamePosition = 0; firstNamePosition < stringList.Count; firstNamePosition++)
            {
                switch (stringList[firstNamePosition])
                {
                    case "tim":
                        Console.WriteLine($"Hello Professor {stringList[firstNamePosition]}");
                        break;
                    default:
                        Console.WriteLine($"Hello {stringList[firstNamePosition]}");
                        break;
                }
            }
        }
    }
}
