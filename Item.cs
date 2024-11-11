public abstract class Item
{
    public int Cost { get; protected set; }
    public int HappinessBoost { get; protected set; }

    public abstract void ApplyEffect();
}

public class Food : Item
{
    public Food()
    {
        Cost = 10;
        HappinessBoost = 5;
    }

    public override void ApplyEffect()
    {
        Character.GetInstance().HappinessIndex += HappinessBoost;
        Console.WriteLine("Food item used! Happiness increased by " + HappinessBoost);
    }
}

public class EnergyDrink : Item
{
    public EnergyDrink()
    {
        Cost = 15;
        HappinessBoost = 0;
    }

    public override void ApplyEffect()
    {
        Character.GetInstance().Stamina += 10;
        Console.WriteLine("Energy Drink item used! Stamina increased by 10.");
    }
}

public class LevelUpItem : Item
{
    public LevelUpItem()
    {
        Cost = 25;
        HappinessBoost = 0;
    }

    public override void ApplyEffect()
    {
        Character character = Character.GetInstance();
        if (character.JobLevel == JobLevel.TukangKayu)
            character.JobLevel = JobLevel.Ojek;
        else if (character.JobLevel == JobLevel.Ojek)
            character.JobLevel = JobLevel.Investor;

        Console.WriteLine("Level-up item used! Job level upgraded to " + character.JobLevel);
    }
}
