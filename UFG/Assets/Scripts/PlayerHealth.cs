﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public Animator animator;

    public int maxHealth = 100;
    public int currentHealth;

    public HealthBar  healthBar;


    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth;  
        healthBar.SetMaxHealth(maxHealth); 
    }

    // Update is called once per frame
    void Update()
    {
        /*
        if(Input.GetKeyDown(KeyCode.Space))
        {
            TakeDamage(20);
        }
        */
        
    }

    public  void TakeDamage(int damage)
    {
        currentHealth -= damage;
        animator.SetTrigger("Hurt");

        healthBar.SetHealth(currentHealth);

        if(currentHealth <= 0)
        {
            Die();
        }
        void Die()
        {
            Debug.Log("We died!");

            // Die animation
            animator.SetBool("IsDead", true);

            // Disable the enemy
            GetComponent<Collider2D>().enabled = false;
            this.enabled = false;
        }
    }
}
