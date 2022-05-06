using System;

class ABC
{

    public static void Main()
    {

        string s1 = "-----holax000000000000*";

        char[] charsToTrim1 = { '*', '0' };

        string s2 = "  abc         ";
        string s3 = "  -ABC--------";

        Console.WriteLine("Antes:");
        Console.WriteLine(s1);
        Console.WriteLine(s2);
        Console.WriteLine(s3);

        Console.WriteLine("");

        Console.WriteLine("Despues:");

        Console.WriteLine(s1.TrimStart(charsToTrim1));
        Console.WriteLine(s2.TrimStart());
        Console.WriteLine(s3.TrimStart('-'));
    }
}