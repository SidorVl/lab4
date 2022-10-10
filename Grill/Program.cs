namespace Program;

class Program
{
    static void Main()
    {
        var grill = new Grill();

        var hotdog1 = grill.CookHotDog(new Ketchup(), new Mustard());

        var hotdog2 = grill.CookHotDog(new Mayonnaise(), new Mustard(), new Ketchup());
        
        Console.WriteLine(hotdog1);
        Console.WriteLine(hotdog2);
    }
}