using DecoratorPattern.Components;

ConcreteComponent c = new ConcreteComponent();
ConcreteDecoratorA dA = new ConcreteDecoratorA();
ConcreteDecoratorB dB = new ConcreteDecoratorB();

dA.SetComponent(c);
dB.SetComponent(dA);

dB.Operation();
Console.WriteLine();

dA.Operation();
Console.WriteLine();

c.Operation();
Console.ReadLine();