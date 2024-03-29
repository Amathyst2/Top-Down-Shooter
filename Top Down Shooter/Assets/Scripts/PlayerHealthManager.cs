﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

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
            SceneManager.LoadScene(2);
            GameObject.FindGameObjectWithTag("Player").SetActive(false);
            
        }

    }
    public void HurtPlayer(int damageAmount)
    {
        currentHealth -= damageAmount;
        HealthBarScript.health -= 1f;
    }
    


}
