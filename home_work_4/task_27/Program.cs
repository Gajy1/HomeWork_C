Console.Clear();
Console.Write("Ввудите число: ");
string n = Console.ReadLine();
int s = n.Length; 
int i = 1;
int x = Convert.ToInt32(n[0].ToString());
for(i = 1; i < s; i++)
{
    x = x + Convert.ToInt32(n[i].ToString());
}
Console.WriteLine(x);