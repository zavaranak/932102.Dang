public abstract class Builder
{
    public abstract List<string> GetAvailableIngredients();
    public abstract List<BuildDrinkWithBaseSpirit> BuildCocktail(List<string> ingredients);
}

public class VodkaBuilder : Builder
{
    public override List<string> GetAvailableIngredients()
    {
        return new List<string>() { "Vodka", "Nước chanh", "Đường", "Nước cam" };
    }

    public override List<BuildDrinkWithBaseSpirit> BuildCocktail(List<string> ingredients)
    {
        var cocktails = new List<BuildDrinkWithBaseSpirit>();

        if (ingredients.Contains("Nước chanh") && ingredients.Contains("Đường"))
        {
            cocktails.Add(new VodkaGimlet());
        }

        if (ingredients.Contains("Nước cam"))

        {
            cocktails.Add(new Screwdriver());
        }

        return cocktails;
    }
}

public class BuildDrinkWithBaseSpirit
{
    public List<string> Ingredients { get; set; }
    public string Instructions { get; set; }
}

public class VodkaGimlet : BuildDrinkWithBaseSpirit
{
    public VodkaGimlet()
    {
        Ingredients = new List<string>() { "Vodka", "Nước chanh", "Đường" };
        Instructions = "";
    }
}

public class Screwdriver : BuildDrinkWithBaseSpirit
{
    public Screwdriver()
    {
        Ingredients = new List<string>() { "Vodka", "Nước cam" };
        Instructions = "";
    }
}
