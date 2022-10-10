using System.Diagnostics;

namespace Program;

public class Class4: Class2
{
    public Class4(string receiver, int price, DateTime date) : base(receiver, price, date){}
    
    public override void DebugValue()
    {
        Debug.WriteLine(_price.ToString());
    }
}