namespace Interview.DesignPattern.AbstractFactory;

internal class Lion : Carnivore
{
    public override void Eat(Herbivore herbivore)
    {
        Console.WriteLine($"{nameof(Lion)} eats {herbivore.GetType().Name}");
    }
}
