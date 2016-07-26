namespace DailyProgrammingChallenges
{
    class DailyProgrammer_072616
    {
        public static void ReduceFraction(ref int numerator, ref int denominator)
        {
            
            if (numerator >= denominator)
            {
                int divisor = denominator;
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
                int divisor = numerator;
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
            for (int i = 0; i < args.Length; i = i + 2)
            {
                var numerator = int.Parse(args[i]);
                var denominator = int.Parse(args[i + 1]);

                ReduceFraction(ref numerator, ref denominator);
                System.Console.WriteLine(numerator + " " + denominator + "\n");
            }
        }
    }
}
