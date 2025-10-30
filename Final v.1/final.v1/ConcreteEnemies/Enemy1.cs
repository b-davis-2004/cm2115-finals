namespace final.v1;

public class Enemy1 : IEnemy
{
    public string Name => "Enemy1";
    public int Health { get; set; } = 100;
    public int AttackPower => 20;

    public bool IsDefeated => Health <= 0;

    public void Attack(Player player)
    {
        Console.WriteLine($"{Name} does xyz for {AttackPower} damage!");
        player.Health -= AttackPower;
    }

    public void TakeDamage(int damage)
    {
        Health -= damage;
        Console.WriteLine($"{Name} does xyz, taking {damage} damage!");
    }
}
