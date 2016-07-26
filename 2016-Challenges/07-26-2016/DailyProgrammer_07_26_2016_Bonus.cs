/// <summary>
/// Author: Zeph Nord
/// Date: 7/26/2016
/// Description: This is a programming challenge to simplify fractions using variables.
/// It turned out not so pretty.
/// and user input equations. </summary>


using System.Collections;
class DailyProgrammer_07_26_2016_Bonus
{
    /// <summary>
    /// Finds the greatest common factor and reduces the numerator
    /// and denominator to their lowest form.
    /// </summary>
    /// <param name="numerator"></param>
    /// <param name="denominator"></param>
    public static void SimplifyFraction(ref string numerator, ref string denominator)
    {
        for (int i = 0; i < numerator.Length; i++)
        {
            for (int j = 0; j < denominator.Length; j++)
            {
                if (numerator[i] == denominator[j])
                {
                    numerator = numerator.Remove(i);
                    denominator = denominator.Remove(j);
                }
            }
        }
    }

    /// <summary>
    /// Checks to see if either the numerator or denominator matches an
    /// existing stores equation.
    /// </summary>
    /// <param name="numerator"></param>
    /// <param name="denominator"></param>
    /// <param name="numOfEquations"></param>
    /// <param name="listOfEquations"></param>
    public static void CheckForEquationMatch(ref string numerator, ref string denominator,
        int numOfEquations, ArrayList listOfEquations)
    {
        //First check to see if any equations need to be substituted in
        for (int i = 0; i < numerator.Length; i++)
        {
            for (int j = 0; j < numOfEquations*2; j = j + 2)
            {
                if (numerator[i].Equals(listOfEquations[j]))
                {
                    SubstituteEquations(ref numerator, listOfEquations, i, j);
                }
            }
        }
        for (int i = 0; i < numerator.Length; i++)
        {
            for (int j = 0; j < numOfEquations*2; j = j + 2)
            {
                if (numerator[i].Equals(listOfEquations[j]))
                {
                    SubstituteEquations(ref numerator, listOfEquations, i, j);
                }
            }
        }
        for (int i = 0; i < numOfEquations*2; i = i + 2)
        {
            if (numerator.Equals(listOfEquations[i]))
            {
                numerator = (string) listOfEquations[i + 1];
            }
        }
        for (int i = 0; i < numOfEquations*2; i = i + 2)
        {
            if (denominator.Equals(listOfEquations[i]))
            {
                denominator = (string) listOfEquations[i + 1];
            }
        }
    }

    /// <summary>
    /// If the numerator or denominator includes an expression that matches
    /// an existing equation, substitute in the according values.
    /// </summary>
    /// <param name="divisor"></param>
    /// <param name="listOfEquations"></param>
    /// <param name="i"></param>
    /// <param name="j"></param>
    public static void SubstituteEquations(ref string divisor, ArrayList listOfEquations, int i, int j)
    {
        divisor = divisor + listOfEquations[j + 1];
        divisor = divisor.Remove(i);
    }

    public static void Main(string[] args)
    {
        var listOfEquations = new ArrayList();
        var numOfEquations = int.Parse(args[0]);

        for (int i = 1; i <= numOfEquations*2; i++) //Equation has a name and expression
        {
            listOfEquations.Add(args[i]);
        }

        for (int i = numOfEquations*2 + 1; i < args.Length; i = i + 2)
        {
            var numerator = args[i];
            var denominator = args[i + 1];

            CheckForEquationMatch(ref numerator, ref denominator, numOfEquations, listOfEquations);

            SimplifyFraction(ref numerator, ref denominator);

            if (numerator.Length == 0)
            {
                numerator = "1";
            }
            if (denominator.Length == 0)
            {
                denominator = "1";
            }

            System.Console.Write(numerator + " " + denominator + "\n");
        }
    }
}