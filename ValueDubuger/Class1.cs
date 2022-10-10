using System.Diagnostics;

namespace ValueDubuger;

public class Class1
{
    virtual internal void Write(string stringParam, int intParam)
    {
        Debug.WriteLine("String Parameter: " + stringParam);
        Debug.Write("Integer Parameter: " + intParam);
    }
}