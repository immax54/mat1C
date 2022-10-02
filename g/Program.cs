using System;
using System.Text;


void Combo()
{
    double f(double x)
    {
        return 2*x+Math.Log10(x)+0.5;
    }

    double df(double x)
    {
        return 2+(1/x);
    }

    double ddf(double x)
    {
        return -(1/(x*x));
    }

    double IntervalNach(double x, double e)
    {
        while (f(x)*f(x+e)>0)
        {
            x=x+e;
        }
        return x;
    }

    double hord(double xn, double xi)
    {
        return xi-f(xi)*(xi-xn)/(f(xi)-f(xn));
    }

    double Kasateln(double x)
    {
        return x-(f(x)/df(x));
    }



    const double NachOtresk = 0;
    const double epsilon = 0.00001;
    const double konc = epsilon*10000;

    double y, y1, y2, y3;
    int n;
    

    Console.WriteLine("Корень ровнения 2*x+Log10(x)+0.5=0 , при диапозоне [0;0,9]");
    double IntervBeg= IntervalNach(NachOtresk, konc);
    double IntervEnd= IntervBeg+konc;
    Console.WriteLine("Уточненный интервал ["+IntervBeg+","+IntervEnd+"]");
    Console.WriteLine("f(a)="+f(IntervBeg)+" f*(a)="+df(IntervBeg));
    Console.WriteLine("f**(a)="+ddf(IntervBeg));
    Console.WriteLine("f(b)="+f(IntervEnd));
    Console.WriteLine("f*(b)="+df(IntervEnd)+" f**(b)="+ddf(IntervEnd));

    if ((f(IntervBeg)<0 & (ddf(IntervBeg)<0)) | ((f(IntervBeg)>=0)&(ddf(IntervBeg)>=0)))
    {
        y1=IntervBeg;
        y=IntervEnd;
        Console.WriteLine("Знаки совпадают у границы [a.a] - точка неподвижна");
    }
    else
    {
        y1=IntervEnd;
        y=IntervBeg;
        Console.WriteLine("Знаки совпадают у границы [b.b] - точка неподвижна");
    }
    n=0;
    while (Math.Abs(y1-y)>=epsilon)
    {
        n++;
        Console.WriteLine("n "+n);
        y2=y;
        y3=y1;
        y1=Kasateln(y3);
        y=hord(y3, y2);
        Console.WriteLine("Xan "+y1);
        Console.WriteLine("F(Xan) "+f(y1));
        Console.WriteLine("Xbn "+y);
        Console.WriteLine("F(Xbn) "+f(y));
        Console.WriteLine("xn-xnx "+(y1-y));
    }
    if (Math.Abs(f(y1))<Math.Abs(f(y)))
    {
        Console.WriteLine("Ответ: "+y1);
    }
    else
    {
        Console.WriteLine("Ответ: "+y);
    }

}

void Interracii()
{   

    const double NachOtresk = 0.1;
    const double KonecOtresk = 0.9;
    const double epsilon= 0.00001;
    const double phi = -0.20599;

    double y, y1, y2;
    int n;

    double dfotphi(double x)
    {
        return 1+(phi*(-(1/(x*x))));
    }

    double ddfotphi(double x)
    {
        return x+(phi*(2*x+Math.Log10(x)+0.5));
    }


    Console.WriteLine("Корень ровнения 2*x+Log10(x)+0.5=0 , при диапозоне [0;0,9]");
    Console.WriteLine("Ф(x)=x-(x+Log10(x)+0.5) ");
    Console.WriteLine("Ф*(a)= "+dfotphi(NachOtresk)+" Ф*(b)= "+dfotphi(KonecOtresk));
    double EndOstanova= epsilon;
    if((dfotphi(NachOtresk)<0) &(dfotphi(KonecOtresk)<0))
    {
        Console.WriteLine("Двусторонняя, критерии останова "+Math.Abs(epsilon));
    }
    else
    {
        EndOstanova=(1-Math.Max(Math.Abs(dfotphi(NachOtresk)), Math.Abs(dfotphi(KonecOtresk))))*epsilon;
        Console.WriteLine("Монотонная, критерии останова "+Math.Abs(EndOstanova));
    }
    y=NachOtresk;
    y1=KonecOtresk;
    n=0;
    while (Math.Abs(y1-y)>Math.Abs(EndOstanova))
    {
        n++;
        if (n==1)
        {
            y=0;
        }
        else
        {
            y=y1;
            y1=ddfotphi(y);
        }
        Console.WriteLine("n "+n);
        Console.WriteLine("Xn "+y1);
        if (Math.Abs(y1-y)<=(EndOstanova))
        {
            Console.WriteLine("|Xn-Xn+1|<=e - Да");
        }
        else
        {
            Console.WriteLine("|Xn-Xn+1|<=e - Нет");
        }
        y2=Math.Abs(y1-y);
        Console.WriteLine("|xn-xn+1|"+y2);

    }
    Console.WriteLine("Ответ: "+y1);
}

Combo();
