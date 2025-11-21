namespace Battles.Objects
{
    public class Monster
    {
        public string Name { get; set; }
        public int Health { get; set; }
        public Element Type { get; set; }
        public int Attack { get; set; }
        public int Defense { get; set; }
        public Element Weakness { get; set; }//could maybe get rid of this?

        public bool HasTypeAdvantage(this Monster attacker, Monster defender)
        {
            if (this.Type == Element.Fire && defender == Element.Grass)
                return true;
            else if (this.Type == Element.Water && defender == Element.Fire)
                return true;
            else if (this.Type == Element.Grass && defender == Element.Water)
                return true;
            else if (this.Type == Element.Lightning && defender == Element.Water)
                return true;
            else if (this.Type == Element.Rock && defender == Element.Lightning)
                return true;
            else
                return false;
        }
    }
}
