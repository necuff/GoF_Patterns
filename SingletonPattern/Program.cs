using SingletonPattern;

Singleton s = Singleton.GetInstance();

Console.WriteLine(s.Name);

s.SetName("This is new name");

Console.WriteLine(s.Name);

Singleton s2 = Singleton.GetInstance();

Console.WriteLine(s2.Name);

s2.SetName("Super new name");

Console.WriteLine(new String('-', 10));
Console.WriteLine(s.Name);
Console.WriteLine(s2.Name);