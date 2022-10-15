namespace Interview.DesignPattern.AbstractFactory;

internal abstract class ContinentFactory
{
    public abstract Herbivore CreateHerbivore();

    public abstract Carnivore CreateCarnivore();
}