using System;
public class Program
{
    public static void Main(string[] args)
    {
        string s = "11299211";
        string leftString = "";
        string rightString = "";
        int halfString = 0;
        if (s.Length % 2 == 0)
        {
            halfString = s.Length / 2;
            for (int i = 0; i < halfString; i++)
            {
                leftString += s[i];
                rightString += s[s.Length-1-i];
            }
            Console.WriteLine(leftString);
            Console.WriteLine(rightString);

            if (rightString == leftString)
            {
                Console.WriteLine("True");
            } else
            {
                Console.WriteLine("Flase");
            }

        }
        else
        {
            Console.WriteLine("False");
        }
    }
}