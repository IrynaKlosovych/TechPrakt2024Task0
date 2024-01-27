Console.WriteLine("Write first num:");
bool ok = false;
float num1=0, num2=0;
while(!ok)
{
    ok = float.TryParse(Console.ReadLine(), out num1);
    if(!ok) Console.WriteLine("It's not a number");
}
Console.WriteLine("Write second num:");
ok = false;
while (!ok)
{
    ok = float.TryParse(Console.ReadLine(), out num2);
    if(!ok)Console.WriteLine("It's not a number");
}
Console.WriteLine($"{num1} + {num2} = {num1+num2}");