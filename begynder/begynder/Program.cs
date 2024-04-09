using System.Security.Cryptography;

namespace begynder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool state = false;

            while (state == false)
            {
                Console.WriteLine("hvor mange kils fik du dit sidste cs kamp");
                int kills = Convert.ToInt32(Console.ReadLine());
                if (kills == 30)
                {
                    Console.WriteLine("du for vild");
                    Console.ReadKey();
                    Console.Clear();

                }
                else if (kills >= 20 && kills < 30)
                {
                    Console.WriteLine("hmmm boosted");
                    Console.ReadKey();
                    Console.Clear();

                }
                else if(kills == 0)
                {
                    state = true;
                }
                else
                {
                    Console.WriteLine("get gud stålent ");
                    Console.ReadKey();
                    Console.Clear();
                }

            }
        }  
    }
}
