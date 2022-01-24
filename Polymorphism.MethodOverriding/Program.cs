// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


public class MobilePhone
{
    public virtual void Typing()
    {
        Console.WriteLine("Using Keypad");
    }
}

public class SmartPhone : MobilePhone
{
    public override void Typing()
    {
        Console.WriteLine("Using QWERTY Keyboard");
    }
}