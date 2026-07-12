using UnityEngine;

public class PlayerHealth
{
    private int health;
    private int maxHealth;
    public PlayerHealth(int MaxHealth)
    {
        health = MaxHealth;
        maxHealth = MaxHealth;
    }
    public int TakeHit(int damage)
    {
        health -= damage;
        if (health < 0)
        {
            health = 0;
        }
        return health;
        
    }
    public bool IsDead()
    {
        if (health < 1)
        {
            return true;
        }
        return false;
    }
    public void ResetHealth()
    {
        health = maxHealth;
    }
    public int Heal(int healIncrease)
    {
        health += healIncrease;
        if (health > maxHealth)
        {
            return maxHealth;
        }
        return health;
    }

}
