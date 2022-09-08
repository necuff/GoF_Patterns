using StrategyPattern.Components;

Context context = new Context(new ConcreteStrategy1());

context.ExecuteOperation();

context.SetStrategy(new ConcreteStrategy2());

context.ExecuteOperation();