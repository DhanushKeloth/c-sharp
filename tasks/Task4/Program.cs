using System.ComponentModel;
using System.Reflection.Metadata.Ecma335;

class Program
{

    public delegate bool Paymentmethod(int amount);
    public static void Getpayment(int amount,Paymentmethod pm)
    {
        bool paymentstatus = pm(amount);
        if(paymentstatus) Console.WriteLine("payment is success");
        else Console.WriteLine("payment is failed due to error");
    }

    public delegate int Operationdel(int a,int b);
    public static void Calc(int a,int b,Operationdel op)
    {
        int result =op(a,b);
        Console.WriteLine("result is "+result);
    }
    public static int Add(int a,int b)=>a+b;

    static void Main(string[] args)
    {
        Getpayment(100,(int amount)=> {
            Console.WriteLine("payment amount is with credit card"+amount);
            return true;
            });
        Getpayment(200,(int amount)=> {
            Console.WriteLine("payment amount is with debit card"+amount);
            return true;
            });

        // Calc(10,20,(int a,int b)=>a*b);
    }
}