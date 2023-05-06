// See https://aka.ms/new-console-template for more information
using OtusEducationHomework6;
using System.Collections;

List<MyClass> ListMyClass = new List<MyClass> ();
for (var i= 0; i< 10; i++)
{
    ListMyClass.Add(new MyClass(i));
}

var maxItem = ClassGetMax<MyClass>.GetMax(ListMyClass, GetParameter);
Console.WriteLine($"Maximum - {maxItem.I}");

static float GetParameter(MyClass item)
{
    return (float)item.I;
}


public class MyClass
{
    public int I;
    public MyClass(int i)
    {
        I = i;
    }
}
