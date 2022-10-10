using System.Diagnostics;

namespace Program;

public class Class5: Class2
{
    public Class5(string receiver, int price, DateTime date) : base(receiver, price, date){}
    
    public override void DebugValue()
    {
        Debug.WriteLine(_receiver);
    }
}