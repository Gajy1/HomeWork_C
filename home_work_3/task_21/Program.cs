Console.Clear();
Console.WriteLine("Ведите координаты первой точки(x,y,z):");
double x = Convert.ToDouble(Console.ReadLine());
double y = Convert.ToDouble(Console.ReadLine());
double z = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("");
Console.WriteLine("Ведите координаты второй точки(x,y,z):");
double x1 = Convert.ToDouble(Console.ReadLine());
double y1 = Convert.ToDouble(Console.ReadLine());
double z1 = Convert.ToDouble(Console.ReadLine());


double l = ((x1 - x)*(x1 - x) + (y1 - y)*(y1 - y) + (z1 - z)*(z1 - z));

double result = (Math.Sqrt(l));
Console.WriteLine("");
Console.WriteLine(result);

