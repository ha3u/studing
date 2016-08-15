using System;

class Program
{
    static void Main(string[] args)
    {
        string _input_str = null;

        Console.WriteLine("Enter a natural number from 1 to 20. For stop programm press CTRL+Z");

        do
        {
            Console.Write("Number from 1 to 20 >> ");
            _input_str = System.Console.ReadLine();

            try
            {
                Factorial factorial = new Factorial(_input_str);
                Console.WriteLine("Result of calculation {0:N}! is {1:N}", factorial.number.ToString(), factorial.Value().ToString());
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            Console.WriteLine("");

        } while (_input_str != null);

    }

}
