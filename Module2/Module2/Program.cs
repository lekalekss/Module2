﻿using System.Reflection.Emit;
using System.Runtime.Serialization;
using Module2;

internal class Program
{
    private static void Main(string[] args)
    {
        //Task 1. The simple string interpolation

        string nameOfUser = "Voldemar";
        int ageOfUser = 487;
        string cityOfuserLive = "Transilvania";

        Console.WriteLine($"Hello {nameOfUser}! You are {ageOfUser} years old and you are still living in {cityOfuserLive}!\n");


        //Task 2. math interpolation

        float firstNumber = 125.7675f;
        float secondNumber = 546.8374f;

        Console.WriteLine($"Additional of numbers is {firstNumber + secondNumber}");
        Console.WriteLine($"Substraction of numbers is {firstNumber - secondNumber}");
        Console.WriteLine($"Multiplication of numbers is {firstNumber * secondNumber}");
        Console.WriteLine($"Division of numbers is {firstNumber / secondNumber}");

        //Task 3. Lovely expression

        string lovelyExpression = "Winner, winner - chicken dinner";
        Console.WriteLine($"\nString lenght is {lovelyExpression.Length} symbols. " +
            $"The string is: {lovelyExpression}" );

        //Task 4. Date interpolation

        var dateCurrent = DateOnly.FromDateTime( DateTime.Now );
        var timeCurrent = TimeOnly.FromDateTime( DateTime.Now );

        Console.WriteLine($"\nToday is {dateCurrent} and current time in CST is {timeCurrent}\n");

        //Task 1. Static class

        int additional = MathHelper.Additional(999, 33);
        int substract = MathHelper.Subtract(999, 33);
        int multiply = MathHelper.Multiply(999, 33);
        int divide = MathHelper.Divide(999, 33);

        Console.WriteLine($"Math results of two number (999 and 33) are next:" +
            $"\nAdditional is {additional};" +
            $"\nSubstract is {substract};" +
            $"\nMultiply is {multiply};" +
            $"\nDivide is {divide}.");


        //Task 2. Static utility

        string reverseName = StringUnits.ReverseName("\nAlex Lekomtsev");
        Console.WriteLine(reverseName);

        //Task 3. Work with constants

        Console.WriteLine($"\nthe Pi number is equal {Constants.Pi}");
        Console.WriteLine($"Max attempts number in this game is {Constants.maxAttemptsNumber}");
        Console.WriteLine($"My lovely social media web site is {Constants.lovelyWebSite}");


        //Task 4. Method call counter

        Counter.Increment();
        Counter.Increment();
        Counter.Increment();
        Counter.Increment();
        Console.WriteLine($"\nWe called method {Counter.CallCount} times");

        //Task 1. Reloading method for addition numbers

        int additionalAdd = Add.AddNumbers(12, 56);
        float additionalFloat = Add.AddNumbers(12.77776f, 56.64645f);
        Console.WriteLine($"\nWe got two results:" +
            $"\nFirst: {additionalAdd};" +
            $"\nSecond: {additionalFloat}");

        //Task 2. Reloading method for strings

        Console.WriteLine();
        Add.Concatenate("Aleksandr", "Lekomtsev");
        Add.Concatenate("Aleksandr", "Lekomtsev", "Alex");

        //Task 3. Reloading method with different data

        Console.WriteLine() ;
        Add.PrinInfo("Valter", 67);
        Add.PrinInfo("Valter", 67, "John Howard street 89");

        //Task 4. Reloading method with default parameters

        Console.WriteLine();

        int resultOfParameters = Add.Calculate(66, 11);
        Console.WriteLine(resultOfParameters);

        int newResultOfParameters = Add.Calculate(66, 11, "/");
        Console.WriteLine(newResultOfParameters);

        //Task 1. Creating and using inheritance

        Car suv = new Car();
        suv.ProductionYear = 2024;
        suv.Model = "Porshe";
        suv.SpeedMax = 254;
        suv.NumberOfDoors = 5;

        Console.WriteLine($"\nNew {suv.Model} {suv.ProductionYear} year production with " +
            $"{suv.NumberOfDoors} doors can reach maximum speed {suv.SpeedMax} km/hr. We advise!");

        Car coupe = new Car();
        coupe.SpeedMax = 224;
        coupe.NumberOfDoors = 2;
        coupe.Model = "Audi";
        coupe.ProductionYear = 2006;

        Console.WriteLine($"\n{coupe.Model} coupe {coupe.ProductionYear} year production is " +
            $"one of the most comfortable vehicle. It can accelerate to {coupe.SpeedMax} km/hr. " +
            $"Very nice vehicle with {coupe.NumberOfDoors} big doors.");

        //Task 2.

        Meat beef = new Meat();
        beef.Price = 26;
        beef.ScuNumber = "23mb56";
        beef.ExpiryDate = DateTime.UtcNow;
        beef.StoredInTheFridge = true;

        Console.WriteLine();
        Console.WriteLine($"Fresh beef Scu # {beef.ScuNumber} is cost {beef.Price} $/lb. " +
            $"Expired date is {beef.ExpiryDate}. Need to keep refrigerated: {beef.StoredInTheFridge}");

        Fish dorado = new Fish();
        dorado.ScuNumber = "567fd";
        dorado.ExpiryDate = new DateTime (2024, 5, 24);
        dorado.Price = 28;
        dorado.Farmed = false;

        Console.WriteLine();
        Console.WriteLine($"Fresh dorado scu # is {dorado.ScuNumber} cost {dorado.Price} kg. " +
            $"Expired date is {dorado.ExpiryDate}. Farmed: {dorado.Farmed}");









    }
}