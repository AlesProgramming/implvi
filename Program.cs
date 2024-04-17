namespace implvi
{
    public class Program
    {
        public static void Main()
        {
            Magazine[] magazines = new Magazine[15];
            Random rand = new Random();
            
            for (int x = 0; x < magazines.Length; x++)
            {
                magazines[x] = new Magazine("publisher", (x + 1).ToString(), "month",rand.Next( 10, 1000));
            }

            int tot = 0;
            int min = magazines[0].pages;
            string minMag = magazines[0].name;

            foreach (var mag in magazines)
            {
                tot += mag.pages;
                if (mag.pages < min)
                {
                    min = mag.pages;
                    minMag = mag.name;
                }
            }
            
            Console.WriteLine("Average page count: " + (tot / magazines.Length));
            Console.WriteLine($"Magazine with least pages: {minMag}, with {min} pages.");
        }
    }
}