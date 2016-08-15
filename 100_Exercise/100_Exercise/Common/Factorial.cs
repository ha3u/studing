using System;

public class Factorial
{
    public const int MinValueOfBase = 0;
    public const int MaxValueOfBase = 20;
    
    public int number
    {
        get;
        set;
    } 

    public Factorial(int _number)
	{
        number = _number;
        if (IsBaseRangeCorrect(_number))
        {
            number = _number;
        }

    }

    public Factorial(string _number)
    {
        if (_number != null)
            try
            {
                if (IsBaseRangeCorrect(int.Parse(_number)))
                {
                    number = int.Parse(_number);
                }
            }
            catch (FormatException e)
            {
                throw new FormatException("Incorect format of base. Base must be natural number in interval from " + MinValueOfBase.ToString() + " to " + MaxValueOfBase.ToString(), e);
            }
    }

    private bool IsBaseRangeCorrect(int _base)
    {
        if (_base < MinValueOfBase || _base > MaxValueOfBase)
        {
            throw new ArgumentOutOfRangeException("Base", _base, "Base of factorial must be in interval from " + MinValueOfBase.ToString() + " to "+ MaxValueOfBase.ToString());
        }
        else
        {
            return true;
        }
    }

    public ulong Value ()
    {
        return Computing(number);
    }
    
    private static ulong Computing(int _number)
    {
        if (_number == 0)
        {
            return 1;
        }
        else
        {
            try
            {
                return checked((ulong)_number * Computing(_number - 1));
            }
            catch (System.OverflowException e)
            {
                Console.WriteLine("ERROR: " + e.ToString());
                Console.WriteLine();
                Console.WriteLine("Max number for compute is: " + (_number - 1).ToString());
                return 0;
            }
        }
    }
}
