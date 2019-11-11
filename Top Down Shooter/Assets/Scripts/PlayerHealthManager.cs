using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealthManager : MonoBehaviour
{
   
    public int startingHealth;
    public int currentHealth;
    public GameObject Player;
   
    void Start()
    {
        currentHealth = startingHealth;
    }

    void Update()
    {
        if (currentHealth <= 0)
        {
            GameObject.FindGameObjectWithTag("Player").SetActive(false);
        }

    }
    public void HurtPlayer(int damageAmount)
    {
        currentHealth -= damageAmount;
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        HealthBarScript.health -= 1f;
    }
}
