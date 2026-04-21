using System;

class Hero
{
    public int Health;
    public int Damage;

    public Hero(int health, int damage)
    {
        Health = health;
        Damage = damage;
    }

    public void Attack(Monster monster)
    {
        monster.Health -= Damage;
        Console.WriteLine($"Герой нанес {Damage} урона! У монстра {monster.Health} здоровья");
    }
}

class Monster
{
    public int Health;
    public int Damage;

    public Monster(int health, int damage)
    {
        Health = health;
        Damage = damage;
    }

    public void Attack(Hero hero)
    {
        hero.Health -= Damage;
        Console.WriteLine($"Монстр нанес {Damage} урона! У героя {hero.Health} здоровья");
    }
}

class Program
{
    static void Main()
    {
        // Создаем героя и монстра
        Hero hero = new Hero(100, 25);
        Monster monster = new Monster(80, 20);

        // Битва
        while (hero.Health > 0 && monster.Health > 0)
        {
            hero.Attack(monster);

            if (monster.Health > 0)
            {
                monster.Attack(hero);
            }
        }

        // Кто победил?
        if (hero.Health > 0)
        {
            Console.WriteLine("\nГерой победил!");
        }
        else
        {
            Console.WriteLine("\nМонстр победил!");
        }
    }
}