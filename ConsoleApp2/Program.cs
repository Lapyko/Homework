string a = Console.ReadLine();
    int c=5;
string[] Psrt;
Psrt=a.Split();
for (int i = 0; i < Psrt.Length; i++)
    if (Psrt[i].Length == c) Console.WriteLine(Psrt[i]);
Console.ReadLine();

