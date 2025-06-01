using System;

class Program
{
    static void Main(string[] args)
    {
        Fraction f1 =  new Fraction();
        Fraction f2 = new Fraction(5);
        Fraction f3 = new Fraction (3,4);
        Fraction f4 = new Fraction (1,3);
        
        string strFract1 = f1.GetFractionString();
        double decFract1 = f1.GetDecimalValue();

        string strFract2 = f2.GetFractionString();
        double decFract2 = f2.GetDecimalValue();
        
        string strFract3 = f3.GetFractionString();
        double decFract3 = f3.GetDecimalValue();

        string strFract4 = f4.GetFractionString();
        double decFract4 = f4.GetDecimalValue();

        Console.WriteLine(strFract1);
        Console.WriteLine(decFract1);

        Console.WriteLine(strFract2);
        Console.WriteLine(decFract2);

        Console.WriteLine(strFract3);
        Console.WriteLine(decFract3);

        Console.WriteLine(strFract4);
        Console.WriteLine(decFract4);
       
    }
}