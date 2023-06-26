using Builder.Classes;
using Builder.Interfaces;

internal class Program
{
    private static void Main(string[] args)
    {
        // creating instances of Builder and Director
        DishBuilder dishBuilder = new DishBuilder();
        Director director = new Director();

        // setting a builder which director will use
        director.builder = dishBuilder;

        // presentation of creating a dish with use of a builder
        dishBuilder.AddIngredientA("Flour");
        dishBuilder.AddIngredientB("Tomatoes");
        dishBuilder.AddIngredientC("Cheese");

        // serving the dish, so the builder should reset (will store a new instance of a dish)
        dishBuilder.ServeDish();

        //presentation of creating a dish with use of a director
        director.BuildBigDish("Water", "Garlic", "Tomato");
        dishBuilder.ServeDish();

        director.BuildSmallDish("Meat", "Potato");
        dishBuilder.ServeDish();

        Console.ReadLine();

    }
}