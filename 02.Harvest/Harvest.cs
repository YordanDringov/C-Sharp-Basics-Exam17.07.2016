using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Harvest
{
    class Harvest
    {
        static void Main(string[] args)
        {
            int grapeField = int.Parse(Console.ReadLine());
            double grapesFromSquareMeter = double.Parse(Console.ReadLine());
            int wineNorm = int.Parse(Console.ReadLine());
            int workers = int.Parse(Console.ReadLine());

            double totalGrapes = grapeField * grapesFromSquareMeter;
            double producedWine = 0.4 * (totalGrapes / 2.5);

            if (producedWine < wineNorm)
            {
                Console.WriteLine($"It will be a tough winter! More {(int)(wineNorm - producedWine)} liters wine needed.");
            }
            else           
            {
                Console.WriteLine($"Good harvest this year! Total wine: {(int)producedWine} liters.");
                Console.WriteLine($"{Math.Ceiling(producedWine - wineNorm)} liters left -> {Math.Ceiling((producedWine - wineNorm) / workers)} liters per person.");
            }
        }
    }
}
