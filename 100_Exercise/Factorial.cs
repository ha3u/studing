using System;

public class Factorial
{
    public int number
    {
        get;
        set;
    } 

    public Factorial(int _number)
	{
        number = _number;

	}
    public ulong Value ()
    {
        if (number == 0)
        {
            return 1;
        }
        else
        {
            try
            {
                return checked((ulong)number * Value(number - 1));
            }
            catch (System.OverflowException e)
            {
                Console.WriteLine("ERROR: " + e.ToString());
                Console.WriteLine();
                Console.WriteLine("Max number for compute is: " + (number - 1).ToString());
                return 0;
            }
        }
    }
}
