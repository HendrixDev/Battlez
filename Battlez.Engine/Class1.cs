using Battles.Objects;

namespace Battlez.Engine
{
    public class Engine
    {
        public Battle InitializeBattle(Player playerOne, Player playerTwo)
        {
            Console.WriteLine("Initializing battle between " + playerOne.Name + " and " + playerTwo.Name);

            return new Battle(playerOne, playerTwo);
        }

        public void Attack(Monster attackingMonster, Monster defendingMonster)
        {
            int damageTotal = attackingMonster.Attack - defendingMonster.Defense;

            if (attackingMonster.HasTypeAdvantage(defendingMonster))//fix this
            {
                damageTotal = (int)(damageTotal * 1.5);
            }

            defendingMonster.Health -= damageTotal;
        }
    }
}
