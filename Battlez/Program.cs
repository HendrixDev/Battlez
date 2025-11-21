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

//add monsterOne to playerOne's Monsters list
playerOne.Monsters.Add(monsterOne);

//TODO: create a second monster and add it to playerOne's Monsters list (be sure to assign values to all properties)

Monster MonsterTwo = new Monster();
MonsterTwo.Name = "charmander";
MonsterTwo.Health = 80;
MonsterTwo.Type = Element.Fire;

playerOne.Monsters.Add(MonsterTwo);


//TODO: create new player object called playerTwo and assign values to its properties (be sure to add at least one monster to playerTwo's Monsters list)

Player PlayerTwo = new Player();

PlayerTwo.Name = "gary";
PlayerTwo.Monsters = new List<Monster>();
Monster MonsterOne = new Monster();
MonsterOne.Name = "squirtle";
MonsterOne.Health = 90;
MonsterOne.Type = Element.Water;

PlayerTwo.Monsters.Add(MonsterOne);


