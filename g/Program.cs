using System;

namespace ConsoleApp5
{
class Program
{
static void Main(string[] args)
{
void Combo()
{
double f(double x)
{
return 2 * x + Math.Log10(x) + 0.5;
}

double df(double x)
{
return 2 + (1 / x);
}

double ddf(double x)
{
return -(1 / (x * x));
}

double IntervalNach(double x, double a)
{
while (f(x) * f(x + a) > 0)
{
x = x + a;
}
return x;
}

double hord(double xn, double xi)
{
return xi - f(xi) * (xi - xn) / (f(xi) - f(xn));
}

double Kasateln(double x)
{
return x - (f(x) / df(x));
}



double NachOtresk = 0;
double epsilon = 0.00001;
double konc = epsilon * 10000;

double y, y1, y2, y3;
int n;


Console.WriteLine("Корень уровнения 2*x+Log10(x)+0.5=0 , при диапозоне [0;0,9]");
double IntervBeg = IntervalNach(NachOtresk, konc);
double IntervEnd = IntervBeg + konc;
Console.WriteLine("Уточненный интервал [" + IntervBeg + "," + IntervEnd + "]");
Console.WriteLine("f(a)=" + f(IntervBeg) + " f*(a)=" + df(IntervBeg));
Console.WriteLine("f**(a)=" + ddf(IntervBeg));
Console.WriteLine("f(b)=" + f(IntervEnd));
Console.WriteLine("f*(b)=" + df(IntervEnd) + " f**(b)=" + ddf(IntervEnd));

if ((f(IntervBeg) < 0 & (ddf(IntervBeg) < 0)) | ((f(IntervBeg) >= 0) & (ddf(IntervBeg) >= 0)))
{
y1 = IntervBeg;
y = IntervEnd;
Console.WriteLine("Знаки совпадают у границы [a.a] - точка неподвижна");
}
else
{
y1 = IntervEnd;
y = IntervBeg;
Console.WriteLine("Знаки совпадают у границы [b.b] - точка неподвижна");
}
n = 0;
Console.WriteLine("n " + " Xan " + " F(Xan) " + " Xbn " + " F(Xbn) " + " razn xn-xn2 ");
while (Math.Abs(y1 - y) >= epsilon)
{
n++;

y2 = y;
y3 = y1;
y1 = Kasateln(y3);
y = hord(y3, y2);
string Yout = y1.ToString()+"00000000000000";
if (n != 1 & n<8)
{
Console.WriteLine(n + " " + y1 + " " + f(y1) + " " + y + " " + f(y) + " " + (y1 - y));
}
if (n == 1)
{
Console.WriteLine(n + " " + Yout + " " + f(y1) + " " + y + " " + f(y) + " " + (y1 - y));
}
if (f(y) == 0)
{
Console.WriteLine(n + " " + y1 + " " + f(y1) + " " + y + " " + f(y) + " " + (y1 - y));
}
}
if (Math.Abs(f(y1)) < Math.Abs(f(y)))
{
Console.WriteLine("Ответ: " + y1);
}
else
{
Console.WriteLine("Ответ: " + y);
}

}

void Iterracii()
{

double NachOtresk = 0.1;
double KonecOtresk = 0.9;
double epsilon = 0.00001;
double phi = -0.20599;

double y, y1, y2;
int n;

double dfotphi(double x)
{
return 1 + (phi * (-(1 / (x * x))));
}

double ddfotphi(double x)
{
return x + (phi * (2 * x + Math.Log10(x) + 0.5));
}


Console.WriteLine("Корень ровнения 2*x+Log10(x)+0.5=0 , при диапозоне [0;0,9]");
Console.WriteLine("Ф(x)=x-(x+Log10(x)+0.5) ");
Console.WriteLine("Ф*(a)= " + dfotphi(NachOtresk) + " Ф*(b)= " + dfotphi(KonecOtresk));
double EndOstanova = epsilon;
if ((dfotphi(NachOtresk) < 0) & (dfotphi(KonecOtresk) < 0))
{
Console.WriteLine("Двусторонняя, критерии останова " + Math.Abs(epsilon));
}
else
{
EndOstanova = (1 - Math.Max(Math.Abs(dfotphi(NachOtresk)), Math.Abs(dfotphi(KonecOtresk)))) * epsilon;
Console.WriteLine("Монотонная, критерии останова " + Math.Abs(EndOstanova));
}
y = NachOtresk;
y1 = KonecOtresk;
n = 0;
while (Math.Abs(y1 - y) > Math.Abs(EndOstanova))
{
n++;
if (n == 1)
{
y = 0;
}
else
{
y = y1;
y1 = ddfotphi(y);
}
Console.WriteLine("n " + n);
Console.WriteLine("Xn " + y1);
if (Math.Abs(y1 - y) <= (EndOstanova))
{
Console.WriteLine("|Xn-Xn+1|<=e - Да");
}
else
{
Console.WriteLine("|Xn-Xn+1|<=e - Нет");
}
y2 = Math.Abs(y1 - y);
Console.WriteLine("|xn-xn+1|" + y2);

}
Console.WriteLine("Ответ: " + y1);
}

Combo();
}
}
}
