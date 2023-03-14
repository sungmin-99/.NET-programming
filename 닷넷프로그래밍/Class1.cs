using System;

public class Class1
{
	public Class1()
	{
        var number = Console.ReadLine();
        if (int.Parse(number) == 0)
        {
            Console.WriteLine("0 입니다.");
        }
        else if (int.Parse(number) < 0)
        {
            Console.WriteLine("음수 입니다.");
        }
        else
        {
            Console.WriteLine("양수 입니다.");
        }
    }
}