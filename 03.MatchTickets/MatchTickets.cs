using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.MatchTickets
{
    class MatchTickets
    {
        static void Main(string[] args)
        {
            double budjet = double.Parse(Console.ReadLine());
            string typeOfTickets = Console.ReadLine();
            int fans = int.Parse(Console.ReadLine());
            double moneyForTransport = 0;
            double budjetLeft = 0;

            switch (typeOfTickets)
            {
                case "VIP":
                    if (fans > 0 && fans <= 4)
                    {
                        moneyForTransport = 0.75 * budjet;
                        budjetLeft = budjet - moneyForTransport;
                        if (budjetLeft >=499.99*fans)
                        {
                            Console.WriteLine("Yes! You have {0:f2} leva left.", budjetLeft - 499.99*fans);
                        }
                        else
                        {
                            Console.WriteLine("Not enough money! You need {0:f2} leva.",499.99*fans - budjetLeft);
                        }
                    }

                    else if (fans > 4 && fans <= 9)
                    {
                        moneyForTransport = 0.6 * budjet;
                        budjetLeft = budjet - moneyForTransport;
                        if (budjetLeft >= 499.99*fans)
                        {
                            Console.WriteLine("Yes! You have {0:f2} leva left.", budjetLeft - 499.99*fans);
                        }
                        else
                        {
                            Console.WriteLine("Not enough money! You need {0:f2} leva.", 499.99*fans - budjetLeft);
                        }
                    }
                    else if (fans > 9 && fans <= 24)
                    {
                        moneyForTransport = 0.5 * budjet;
                        budjetLeft = budjet - moneyForTransport;
                        if (budjetLeft >= 499.99*fans)
                        {
                            Console.WriteLine("Yes! You have {0:f2} leva left.", budjetLeft - 499.99*fans);
                        }
                        else
                        {
                            Console.WriteLine("Not enough money! You need {0:f2} leva.", 499.99*fans - budjetLeft);
                        }
                    }
                    else if (fans > 24 && fans <= 49)
                    {
                        moneyForTransport = 0.4 * budjet;
                        budjetLeft = budjet - moneyForTransport;
                        if (budjetLeft >= 499.99*fans)
                        {
                            Console.WriteLine("Yes! You have {0:f2} leva left.", budjetLeft - 499.99*fans);
                        }
                        else
                        {
                            Console.WriteLine("Not enough money! You need {0:f2} leva.", 499.99*fans - budjetLeft);
                        }
                    }
                    else if(fans > 49)
                    {
                        moneyForTransport = 0.25* budjet;
                        budjetLeft = budjet - moneyForTransport;
                        if (budjetLeft >= 499.99*fans)
                        {
                            Console.WriteLine("Yes! You have {0:f2} leva left.", budjetLeft - 499.99*fans);
                        }
                        else
                        {
                            Console.WriteLine("Not enough money! You need {0:f2} leva.", 499.99*fans - budjetLeft);
                        }
                    }
                    break;
                case "Normal":
                    if (fans > 0 && fans <= 4)
                    {
                        moneyForTransport = 0.75 * budjet;
                        budjetLeft = budjet - moneyForTransport;
                        if (budjetLeft >= 249.99*fans)
                        {
                            Console.WriteLine("Yes! You have {0:f2} leva left.", budjetLeft - 249.99*fans);
                        }
                        else
                        {
                            Console.WriteLine("Not enough money! You need {0:f2} leva.", 249.99*fans - budjetLeft);
                        }
                    }

                    else if (fans > 4 && fans <= 9)
                    {
                        moneyForTransport = 0.6 * budjet;
                        budjetLeft = budjet - moneyForTransport;
                        if (budjetLeft >= 249.99*fans)
                        {
                            Console.WriteLine("Yes! You have {0:f2} leva left.", budjetLeft - 249.99*fans);
                        }
                        else
                        {
                            Console.WriteLine("Not enough money! You need {0:f2} leva.", 249.99*fans - budjetLeft);
                        }
                    }
                    else if (fans > 9 && fans <= 24)
                    {
                        moneyForTransport = 0.5 * budjet;
                        budjetLeft = budjet - moneyForTransport;
                        if (budjetLeft >= 249.99*fans)
                        {
                            Console.WriteLine("Yes! You have {0:f2} leva left.", budjetLeft - 249.99*fans);
                        }
                        else
                        {
                            Console.WriteLine("Not enough money! You need {0:f2} leva.", 249.99*fans - budjetLeft);
                        }
                    }
                    else if (fans > 24 && fans <= 49)
                    {
                        moneyForTransport = 0.4 * budjet;
                        budjetLeft = budjet - moneyForTransport;
                        if (budjetLeft >= 249.99*fans)
                        {
                            Console.WriteLine("Yes! You have {0:f2} leva left.", budjetLeft - 249.99*fans);
                        }
                        else
                        {
                            Console.WriteLine("Not enough money! You need {0:f2} leva.", 249.99*fans - budjetLeft);
                        }
                    }
                    else if (fans > 49)
                    {
                        moneyForTransport = 0.25 * budjet;
                        budjetLeft = budjet - moneyForTransport;
                        if (budjetLeft >= 249.99*fans)
                        {
                            Console.WriteLine("Yes! You have {0:f2} leva left.", budjetLeft - 249.99*fans);
                        }
                        else
                        {
                            Console.WriteLine("Not enough money! You need {0:f2} leva.", 249.99*fans - budjetLeft);
                        }
                    }
                    break;


                default: break;
            }
        }
    }
}
