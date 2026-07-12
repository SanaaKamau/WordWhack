using UnityEngine;

public class HealthBar
{
    private int health;
    const int DEFAULTHEALTH = 100;
    private int maxHealth;
    public HealthBar(int MaxHealth)
    {
        health = MaxHealth;
        maxHealth = MaxHealth;
    }
    public HealthBar()
    {
        health = DEFAULTHEALTH;
        maxHealth = DEFAULTHEALTH;
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
    public int GetCurrentHealth()
    {
        return health;
    }
    public int GetMaxHealth()
    {
        return maxHealth;
    }
    public void ResetSetMaxHealth( int mh)
    {
        maxHealth = mh;
        health = mh;
    }

}
