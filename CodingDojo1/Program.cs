using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingDojo1
{
    class Program
    {
        static void Main(string[] args)
        {
            int type = 0;
            do
            {
             Console.WriteLine("Please enter input type!\n1...Celsius\n2...Fahrenheit\n3...Reamur\n4...Kelvin\n");
             type = int.Parse(Console.ReadLine());
               
               
            } while (type < 0 || type > 4);

            Console.WriteLine("Please enter value!");
            double value = double.Parse(Console.ReadLine());
            double val = value;

            int targettemp = 0;
            do
            {
                if (targettemp == type)
                {
                Console.WriteLine("Targettemperature cannot be same as Inputtemperature!\nPlease reenter target temperature type!\n1...Celsius\n2...Fahrenheit\n3...Reamur\n4...Kelvin\n");
                }
                else { 
                Console.WriteLine("Please enter target temperature type!\n1...Celsius\n2...Fahrenheit\n3...Reamur\n4...Kelvin\n"); 
                }
                
                targettemp = int.Parse(Console.ReadLine());
            } while (type==targettemp);


            switch (type)
            {
                case 1:
                    //Celsius

                    if (targettemp == 2)
                    {
                        value *= 33.8;
                    }
                    else if (targettemp == 3)
                    {
                        value *= 0.8;
                    }
                    else
                    {
                        value *= 274.15;
                    }


                    break;

                case 2:
                    //Fahrenheit

                    if (targettemp == 1)
                    {
                        value *= -17.2222222;
                    }
                    else if (targettemp == 3)
                    {
                        value *= -13.7777778;
                    }
                    else
                    {
                        value *= 255.9277778;
                    }
                    break;
                case 3:
                    //Reamur

                    if (targettemp == 1)
                    {
                        value *= 1.25;
                    }
                    else if (targettemp == 2)
                    {
                        value *= 34.25;
                    }
                    else
                    {
                        value *= 274.4;
                    }
                    break;

                case 4:
                    //Kelvin

                    if (targettemp == 1)
                    {
                        value *= -272.15;
                    }
                    else if (targettemp == 2)
                    {
                        value *= -457.87;
                    }
                    else
                    {
                        value *= -217.72;
                    }
                    break;
                

            }


            Console.WriteLine("{0} {1} = {2} {3}!", val, getTemperature(type), value, getTemperature(targettemp));
            int i = 5;

        }
        static string getTemperature(int temp)
        {
            
            switch (temp)
            {
                case 1:
                    return "Celsius";
                case 2:
                    return "Fahrenheit";
                case 3:
                    return "Reamur";
                case 4:
                    return "Kelvin";
                default:
                    return "";
            }
        }
    }
}
