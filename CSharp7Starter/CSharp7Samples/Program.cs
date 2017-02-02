﻿using CSharp7Samples;
using System;

class Program
{
    static void Main(string[] args)
    {
        BinaryLiteralsAndDigitSeparators();
        RefLocalAndRefReturn();
        OutVars();
        LocalFunctions();
        LambdaExpressionsEverywhere();
        PatternMatching();
        TuplesAndDeconstruction();
    }

    private static void BinaryLiteralsAndDigitSeparators()
    {
        Console.WriteLine(nameof(BinaryLiteralsAndDigitSeparators));

        Console.WriteLine();
    }

    private static void RefLocalAndRefReturn()
    {
        Console.WriteLine(nameof(RefLocalAndRefReturn));

        Console.WriteLine();
    }


    private static void OutVars()
    {
        Console.WriteLine(nameof(OutVars));
        Console.WriteLine("enter a number:");
        string input = Console.ReadLine();
        int result;
        bool success = int.TryParse(input, out result);
        if (success)
        {
            Console.WriteLine($"this number: {result}");
        }
        else
        {
            Console.WriteLine("NaN");
        }
        Console.WriteLine();
    }

    private static void LocalFunctions()
    {
        Console.WriteLine(nameof(LocalFunctions));

        Console.WriteLine();
    }

    private static void LambdaExpressionsEverywhere()
    {
        Console.WriteLine(nameof(LambdaExpressionsEverywhere));

        Console.WriteLine();
    }

    private static void TuplesAndDeconstruction()
    {
        Console.WriteLine(nameof(TuplesAndDeconstruction));

        Console.WriteLine();
    }



    private static void PatternMatching()
    {
        Console.WriteLine(nameof(PatternMatching));

        Console.WriteLine();
    }

    public static void IsPattern(object o)
    {

    }

    public static void SwitchPattern(object o)
    {

    }
}