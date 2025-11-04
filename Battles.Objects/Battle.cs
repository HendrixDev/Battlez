namespace Battles.Objects
{
    public class Battle
    {
        public Player PlayerOne { get; set; }
        public Player PlayerTwo { get; set; }
        public List<string> BattleLog { get; set; }

        public Battle(Player playerOne, Player player2)
        {
            PlayerOne = playerOne;
            PlayerTwo = player2;
            BattleLog = new List<string>();
        }

        //TODO: Add winner and loser
    }
}
