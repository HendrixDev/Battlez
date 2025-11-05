using Battles.Objects;

//create new player object called playerOne
Player playerOne = new Player();

//assign Ash to playerOne's Name property
playerOne.Name = "Ash";

//initialize new list of monsters to playerOne's Monsters property
playerOne.Monsters = new List<Monster>();

//create new monster object called monsterOne
Monster monsterOne = new Monster();

//assign values to monsterOne's properties
monsterOne.Name = "Pikachu";
monsterOne.Health = 100;
monsterOne.Type = Element.Lightning;

playerOne.Monsters.Add(monsterOne);

//TODO: create a second monster and add it to playerOne's Monsters list (be sure to assign values to all properties)




//TODO: create new player object called playerTwo and assign values to its properties (be sure to add at least one monster to playerTwo's Monsters list)


