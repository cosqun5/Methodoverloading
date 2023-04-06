namespace Method_overloading
{
    internal class Program
    {
        //#region Task2

        //static void Main(string[] args)
        //{

        //    Console.Write("ededi daxil edin:");
        //    int eded = int.Parse(Console.ReadLine());
        //    Console.WriteLine("quvveti daxil etmek isteyirsen?He/yox");
        //    int netice = 1;
        //    string answer= Console.ReadLine();
        //    if (answer!="He")
        //    {
        //        Print(eded, netice);
        //    }
        //    else
        //    {
        //        Console.Write("quvveti daxil edin:");
        //       int quvvet =int.Parse(Console.ReadLine());
        //      Print(eded,netice,quvvet);

        //    }

        //}

        //static void Print(int eded, int netice)
        //{
        //    if (eded > 0)
        //    {
        //        netice = eded * eded;
        //        Console.WriteLine("netice" + " " + netice);
        //    }
        //}
        //static void Print(int eded, int netice,int quvvet)
        //{
        //    for (int i = 0; i <quvvet; i++)
        //    {
        //        netice = netice * eded;
        //    }
        //    Console.WriteLine("netice" +" "+ netice);
        //}
        //#endregion

        //#region Task1
        //static void Main(string[] args)
        //{
        //    Console.WriteLine("Fiqurlarin Sahelerinin Hesablanmasi.");
        //    Console.WriteLine("Cevrenin sahesi:1");
        //    Console.WriteLine("Duzbucaqlinin sahesi:2");
        //    Console.WriteLine("Düzbucaqlı paralelpipedin tam sethinin sahesi:3");
        //    Console.WriteLine("Üçbucaqlının daxilinə çekilmiş çevrənin sahesi:4");
        //    int cavab =int.Parse(Console.ReadLine());
        //    if (cavab==1)
        //    {
        //        Console.WriteLine("Cevrenin radiusunu daxil edin:");
        //        int r = int.Parse(Console.ReadLine());  
        //        Area(r);
        //    }
        //    else if (cavab == 2)
        //    {
        //        Console.WriteLine("Duzbucaqlinin tereflerini daxil edin:");
        //        int a = int.Parse(Console.ReadLine());
        //        int b = int.Parse(Console.ReadLine());
        //        Area(a,b);
        //    }
        //    else if (cavab == 3)
        //    {
        //        Console.WriteLine("Düzbucaqlı paralelpipedin tereflerini daxil edin:");
        //        int a = int.Parse(Console.ReadLine());
        //        int b = int.Parse(Console.ReadLine());
        //        int c = int.Parse(Console.ReadLine());
        //        Area(a, b, c);
        //    }
        //    else if (cavab == 4)
        //    {
        //        Console.WriteLine("Üçbucaqin tereflerini ve daxiline cekilmis cevrenin radiusunu daxil edin:");
        //        int a = int.Parse(Console.ReadLine());
        //        int b = int.Parse(Console.ReadLine());
        //        int c = int.Parse(Console.ReadLine());
        //        Console.WriteLine("radiusu daxil edin");
        //        int r = int.Parse(Console.ReadLine());
        //        Area(a, b, c,r);
        //    }
        //    else
        //    {
        //        Console.WriteLine("Emeliyyat movcud deyil!");
        //    }
        //}
        //static void Area(int r)
        //{
        //    int p = 3;
        //    int sahe = p * r * r;
        //    Console.WriteLine("Cevrenin sahesi:" + " " + sahe);
        //}
        //static void Area(int a, int b)
        //{
        //    int sahe = a * b;
        //    Console.WriteLine("Duzbucaqlinin sahesi:" + " " + sahe);
        //}
        //static void Area(int a, int b, int c)
        //{
        //    int sahe = 2 * (a * b + a * c + b * c);
        //    Console.WriteLine("Düzbucaqlı paralelpipedin tam səthinin sahəsi" + " " + sahe);
        //}
        //static void Area(int a, int b, int c, int r)
        //{
        //    int p = (a + b + c) / 2;
        //    int sahe = p * r;
        //    Console.WriteLine("Üçbucaqlının daxilinə çəkilmiş çevrənin sahəsi" + " " + sahe);
        //}
        //#endregion
    }
}