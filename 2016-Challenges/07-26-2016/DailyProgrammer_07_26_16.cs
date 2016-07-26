/// <summary>
///     Author: Zeph Nord
///     Date: 7/26/16
///     Description: Programming challenge to reduce a fraction to its simplest form.
/// </summary>
public class DailyProgrammer_07_26_2016
{
    /// <summary>
    ///     Find the least common factor of the numerator and denominator.
    ///     Reduce the fraction accordingly.
    /// </summary>
    /// <param name="numerator"></param>
    /// <param name="denominator"></param>
    public static void ReduceFraction(ref int numerator, ref int denominator)
    {
        if (numerator >= denominator)
        {
            var divisor = denominator;
            while (denominator > 1 && numerator > 1 && divisor > 1)
            {
                if (numerator%divisor == 0 && denominator%divisor == 0)
                {
                    denominator = denominator/divisor;
                    numerator = numerator/divisor;
                    divisor = numerator;
                }
                else
                {
                    divisor--;
                }
            }
        }
        else
        {
            var divisor = numerator;
            while (denominator > 1 && numerator > 1 && divisor > 1)
            {
                if (denominator%divisor == 0 && numerator%divisor == 0)
                {
                    denominator = denominator/divisor;
                    numerator = numerator/divisor;
                    divisor = numerator;
                }
                else
                {
                    divisor--;
                }
            }
        }
    }

    public static void Main(string[] args)
    {
        for (var i = 0; i < args.Length; i = i + 2)
        {
            var numerator = int.Parse(args[i]);
            var denominator = int.Parse(args[i + 1]);

            ReduceFraction(ref numerator, ref denominator);
            System.Console.WriteLine(numerator + " " + denominator + "\n");
        }
    }
}
