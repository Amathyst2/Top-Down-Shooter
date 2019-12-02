using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class healthPickUp : MonoBehaviour
{
 
    public int healthAmount;



    void OnTriggerEnter2d(Collider2D other)
    {
        if (other.tag == "Player")
        {
           other.gameObject.GetComponent<PlayerHealthManager>().addHealth(healthAmount);
           Destroy(gameObject);
        }
    }
}
