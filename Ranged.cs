public class RangedFighter : Enemy
{
    protected int Distance = 5;
    public RangedFighter(string name) : base(name)
    {
        AttacksList = new List<Attack>();

        this.AddAttack("Shoot an Arrow", 20);
        this.AddAttack("Throw a Knife", 15);
    }

        public void Dash()
    {
        this.Distance = 20;
    }

    public override void RandomAttack()
    {
        if (this.Distance < 10)
        {
            Console.WriteLine($"{this.Name} is a ranged fighter and is currently to close to attack effectively. Please use Dash, then try again.");
        }
        else
        {
            Random rand = new Random();
            int ItsRandom = rand.Next(0,this.AttacksList.Count);
            Console.WriteLine($"Ranged Fighter {this.Name} attacks with " + this.AttacksList[ItsRandom].Name + " for " + this.AttacksList[ItsRandom].Damage + " damage!");
        }
    }
}