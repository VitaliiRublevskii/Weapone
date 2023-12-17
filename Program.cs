using ConsoleApp2;

void FieldIter(Soldier a, Soldier b, Soldier c)
{
    a.Combo(b);
    b.Combo(c);
    c.Combo(a);

    Console.WriteLine(a);
    Console.WriteLine(b);
    Console.WriteLine(c);
}


void Round(Soldier v, Soldier p, Soldier n)
{
    Console.WriteLine(v);
    Console.WriteLine(p);
    Console.WriteLine(n);
    Console.WriteLine();
    int step = 0;
    do
    {
        Console.Write(new String('*', 5));
        Console.Write($"  ROUND {step}   ");
        Console.Write(new String('*', 5));
        Console.WriteLine(  );
        FieldIter(v, p, n);
       
        Console.WriteLine(  );
        step += 1;
    } while (v.IsAlive && p.IsAlive && n.IsAlive);

}




Soldier v = new Soldier("Vasya", new Sword(), new ShieldMet());
Soldier p = new Soldier("Petya", new Hummer(), new ShieldWood());
Soldier n = new Soldier("Nikolay", new Spiare(), new ShieldWood());
Round(v, p, n);