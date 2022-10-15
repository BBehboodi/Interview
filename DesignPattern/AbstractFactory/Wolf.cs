namespace Interview.DesignPattern.AbstractFactory;

internal class Wolf : Carnivore
{
    public override void Eat(Herbivore herbivore)
    {
        Console.WriteLine($"{nameof(Wolf)} eats {herbivore.GetType().Name}");
    }
}
