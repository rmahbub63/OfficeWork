using System;

public class Test
{
    public static void Main()
    {
        String input;
        while ((input = Console.ReadLine()) != null && input != "")
        {
            int Input = int.Parse(s: input);
            int Day = 2;
            int FirstValue = 1;
            int SecondValue = 2;
            int NewValue;
            String Result;

            if (Input == 1)
            {
                Result = "Showmic brings 1 chocolate on 1st day.";
            }
            else if (Input == 2)
            {
                Result = "Showmic brings 2 chocolate on 2nd day.";
            }
            else if (Input == (FirstValue + SecondValue))
            {
                Result = "Showmic brings 3 chocolate on 3rd day.";
            }
            else
            {
                while (SecondValue < Input)
                {
                    NewValue = FirstValue + SecondValue;
                    FirstValue = SecondValue;
                    SecondValue = NewValue;
                    Day++;
                }
                Result = "Showmic brings " + Input + " chocolate on " + Day + "th day.";
            }

            Console.WriteLine(Result);
        }
    }
}