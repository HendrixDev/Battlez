// See https://aka.ms/new-console-template for more information
using Battles.Objects;

Console.WriteLine("Hello, World!");


Player playerOne = new Player
{
    Name = "Ash",
    Monsters = new List<Monster>
    {
        new Monster { Name = "Squirtle", Health = 100, Type = Element.Water },
        new Monster {Name = "Charmander", Health = 150, Type = Element.Fire}
    }
};

Player playerTwo = new Player
{
    Name = "Misty",
    Monsters = new List<Monster>
    {
        new Monster { Name = "Psyduck", Health = 120, Type = Element.Water },
        new Monster {Name = "Bulbasaur", Health = 130, Type = Element.Grass}
    }
};

Battle battle = new Battle(playerOne, playerTwo);

string currentAction = $"Battle started between {battle.PlayerOne.Name} and {battle.PlayerTwo.Name}!";

battle.BattleLog.Add(currentAction);
Console.WriteLine(currentAction);

Thread.Sleep(2000);
Console.WriteLine();