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
            int _input_int=0;
            
            Console.WriteLine("Enter a natural number from 1 to 20. For stop programm press CTRL+Z");
            
            do
            {
                Console.Write("Number from 1 to 20 >> ");
                _input_str = System.Console.ReadLine();
                if (_input_str !=null)
                try
                {
                    _input_int = Int32.Parse(_input_str);
                }
                catch (FormatException e)
                {
                    Console.WriteLine(e.Message);

                }

                if (_input_int >= 0 && _input_int <= 20)
                {
                    Int64 calculation = FactorialCalculation(_input_int);
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

        static private Int64 FactorialCalculation (int _number)
        {
            Int64 result = 1;
            if (_number > 1)
            {
                for (int i=2; i <= _number; i++)
                {
                    result = result * i;
                }   
            }
            else
            {
                result = 1;
            }
            return result;

        }

        static private Int64 FactorialCalculation_recursion(Int64 _number)
        {
            if (_number == 0)
            {
                return 1;
            }
            else
            {
                return _number * FactorialCalculation_recursion(_number - 1);
            }

        }
    }
}
