namespace Battles.Objects
{
    public class Battle
    {
        public Player PlayerOne { get; set; }
        public Player PlayerTwo { get; set; }
        public List<string> BattleLog { get; set; }

        public Battle(Player player1, Player player2)
        {
            PlayerOne = player1;
            PlayerTwo = player2;
            BattleLog = [];
            BattleLog.Add($"Battle started between {PlayerOne.Name} and {PlayerTwo.Name}");
        }
        public string Winner { get; set; }
        public string Loser { get; set; }
    }
}
