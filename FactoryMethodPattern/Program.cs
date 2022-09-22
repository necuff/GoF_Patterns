using FactoryMethodPattern.Components;

Creator[] creators = { new ConcreteCreatorA(), new ConcreteCreatorB() };

foreach(Creator creator in creators)
{
    Product product = creator.FactoryMethod();
    Console.WriteLine($"Crated {product.GetType()}");
}

Console.ReadLine();