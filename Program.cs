// Game Dev One
Console.WriteLine(" ");
Console.WriteLine("Game Dev One:");
Enemy EnemyOne = new Enemy("Tyler");

Attack AttackOne = new Attack("Fireball", 20);
Attack AttackTwo = new Attack("Roundhouse kick", 10);
Attack AttackThree = new Attack("Sweep the leg", 50);

EnemyOne.AttacksList.Add(AttackOne);
EnemyOne.AttacksList.Add(AttackTwo);
EnemyOne.AttacksList.Add(AttackThree);
EnemyOne.AddAttack("Powerbomb", 75);

Console.WriteLine(" ");
Console.WriteLine("Let's Perform the RandomAttack() method 20 times: ");
Console.WriteLine(" ");

EnemyOne.RandomAttack();
EnemyOne.RandomAttack();
EnemyOne.RandomAttack();
EnemyOne.RandomAttack();
EnemyOne.RandomAttack();
EnemyOne.RandomAttack();
EnemyOne.RandomAttack();
EnemyOne.RandomAttack();
EnemyOne.RandomAttack();
EnemyOne.RandomAttack();
EnemyOne.RandomAttack();
EnemyOne.RandomAttack();
EnemyOne.RandomAttack();
EnemyOne.RandomAttack();
EnemyOne.RandomAttack();
EnemyOne.RandomAttack();
EnemyOne.RandomAttack();
EnemyOne.RandomAttack();
EnemyOne.RandomAttack();
EnemyOne.RandomAttack();

Console.WriteLine(" ");
Console.WriteLine("Did we see Fireball, Roundhouse kick, and Sweep the leg?");
Console.WriteLine("How about the attack we added with our AddAttack() method, Powerbomb?");
Console.WriteLine(" ");

// Game Dev Two
Console.WriteLine("Game Dev Two:");
Console.WriteLine(" ");

// 1) Create instances of the Melee, Ranged, and Magic Caster classes
MeleeFighter Brandon = new MeleeFighter("Brandon");
RangedFighter Matt = new RangedFighter("Matt");
MagicCaster Judah = new MagicCaster("Judah");

// 2) Perform a Random Attack from your Melee class character
Brandon.RandomAttack();

// 3) Perform the Rage method from your Melee class character
Brandon.Rage();

// 4) Perform a Random Attack from your Ranged class character
//     (if you wrote everything as listed above,
//     you should not have been able to attack due to the Distance constraint)
Matt.RandomAttack();

// 5) Perform the Dash method from your Ranged class character
Matt.Dash();

// 6) Perform another Random Attack from your Ranged class character
//    (this one should have worked now if everything is set up properly)
Matt.RandomAttack();

// 7) Perform a Random Attack from your Magic Caster class
Judah.RandomAttack();

// 8) Perform the Heal method on the Ranged instance
Judah.Heal(Matt);

// 9) Perform the Heal method on yourself (the magic caster)
Judah.Heal(Judah);