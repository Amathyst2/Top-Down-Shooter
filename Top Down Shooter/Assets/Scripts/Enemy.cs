﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float speed;
    private Transform playerPos;
    private Player player;

    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<Player>();
        playerPos = GameObject.FindGameObjectWithTag("Player").transform;
    }

    void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, playerPos.position, speed * Time.deltaTime);
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.CompareTag("Player"))
            //player losing health
        {
            player.health--;
            Debug.Log(player.health);
            Destroy(gameObject);
           
        }

        if (other.CompareTag("Projectile"))
            
        {
            Destroy(other.gameObject);
            Destroy(gameObject);
        }
    
        
    }

}









  
