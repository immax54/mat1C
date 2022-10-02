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

    double startinterval(double x, double e)
    {
        while (f(x)*f(x+e)>0)
        {
            x=x+e;
        }
        return x;
    }

    double horda(double xn, double xi)
    {
        return xi-f(xi)*(xi-xn)/(f(xi)-f(xn));
    }

    double kasat(double x)
    {
        return x-(f(x)/df(x));
    }



    const double pa = 0;
    const double pb = 0.9;
    const double ce = 0.00001;
    const double cel = ce*10000;

    double y, y1, y2, y3;
    int n;
    double[] xn;
    double[] dxn;
    double e;
    double int1, int2;

    Console.WriteLine("Корень ровнения 2*x+Log10(x)+0.5=0 , при диапозоне [0;0,9]");
    int1=startinterval(pa, cel);
    int2=int1+cel;
    Console.WriteLine("Уточненный интервал ["+int1+","+int2+"]");
    Console.WriteLine("f(a)="+f(int1)+" f*(a)="+df(int1));
    Console.WriteLine("f**(a)="+ddf(int1));
    Console.WriteLine("f(b)="+f(int2));
    Console.WriteLine("f*(b)="+df(int2)+" f**(b)="+ddf(int2));

    if ((f(int1)<0 & (ddf(int1)<0)) | ((f(int1)>=0)&(ddf(int1)>=0)))
    {
        y1=int1;
        y=int2;
        Console.WriteLine("Знаки совпадают у границы [a.a] - точка неподвижна");
    }
    else
    {
        y1=int2;
        y=int1;
        Console.WriteLine("Знаки совпадают у границы [b.b] - точка неподвижна");
    }
    n=0;
    while (Math.Abs(y1-y)>=ce)
    {
        n++;
        Console.WriteLine("n "+n);
        y2=y;
        y3=y1;
        y1=kasat(y3);
        y=horda(y3, y2);
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

void Integral()
{
    double f(double x)
    {
        return 2*x+Math.Log10(x)+0.5;
    }


    double ddf(double x)
    {
        return -(1/(x*x));
    }


    double sdf(double x)
    {
        return 2+(1/x);
    }

    double sddf(double x)
    {
        return -(1/(x*x));
    }

    double startinterval(double x, double e)
    {
        while (f(x)*f(x+e)>0)
        {
            x=x+e;
        }
        return x;
    }

    double phi(double x)
    {
        return x-(x+Math.Log10(x)+0.5);
    }


    double startintervals(double x, double e)
    {
        while (f(x)*f(x+e)>0)
        {
            x=x+e;
        }
        return x;
    }

   

    const double a = 0.1;
    const double b = 0.9;
    const double ce = 0.00001;
    const double k = -0.3;

    double y, y1, y2;
    int n;
    double[] xn;
    double[] dxn;
    double e;

    double df(double x)
    {
        return 1+(k*(-(1/(x*x))));
    }

    double sf(double x)
    {
        return x+(k*(2*x+Math.Log10(x)+0.5));
    }


    Console.WriteLine("Корень ровнения 2*x+Log10(x)+0.5=0 , при диапозоне [0;0,9]");
    Console.WriteLine("Ф(x)=x-(x+Log10(x)+0.5) ");
    Console.WriteLine("Ф*(a)= "+df(a)+" Ф*(b)= "+df(b));
    e=ce;
    if((df(a)<0) &(df(b)<0))
    {
        Console.WriteLine("Двусторонняя, критерии останова "+Math.Abs(ce));
    }
    else
    {
        e=(1-Math.Max(Math.Abs(df(a)), Math.Abs(df(b))))*ce;
        Console.WriteLine("Монотонная, критерии останова "+Math.Abs(e));
    }
    y=a;
    y1=b;
    n=0;
    while (Math.Abs(y1-y)>Math.Abs(e))
    {
        n++;
        if (n==1)
        {
            y=0;
        }
        else
        {
            y=y1;
            y1=sf(y);
        }
        Console.WriteLine("n "+n);
        Console.WriteLine("Xn "+y1);
        if (Math.Abs(y1-y)<=(e))
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
