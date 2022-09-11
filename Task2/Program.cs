double k1 = Int32.Parse(Console.ReadLine());
double k2 = Int32.Parse(Console.ReadLine());
double b1 = Int32.Parse(Console.ReadLine()); 
double b2 = Int32.Parse(Console.ReadLine());
double x = (b2-b1)/(k1-k2);
double y = k1*x + b1;
Console.WriteLine("Координаты общих точек: x = " + x + ", y = " + y );
