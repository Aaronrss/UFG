using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttack : MonoBehaviour
{
    //VARIABLES
    public Animator animator;
    public float[] AttackDelay;
    float NextAttack = 0;
    public Transform attackPoint;
    public LayerMask enemyLayers;
    public float attackRange =0.05f;
    public float[] AttackStrength;
    public KeyCode AttackButton;
    public AudioSource audioHit;
    public PlayerHealth ownPlayerHealth;
    public StaminaBar ownPlayerStamina;
    public bool playerMoves = true;

    void Start() {
        audioHit = GetComponent<AudioSource>();
        ownPlayerHealth = gameObject.GetComponent <PlayerHealth>();
        ownPlayerStamina = gameObject.GetComponent <StaminaBar>();
    }

    // METODO PARA REGISTRAR SI HAY UN GOLPE
    public void checkHit(){
        Collider2D[] hitEnemies = Physics2D.OverlapCircleAll(attackPoint.position, attackRange, enemyLayers);
        foreach(Collider2D enemy in hitEnemies)
        {
            Debug.Log("We hit " + enemy.name);
            PlayerHealth ph = enemy.gameObject.GetComponent <PlayerHealth>();
            if(ph != null)
            {
                ph.TakeDamage(10);
                ownPlayerStamina.IncreaseStamina(20);
                if (!ph.alive)
                {
                    playerMoves = false;
                }
            }
        }
    }

    // METODO PARA VISUALIZAR GRAFICAMENTE LA DISTANCIA DEL RANGO DE ATAQUE
   void OnDrawGizmosSelected() {
   if (attackPoint == null)
   return;
   Gizmos.DrawWireSphere(attackPoint.position, attackRange);
   }
    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(AttackButton) && Time.time > NextAttack && ownPlayerHealth.alive)
        {
            // Play an attack animation
            animator.SetTrigger("IsAttacking");
            audioHit.Play();

            // FUNCION PARA RETRASAR ATAQUES CONTINUOS
            NextAttack = Time.time+AttackDelay[0];
        }   
    }
}
