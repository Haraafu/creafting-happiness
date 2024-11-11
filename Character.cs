public class Character
{
    private static Character _instance;
    public static Character GetInstance() => _instance ?? (_instance = new Character());

    public int Stamina { get; set; }
    public int Wish { get; set; }
    public int HappinessIndex { get; set; }
    public JobLevel JobLevel { get; set; }
    public Inventory Inventory { get; private set; }

    private Character()
    {
        Stamina = 100;
        Wish = 0;
        HappinessIndex = 0;
        JobLevel = JobLevel.TukangKayu;
        Inventory = new Inventory();
    }

    public void BuyItem(Item item)
    {
        if (Wish >= item.Cost)
        {
            Inventory.AddItem(item);
            Wish -= item.Cost;
        }
    }

    public void DisplayStatus()
    {
        Console.WriteLine($"Stamina: {Stamina}, Wish: {Wish}, Happiness: {HappinessIndex}, Job Level: {JobLevel}");
    }
}
