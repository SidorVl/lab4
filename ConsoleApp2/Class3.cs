using System.Diagnostics;

namespace Program;

public class Class3: Class2
{
    public Class3(string receiver, int price, DateTime date) : base(receiver, price, date){}
    
    public override void DebugValue()
    {
        Debug.WriteLine(_date.ToLongTimeString());
    }
}