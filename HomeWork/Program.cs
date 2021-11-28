
using System;

namespace HomeWork
{
    class Program
    {
        static void Main(string[] args)
        {

            for (int a = 0; a < 99; a++)

            {

                Console.Write("Yoxlamaq istediyiniz Taskin  nomresini  daxil edin (1,2,3): ");
            int taskno = int.Parse(Console.ReadLine());



                #region Task 1

                
                // Ədədin mürəkkəb və ya sadə olduğunu tapan alqoritm yazın.
                if (taskno == 1)
                {

                    {
                        int num, i, m = 0;
                        bool yoxla = false;

                        Console.Write("TASK 1.Ededin Sade ve ya Murekkeb olub olmadigini yoxlamaq ucun eded daxil edin : ");
                        num = int.Parse(Console.ReadLine());

                        if (num == 0 || num == 1)
                        {
                            Console.Write("ne sade deyil ne murekkeb"+"\n");

                        }
                        else
                        {
                            m = num / 2;
                            for (i = 2; i <= m; i++)
                            {
                                if (num % i == 0)
                                {
                                    Console.Write("Murekkebdir" + "\n");
                                    yoxla = true;
                                    break;

                                }
                            }
                            if (yoxla == false)
                                Console.Write("Sadedir" + "\n");
                        }
                        Console.ReadLine();
                    }


                }
                #endregion
                else
                #region Task 2
                //-Ədədin rəqəmlərinin cəmini tapan alqoritm yazın.
                if (taskno == 2)
                {
                    int eded, result = 0;
                    Console.Write("TASK 2.Reqemlerinin cemini toplamaq ucun eded daxil edin : ");
                    eded = int.Parse(Console.ReadLine());

                    while (eded > 0)
                    {
                        result += (eded % 10);
                        eded /= 10;
                    }
                    Console.WriteLine("Daxil edilen ededin reqemlerinin cemi= : " + result +"\n");
                    Console.ReadLine();
                }
                #endregion
                else
                #region Task 3
                //Daxil edilən rəqəmə görə ilin hansı fəsili olduğunu ekrana yazdıran alqoritm yazın.(Məsələn 3 daxil ediriksə ekrana "Yaz" çıxmalıdır.)
                if (taskno == 3)
                {
                    int reqem;

                    Console.Write("TASK 3.ilin fesillerini tapmaq ucun reqem  daxil edin : ");
                    reqem = int.Parse(Console.ReadLine());

                    switch (reqem)

                    {

                        case 1:
                            Console.WriteLine("Secilen reqeme gore indi YAZ feslidir" + "\n"); break;
                        case 2:
                            Console.WriteLine("Secilen reqeme gore indi YAY feslidir" + "\n"); break;
                        case 3:
                            Console.WriteLine("Secilen reqeme gore indi PAYIZ feslidir" + "\n"); break;
                        case 4:
                            Console.WriteLine("Secilen reqeme gore indi QIS feslidir" + "\n"); break;

                        default:
                            Console.WriteLine("Tessufki 1 ilde 4 fesil var " + reqem + " ola bilmez" + "\n");
                            break;

                    }
                    Console.ReadLine();
                }

                #endregion
                else
                {
                    Console.Write("Duzgun Task nomresi daxil etmediniz 3 eded TASK var 1,2,3 daxil edin " + "\n");
                    Console.ReadLine();
                }



            }

        }

    }
}
