using System;

public class Class1
{
	public Class1()
	{
        List<int> list = new List<int>();

        while (true)
        {
            var tmp = int.Parse(Console.ReadLine());
            if (tmp == 0)
            {
                break;
            }
            if (!(list.Contains(tmp)))
            {
                list.Add(tmp);
            }
        }
        for (int i = 0; i < list.Count; i++)
        {
            Console.Write(list[i]);
        }
    }
}
