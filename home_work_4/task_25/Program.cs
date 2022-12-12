// See https://aka.ms/new-console-template for more information
Console.Clear();
Console.Write("Введите первое число: ");
double A = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите второе число: ");
double B = Convert.ToDouble(Console.ReadLine());
double i = 2;
double C = Math.Abs(B);
double result = A;
for( i = 2; i < C + 1; i++){
result = result * A; 
}
Console.WriteLine(result);