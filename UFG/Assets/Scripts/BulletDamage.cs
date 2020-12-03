using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletDamage : MonoBehaviour
{
    public int damage;
    

    void OnTriggerEnter2D(Collider2D other)
    {
        other.gameObject.GetComponent<PlayerHealth>().TakeDamage(damage);

        Destroy(gameObject);
    }
}
