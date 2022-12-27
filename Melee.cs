public class MeleeFighter : Enemy
{
    public MeleeFighter(string name) : base(name)
    {
        Health = 120;
        AttacksList = new List<Attack>();

        this.AddAttack("Punch", 20);
        this.AddAttack("Kick", 15);
        this.AddAttack("Tackle", 25);
    }

    public void Rage()
    {
        Random rand = new Random();
        int ItsRandom = rand.Next(0,this.AttacksList.Count);
        int BringThePain = 0;
        BringThePain = this.AttacksList[ItsRandom].Damage + 10;
        Console.WriteLine($"Melee Fighter {this.Name} is hulking up! and attacks with " + this.AttacksList[ItsRandom].Name + " for " + BringThePain + " damage!");
    }

    public override void RandomAttack()
    {
        Random rand = new Random();
        int ItsRandom = rand.Next(0,this.AttacksList.Count);
        Console.WriteLine($"Melee Fighter {this.Name} attacks with " + this.AttacksList[ItsRandom].Name + " for " + this.AttacksList[ItsRandom].Damage + " damage!");
    }
}