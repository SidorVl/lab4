

namespace Program;

class Program
{
    static void Main()
    {
        var receiver = "Csgo";
        var price = 23;
        var date = DateTime.Now;

        Class2[] debuggers = { new Class3(receiver, price, date), new Class4(receiver, price, date), new Class5(receiver, price, date)};

        foreach (var debugger in debuggers)
        {
            debugger.DebugValue();
        }
        
    }
}