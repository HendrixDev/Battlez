namespace Battles.Objects
{
    public class Battle
    {
        public Player PlayerOne { get; set; }
        public Player PlayerTwo { get; set; }
        public List<string> BattleLog { get; set; }

        //TODO: Add winner and loser
    }
}
