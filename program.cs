// using System;
// Console.Write("a=?,b=?");
// string input = Console.ReadLine();
// string[] parts = input.Split(' ');
// int a = int.Parse(parts[0]);
// int b = int.Parse(parts[1]);
// double plos =  a * b;
// double per = 2 *(a +b );
// Console.WriteLine(plos);
// Console.WriteLine(per);


// using System;
// double rub_us = 84.14;
// Console.Write("how much rub?");
// string input = Console.ReadLine();
// double rus = double.Parse(input);
// double usd = rus / rub_us;
// Console.WriteLine(usd);

// using System;
// string input =Console.ReadLine();
// string[] parts = input.Split(' ');
// double sum = 0;
// foreach (string part in parts)
// {
//     sum += double.Parse(part); 
// }
// double average = sum / parts.Length;
// System.Console.WriteLine($"\n average {average}°C");

// using System;
// for (int sas = 1;sas <=3;sas++)
// {
//     Console.Write($"osenka for student {sas}:");
//     string input = Console.ReadLine();
//     string[]p = input.Split(' ');
//     double sum = 0;
//     foreach (string part in p)
//     {
//         sum+=int.Parse(part);
    
//     }
//     double aver =sum /p.Length;
//     Console.WriteLine($" stud {sas}  averaga {aver:F1}\n");
// } 
using System;
int[,]x = new int [3, 3];
int[,]y = new int [3, 3];
Console.WriteLine("9 chisel");
string input = Console.ReadLine();
string[] parts = input.Split(' ');
int count = 0; 
for (int i = 0; i < 3; i++)
{
    for (int j = 0; j < 3; j++)
    {
        x[i, j] = int.Parse(parts[count]);
        count++;
    }
}
for (int i = 0; i < 3; i++)
{
    for (int j = 0; j < 3; j++)
    {
        
        y[i, j] = x[j, i]; 
    }
}
Console.WriteLine("sas");
for (int i = 0; i < 3; i++)
{
    for (int j = 0; j < 3; j++)
    {
        Console.Write(y[i, j] + "\t");
    }
    Console.WriteLine();
}
