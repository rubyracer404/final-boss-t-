using ConsoleApp1;

namespace ConsoleApp1
{
    
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Tee valik numbritega");
            Console.WriteLine("1. Average LINQ");
            Console.WriteLine("2. Where LINQ");
            Console.WriteLine("3. if and else");
            Console.WriteLine("4. Püramiid");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    AverageLINQ();
                    break;
                case "2":
                   WhereLINQ();
                    break;

                    default:
                    break;
            
            
                case "3":
                Console.WriteLine("STREAM kirjutaja/lugeja");
                FileThing.IF_A_ELSE();
                    break;

                case "4":
                    Pyramid.Püramiid();
                    break;






            }
        }
        static void AverageLINQ()
        {
            Console.WriteLine("Average LINQ");

            var averageResult = PeopleList.people
                .Average(x => x.Age);


            Console.WriteLine(averageResult);
        }
        public static void WhereLINQ()
        {
            var peopleAge = PeopleList.people
             .Where(x => x.Age > 20 && x.Age < 23);

            foreach (var people in peopleAge)
            {
                Console.WriteLine(people.Name);
            }
        }
    }
 }
public class FileThing : Program
{
    public static void IF_A_ELSE()
{
    var LOC_1 = "C:/Users/opilane/Downloads/maja.txt";
    var LOC_2 = "C:/Users/opilane/yippie/nuub.txt";
    try
    {
        using (StreamWriter Sn = new StreamWriter(LOC_1, true))
        {
                Console.WriteLine("kirjuta mdagi suvakat");

            string kirjutama = Console.ReadLine();
            if (kirjutama != "" && kirjutama != null)
            {
                Sn.Write(kirjutama);
                Sn.Close();
            }
            else
            {
                StreamWriter SWN = new StreamWriter(LOC_2, true);
                string NULLED_WRITE = Console.ReadLine();
                SWN.Write(NULLED_WRITE);
                SWN.Close();
                Console.WriteLine("nah");
            }
        }
        using (StreamReader SR = new StreamReader("C:/Users/opilane/Downloads/maja.txt"))
        {
            string lugema = SR.ReadToEnd();
            Console.WriteLine(lugema);

        }
    }
    catch (Exception TNE)
    {
        Console.WriteLine("Midagi läks viltu");
        Console.WriteLine(TNE.Message);
    }
}
    }
public class Pyramid : Program
{
    public static void Püramiid()
    {


        int i, j, n;

        Console.Write("püramiid tärnidest: \n");
        Console.Write("----------------");
        Console.Write("\n\n");
        Console.WriteLine("Sisesta püramiidi suurus");
        n = Convert.ToInt32(Console.ReadLine());

        for (i = 0; i <= n; i++)
        {
            for (j = 1; j <= n - i; j++)
            {
                Console.Write(" ");
            }
            for (j = 1; j <= 2 * i - 1; j++)
            {
                Console.Write("*");
            }
            Console.Write("\n");
        }

        }
    }



