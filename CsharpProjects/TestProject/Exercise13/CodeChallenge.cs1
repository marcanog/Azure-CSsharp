int HealthHero = 10;
int HealthMonster = 10;
int randomAttack = 0;
Random random = new Random(9);
Console.WriteLine("Welcome to the Health Hero Game!");
Console.WriteLine("You are a hero with 10 health points.");
while (HealthHero > 0 && HealthMonster > 0)
{
    Console.WriteLine("The Hero attacks the Monster!");
    randomAttack = random.Next(1, 9);
    HealthMonster -= randomAttack;
    Console.WriteLine("Monster health: " + HealthMonster);
    if (HealthMonster <= 0)
    {
        Console.WriteLine("The Monster has been defeated!");
        Console.WriteLine("Hero Wins!");
        break;
    }

    Console.WriteLine("The Monster attacks the Hero!");
    randomAttack = random.Next(1, 9);
    HealthHero -= randomAttack;
    Console.WriteLine("Hero health: " + HealthHero);

    if (HealthHero <= 0)
    {
        Console.WriteLine("The Hero has been defeated!");
        Console.WriteLine("Monster Wins!");
        break;
    }
}
/*
int hero = 10;
int monster = 10;

Random dice = new Random();

do
{
    int roll = dice.Next(1, 11);
    monster -= roll;
    Console.WriteLine($"Monster was damaged and lost {roll} health and now has {monster} health.");

    if (monster <= 0) continue;

    roll = dice.Next(1, 11);
    hero -= roll;
    Console.WriteLine($"Hero was damaged and lost {roll} health and now has {hero} health.");

} while (hero > 0 && monster > 0);

Console.WriteLine(hero > monster ? "Hero wins!" : "Monster wins!");
*/