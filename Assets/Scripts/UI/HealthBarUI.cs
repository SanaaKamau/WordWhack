
using UnityEngine;
using UnityEngine.UI;   

public class HealthBarUI: MonoBehaviour
{
    public Slider EnemyHealthBar;
    public Slider PlayerHealthBar;

    void Update()
    {
        PlayerHealthBar.maxValue = GameManager.Instance.playerHealth.GetMaxHealth();
        PlayerHealthBar.value = GameManager.Instance.playerHealth.GetCurrentHealth();
        EnemyHealthBar.maxValue = GameManager.Instance.playerHealth.GetMaxHealth();
        EnemyHealthBar.value = GameManager.Instance.playerHealth.GetCurrentHealth();



    }
}