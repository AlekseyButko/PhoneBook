using System.Threading;

namespace Players
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var warrior = new Warrior() { Name = "Udwink", Weapon = "Sword", Damage = 100 };
            var witcher = new Witcher() { Name = "Gherolt", Weapon = "Sword", Damage = 150 };

            var warriorController = new PController<Warrior>(warrior);
            var witcherController = new PController<Witcher>(witcher);

            warriorController.ForceToAttack();
            witcherController.ForceToAttack();
        }
    }
}