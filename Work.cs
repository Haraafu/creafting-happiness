using System;

public class Work : IActivity
{
    public void Execute()
    {
        Character character = Character.GetInstance();
        int income = character.JobLevel switch
        {
            JobLevel.TukangKayu => 10,
            JobLevel.Ojek => 15,
            JobLevel.Investor => 25,
            _ => 0
        };

        int staminaCost = 10;
        if (character.Stamina >= staminaCost)
        {
            character.Stamina -= staminaCost;
            character.Wish += income;
            Console.WriteLine($"Pak Yon works and earns {income} wish. Current wish: {character.Wish}. Stamina remaining: {character.Stamina}");
        }
        else
        {
            Console.WriteLine("Pak Yon doesn't have enough stamina to work.");
        }
    }
}
