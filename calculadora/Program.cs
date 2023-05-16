using System;

class Program
{
    static void Main()
    {
        Console.Write("Ingrese cuántos números desea utilizar: ");
        string input = Console.ReadLine();
        int count;

        if (int.TryParse(input, out count))
        {
            double result = 0;

            for (int i = 1; i <= count; i++)
            {
                Console.Write($"Ingrese el número {i}: ");
                string numberInput = Console.ReadLine();
                double number;

                if (double.TryParse(numberInput, out number))
                {
                    switch (i)
                    {
                        case 1:
                            result = number;
                            break;
                        case 2:
                            result += number;
                            break;
                        case 3:
                            result -= number;
                            break;
                        case 4:
                            result *= number;
                            break;
                        case 5:
                            result /= number;
                            break;
                        default:
                            Console.WriteLine("Ha ingresado más números de los permitidos.");
                            return;
                    }
                }
                else
                {
                    Console.WriteLine("Ha ingresado un valor inválido. Inténtelo de nuevo.");
                    return;
                }
            }

            Console.WriteLine("El resultado es: " + result);
        }
        else
        {
            Console.WriteLine("Ha ingresado un valor inválido para la cantidad de números. Inténtelo de nuevo.");
        }
    }
}
