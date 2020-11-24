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
        currentHealth = maxHealth;
        healthBar.SetMaxHealth(maxHealth);
    }

    // METODO PARA REGISTAR ATAQUE
    public void TakeDamage(int damage)
    {
        // OPERACION PARA ALMACENAR VIDA Y REDUCIR DEPENDIENDO EL DAÑO
        currentHealth -= damage;
        //DETECTA SI RECIBE UN GOLPE PARA ACTIVAR ANIMACION HIT
        animator.SetTrigger("Hurt");

        // NOS PERMITE REVISAR VISUALMENTE EL ESTATUS DE VIDA
        healthBar.SetHealth(currentHealth);

        //CONDICION QUE DETECTA SI SE MUERE
        if (currentHealth <= 0)
        {
            //MANDA LLAMAR METODO MUERTE
            Die();
        }

        // METODO MUERTE
        void Die()
        {
            // Debug.Log("We died!");
            alive = false;
            // Die animation
            animator.SetBool("IsDead", true);

            // Disable the enemy
            GetComponent<Collider2D>().enabled = false;

            // this.enabled = false; (desactiva script)
            // LLAMA AL METODO FINISHFIGHT EN UNA CORUTINA
            StartCoroutine(FinishFight());
        }
    }
    //METODO FINISHFIGHT
    IEnumerator FinishFight()
    {
        //TIEMPO DE ESPERA 
        yield return new WaitForSeconds(5);
        // Go to credits
        SceneManager.LoadScene("Credits");
    }

}
