namespace Program;

public class Grill
{
    public HotDog CookHotDog(HotDogIngredient ingredient1, HotDogIngredient ingredient2)
    {
        HotDogIngredient[] hotdogIngredients = { new BunAndSausage(), ingredient1, ingredient2 }; 
        
        return new HotDog(hotdogIngredients);
    }
    
    public HotDog CookHotDog(HotDogIngredient ingredient1, HotDogIngredient ingredient2, HotDogIngredient ingredient3)
    {
        HotDogIngredient[] hotdogIngredients = { new BunAndSausage(), ingredient1, ingredient2, ingredient3 }; 
        
        return new HotDog(hotdogIngredients);
    }
}