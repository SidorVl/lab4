namespace ValueDubuger;

public class Class2 : Class1
{
    internal override void Write(string stringParam, int intParam)
    {
        var Color = Console.ForegroundColor;

        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("String Parameter: " + stringParam.GetType());

        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine("String Parameter: " + intParam.GetType());

        Console.ForegroundColor = Color;
    }
}