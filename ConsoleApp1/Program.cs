using System;
using static System.Net.Mime.MediaTypeNames;

namespace ConsoleApp1
{
    class Program
    {      
        static void Main(string[] args)
        {
            Console.WriteLine(" 1- Shoot \n 2 - Reload Gun \n 3- Full Shoot \n 4-Gun information \n 5-exit");
            int a = int.Parse(Console.ReadLine());            
            Gun gun1 = new Gun("Glock-18", 100, 10);            
            do
            {
                if (a==1)
                {
                    gun1.shoot();                    
                }
                else if (a==2)
                {
                    gun1.reload();
                }
                else if (a==3)
                {
                    gun1.FullShoot();
                }
                else if (a==4)
                {
                    gun1.GetInformation();
                }
                else if (a==5)
                {
                    Environment.Exit(a);
                }
                Console.WriteLine("zehmet olmasa ekrandaki reqemleri daxiledin");
                Console.WriteLine("1- Shoot \n 2 - Reload Gun \n 3- Full Shoot \n 4-Gun information \n 5-exit");
                a = int.Parse(Console.ReadLine());
            } while (a != 5);




        }
    }
}
