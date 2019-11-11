using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealthManager : MonoBehaviour
{
   
    public int startingHealth;
    public int currentHealth;
   
    void Start()
    {
        currentHealth = startingHealth;
    }

    void Update()
    {
        if (currentHealth <= 0)
        {
            gameObject.SetActive(false);
        }

    }
    public void HurtPlayer(int damageAmount)
    {
        currentHealth -= damageAmount;
    }
}
