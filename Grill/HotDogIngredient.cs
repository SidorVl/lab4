namespace Program;

public abstract class HotDogIngredient
{
    private string _name;
    public string Name
    {
        get { return _name; }
    }

    private int _price;
    public int Price
    {
        get { return _price; }
    }

    public HotDogIngredient(string name, int price)
    {
        _name = name;
        _price = price;
    }
}