
﻿class Program
{
    static void Main(string[] args)
    {
        HaloGeneric halo = new HaloGeneric();
        halo.SapaUser("Rayyan");
        DataGeneric<string> nimData = new DataGeneric<string>("103022400121");
        nimData.PrintData();
    }
}

﻿public class HaloGeneric
{
    public void SapaUser<T>(T input)
    {
        Console.WriteLine("Halo user " + input);
    }
}

﻿
public class DataGeneric<T>
{
    private T data;
    public DataGeneric(T data)
    {
        this.data = data;
    }
    public void PrintData()
    {
        Console.WriteLine("Data yang tersimpan adalah: " + this.data);
    }
}

