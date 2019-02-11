using System;
public class Car
{
    protected int id;
    protected string name;
    public Car(string name)
    {
        this.name = name;
    }
    public Car()
    { }
    public virtual void Display()
    {
         Console.WriteLine("heloo Car Class");
    }
}
public class Maruti : Car
{
    int price;

    public Maruti(int id, string name, int price) : base(name)
    {
        this.id = id;
        this.price = price;
        
    }
    public override void  Display()
    {
        Console.WriteLine("car id ="+id+" car name="+name+"car price="+price);
    }
}
public class Ford:Car
{
    int price;

    public Ford(int id,string name, int price )
    {
        this.id = id;
        this.name = name;
        this.price = price;
    }
    public override void Display()
    {
        Console.WriteLine("car id ="+id+" car name="+name+"car price="+price);
    }
}
public class Pro4
{
    public static void Main()
    {
        Maruti m1 = new Maruti(102,"alto800",3000000);
        Ford f1 = new Ford(10005, "frod111", 4300000);
        m1.Display();
        f1.Display();
    }
}
