using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBarScript : MonoBehaviour
{
    Image healthBar;
    public int startingHealth;
    public int currentHealth;
    public static float health;

    void Start()
    {
        healthBar = GetComponent<Image>();
        health = startingHealth;
    }

    
    void Update()
    {
        healthBar.fillAmount = health / startingHealth;
    }

    
}
