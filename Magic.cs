public class MagicCaster : Enemy
{
    public MagicCaster(string name) : base(name)
    {
        Health = 80;
        AttacksList = new List<Attack>();

        this.AddAttack("Fireball", 25);
        this.AddAttack("Shield", 0);
        this.AddAttack("Staff Strike", 15);
    }

    public void Heal(Enemy name)
    {
        name._Health += 40;
        Console.WriteLine($"{this.Name} has cast Heal! {name.Name}'s Health is now {name._Health}!");
    }

    public override void RandomAttack()
    {
        Random rand = new Random();
        int ItsRandom = rand.Next(0,this.AttacksList.Count);
        Console.WriteLine($"Magic Caster {this.Name} attacks with " + this.AttacksList[ItsRandom].Name + " for " + this.AttacksList[ItsRandom].Damage + " damage!");
    }
}