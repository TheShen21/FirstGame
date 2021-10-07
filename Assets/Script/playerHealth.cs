using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerHealth : MonoBehaviour
{
    public int maxHealth = 3;
    public int currentHealth;

    public HealthBarScript healthBar;

    void Start()
    {
        currentHealth = maxHealth;
        healthBar.SetMaxhealth(maxHealth);

    }
    public void takeDamage(int damage)
    {
        

        currentHealth -= damage;
        if (currentHealth <= 0)
        {
            FindObjectOfType<GameManage>().GameOver();
        }
        healthBar.SetHealth(currentHealth);
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
