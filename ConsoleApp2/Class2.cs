namespace Program;

public abstract class Class2: Class1
{
    public Class2(string receiver, int price, DateTime date) : base(receiver, price, date){}

    virtual public void DebugValue() { }
}