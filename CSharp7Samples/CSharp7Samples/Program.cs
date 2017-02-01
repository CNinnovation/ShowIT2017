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
        int b1 = 0b1010111100001100;

        Console.WriteLine($"{b1:X}");

        int b2 = 0b1010_0000_1111_1100;

        int b3 = b1 | b2;
        Console.WriteLine($"{b3:X}");
    }

    private static void RefLocalAndRefReturn()
    {
        Console.WriteLine(nameof(RefLocalAndRefReturn));
        int[] data = { 1, 2, 3, 4 };
        ref int a = ref GetArrayElement(data, 2);
        Console.WriteLine(a);
        a = 33;
        Console.WriteLine(data[2]);
        Console.WriteLine();
    }

    private static ref int GetArrayElement(int[] arr, int index)
    {
        ref int x = ref arr[index];  // ref local
        return ref x;  // ref return
    }

    private static void OutVars()
    {
        Console.WriteLine(nameof(OutVars));
        Console.WriteLine("enter a number:");
        string input = Console.ReadLine();
        bool success = int.TryParse(input, out var result);
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
        int z = 3;
        int InnerMethod(int x, int y) => x + y + z;
        //{

        //    return x + y + z;
        //}



        int result = InnerMethod(1, 2);
        Console.WriteLine(result);
        Console.WriteLine();

    }

    private static void LambdaExpressionsEverywhere()
    {
        var p = new Person("Stephanie Nagel");
        Console.WriteLine(p.FirstName);
    }

    private static void TuplesAndDeconstruction()
    {
        (var s, var i) = ("magic", 42);
        Console.WriteLine(s);

        var t = Divide(7, 3);
        Console.WriteLine($"result: {t.Result}, reminder: {t.Reminder}");

        var oldtuple = t.ToTuple();
        Console.WriteLine($"result: {oldtuple.Item1}, reminder: {oldtuple.Item2}");
        (var res, var rem) = Divide(18, 4);
        Console.WriteLine($"result: {res}, reminder: {rem}");

        Person p = new Person("Matthias Nagel");
        p.Age = 6;
        (var firstname, var lastname, var age) = p;
        Console.WriteLine($"{firstname}");
    }

    public static (int Result, int Reminder) Divide(int val1, int val2)
    {
        int result = val1 / val2;
        int reminder = val1 % val2;
        return (result, reminder);
    }

    private static void PatternMatching()
    {
        object[] data = { null, 42, new Person("Matthias Nagel"), new Person("Katharina Nagel") };

        foreach (var item in data)
        {
            IsPattern(item);
        }
        foreach (var item in data)
        {
            SwitchPattern(item);
        }


    }

    public static void IsPattern(object o)
    {
        if (o is null) Console.WriteLine("it's a constant pattern");

        if (o is int i) Console.WriteLine($"it's a type pattern with an int and the value {i}");

        if (o is var x) Console.WriteLine($"it's a var pattern with the type {x?.GetType()?.Name}");

        if (o is Person p) Console.WriteLine($"it's a person: {p.FirstName}");

        if (o is Person p2 && p2.FirstName.StartsWith("Ka")) Console.WriteLine($"it's a person starting with Ka {p2.FirstName}");

       


    }

    public static void SwitchPattern(object o)
    {
        switch (o)
        {
            case null:
                Console.WriteLine("it's a constant pattern");
                break;
            case int i:
                Console.WriteLine("it's an int");
                break;
            case Person p when p.FirstName.StartsWith("Ka"):
                Console.WriteLine($"a Ka person {p.FirstName}");
                break;
            case var x:
                Console.WriteLine("it's a var pattern");
                break;
            default:
                break;
        }
    }










}