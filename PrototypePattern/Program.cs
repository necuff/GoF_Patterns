using PrototypePattern.Components;

Prototype prototype1 = new ConcretePrototype1("1");
Prototype clonedPrototype = prototype1.Clone();

Console.WriteLine($"Cloned: {clonedPrototype.Id}");

Prototype prototype2 = new ConcretePrototype2("2");
Prototype clonedPrototype2 = prototype2.Clone();

Console.WriteLine($"Cloned: {clonedPrototype2.Id}");

Console.ReadLine();