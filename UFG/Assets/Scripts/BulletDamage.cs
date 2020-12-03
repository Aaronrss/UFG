/*
    Gilberto Echeverria idea script

    This script inflicts damage and destroy the object
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletDamage : MonoBehaviour
{
    // variable that has the damage of the bullet
    public int damage;
    
    // Detects if the bullet hits a player and damage his health
    void OnTriggerEnter2D(Collider2D other)
    {
        other.gameObject.GetComponent<PlayerHealth>().TakeDamage(damage);

        // Destroy the bullet
        Destroy(gameObject);
    }
}
