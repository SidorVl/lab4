using Program;

namespace ValueDubuger;

class Program
{
    static void Main()
    {
        var cl2 = new Class2();

        cl2.Write("gast", 333);
        var cl1 = new Class1();
        cl1.Write("hol", 456);
    }
}