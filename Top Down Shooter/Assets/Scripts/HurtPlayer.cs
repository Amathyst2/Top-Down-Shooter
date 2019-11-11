using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HurtPlayer : MonoBehaviour
{
    public int damageToGive;

    void OnTriggerEnter2D(Collider2D col)
    {
        
        if (col.gameObject.tag == "Player")
        {
            col.gameObject.GetComponent<PlayerHealthManager>().HurtPlayer(damageToGive);
        }

        

    }
}
