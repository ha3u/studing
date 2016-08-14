using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks; 

namespace _100_Exercise
{
    class Program
    
    {
        static void Main(string[] args)
        {
            string _input_str = null;
            int _input_int= new int();
            
            Console.WriteLine("Enter a natural number from 1 to 20. For stop programm press CTRL+Z");
            
            do
            {
                Console.Write("Number from 1 to 20 >> ");
                _input_str = System.Console.ReadLine();
                if (_input_str !=null)
                try
                {
                    _input_int = int.Parse(_input_str);
                }
                catch (FormatException e)
                {
                    Console.WriteLine(e.Message);

                }

                if (_input_int >= 0 && _input_int <= 200)
                {
                    ulong calculation = FactorialCalculation(_input_int);
                    Console.WriteLine("Result of calculation {0:N}! is {1:N}", _input_int.ToString(), calculation.ToString());

                    calculation = 0;

                    calculation = FactorialCalculation_recursion (_input_int);
                    Console.WriteLine("Result of calculation {0:N}! is {1:N}", _input_int.ToString(), calculation.ToString());

                }
                else
                {
                    Console.WriteLine("You entered an incorrect value.");
                }
                Console.WriteLine("");
            } while (_input_str != null);


        }

        static private ulong FactorialCalculation (int _number)
        {
            ulong result = 1;
            if (_number > 1)
            {
                for (int i=2; i <= _number; i++)
                {
                    try
                    {
                        result = checked(result * (ulong)i);
                    }
                    catch (System.OverflowException e)
                    {
                        Console.WriteLine("ERROR: " + e.ToString());
                        Console.WriteLine();
                        Console.WriteLine("Max number for compute is: " + (i - 1).ToString());
                    }
                }   
            }
            else
            {
                result = 1;
            }
            return result;

        }

        static private ulong FactorialCalculation_recursion(int _number)
        {
            if (_number == 0)
            {
                return 1;
            }
            else
            {
                try
                {
                    return checked((ulong)_number * FactorialCalculation_recursion(_number - 1));
                }
                catch (System.OverflowException e)
                {
                    Console.WriteLine("ERROR: " + e.ToString());
                    Console.WriteLine();
                    Console.WriteLine("Max number for compute is: " + _number.ToString());
                    return 0;
                }
            }
        }
    }
}
