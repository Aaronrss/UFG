/*
    THIS SCRIPT MODIFY THE HEALTH OF PLAYERS
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerHealth : MonoBehaviour
{
    // VARIABLES
    public Animator animator;
    public int maxHealth = 100;
    public int currentHealth;
    public HealthBar healthBar;
    public bool alive = true;


    // Start is called before the first frame update
    void Start()
    {
        // INITIATE THE HEALTH
        currentHealth = maxHealth;
        healthBar.SetMaxHealth(maxHealth);
    }

    // METHOD FOR DAMAGE HEATLH 
    public void TakeDamage(int damage)
    {
        // OPERATION FOR SAVE THE DAMAGE INTO CURRENT HEALTH 
        currentHealth -= damage;
        // VISUALY MODIFY THE HEALTH 
        healthBar.SetHealth(currentHealth);

        // CONDITION THAT DETECTS IF PLAYER STEAL ALIVE OR GET HURT 
        if (currentHealth <= 0)
        {
            // CALL DIE METHOD
            Die();
        } else
        {
            // ACTIVATE ANIMATION OF HIT 
            animator.SetTrigger("Hurt");
        }

        // METHOD FOR DIE
        void Die()
        {
            // Debug.Log("We died!");
            // CHANGE THE STATE OF THE BOOLEAN ALIVE TO FALSE
            alive = false;
            // ACTIVATE DIE ANIMATION 
            animator.SetBool("IsDead", true);

            // Disable the enemy
            //GetComponent<Collider2D>().enabled = false;

            // this.enabled = false; (desactiva script)

            // CALL METHOD FINISHFIGHT AS A COROUTINE
            StartCoroutine(FinishFight());
        }
    }
    // METHOD FINISHFIGHT
    IEnumerator FinishFight()
    {
        // DELAY TO CHANGE THE SCENE FIGHT TO CREDITS 
        yield return new WaitForSeconds(5);
        // CHANGE THE SCENE TO CREDITS
        SceneManager.LoadScene("Credits");
    }

}
