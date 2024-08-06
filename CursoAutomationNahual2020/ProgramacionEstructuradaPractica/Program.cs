namespace ProgramacionEstructuradaPractica
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class Program
    {
        static void Main(string[] args)
        {
            int año = 1978;

            bool valido = true;

            Console.WriteLine("Ingresará años hasta uno anterior a 1978, posterior a 2021 o que no se haya disputado un Mundial de fútbol.");


            while ((año >= 1978 && año <= 2021) && (valido))
            {
                Console.Write("Ingrese un año entre 1978 y 2021: ");
                año = int.Parse(Console.ReadLine());
                Console.Clear();

                switch (año)
                {
                    case 1978:
                        Console.WriteLine("En el año 1978 Argentina fue Campeón del Mundo");
                        Console.ReadLine();
                        break;

                    case 1982:
                        Console.WriteLine("En el año 1982 Italia fue Campeón del Mundo");
                        Console.ReadLine();
                        break;

                    case 1986:
                        Console.WriteLine("En el año 1986 Argentina fue Campeón del Mundo");
                        Console.ReadLine();
                        break;

                    case 1990:
                        Console.WriteLine("En el año 1990 Alemania Federal fue Campeón del Mundo");
                        Console.ReadLine();
                        break;

                    case 1994:
                        Console.WriteLine("En el año 1994 Brasil fue Campeón del Mundo");
                        Console.ReadLine();
                        break;

                    case 1998:
                        Console.WriteLine("En el año 1998 Francia fue Campeón del Mundo");
                        Console.ReadLine();
                        break;

                    case 2002:
                        Console.WriteLine("En el año 2002 Brasil fue Campeón del Mundo");
                        Console.ReadLine();
                        break;

                    case 2006:
                        Console.WriteLine("En el año 2006 Italia fue Campeón del Mundo");
                        Console.ReadLine();
                        break;

                    case 2010:
                        Console.WriteLine("En el año 2010 España fue Campeón del Mundo");
                        Console.ReadLine();
                        break;

                    case 2014:
                        Console.WriteLine("En el año 2014 Alemania fue Campeón del Mundo");
                        Console.ReadLine();
                        break;

                    case 2018:
                        Console.WriteLine("En el año 2018 Francia fue Campeón del Mundo");
                        Console.ReadLine();
                        break;

                    default:

                        if (año >= 1978 && año <= 2021)
                        {
                            Console.WriteLine($"En el año {año} no se jugó un Mundial");
                            valido = false;
                            Console.ReadLine();
                            break;

                        }
                        else break;
                }

                Console.Clear();

            }
            if (año < 1978 || año > 2021)
                Console.WriteLine($"El año {año} no se encuentra dentro del rango propuesto");

            Console.WriteLine("Presione cualquier tecla para finalizar");
            Console.ReadKey();


        }


    }
}
