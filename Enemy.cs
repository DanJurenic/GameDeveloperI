public class Enemy
{
    public string Name;
    protected int Health;
    public int _Health
    {
        get { return Health; }
        set { Health = value; }
    }
    public List<Attack> AttacksList;

    public Enemy(string name)
    {
        Name = name;
        Health  = 100;
        AttacksList = new List<Attack>();
    }

    public virtual void RandomAttack()
    {
        Random rand = new Random();
        // return this.AttacksList[rand.Next(0,AttacksList.Count-1)];
        Console.WriteLine($"{this.Name} attacks with " + this.AttacksList[rand.Next(0,AttacksList.Count)].Name + "!");
    }

    public void AddAttack(string name, int damage)
    {
        Attack NewAttack = new Attack(name, damage);
        this.AttacksList.Add(NewAttack);
    }
}