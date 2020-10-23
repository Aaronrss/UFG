using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttack : MonoBehaviour
{
    public Animator animator;
    public float[] AttackDelay;
    float NextAttack = 0;
    public Transform attackPoint;
    public LayerMask enemyLayers;
    public float attackRange =0.05f;
    public float[] AttackStrength;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void checkHit(){
        Collider2D[] hitEnemies = Physics2D.OverlapCircleAll(attackPoint.position, attackRange, enemyLayers);
        foreach(Collider2D enemy in hitEnemies)
        {
            Debug.Log("We hit " + enemy.name);
            PlayerHealth ph = enemy.gameObject.GetComponent <PlayerHealth>();
            if(ph != null)
            {
                ph.TakeDamage(20); 
            }
        }
    }
   void OnDrawGizmosSelected() {
   if (attackPoint == null)
   return;
   Gizmos.DrawWireSphere(attackPoint.position, attackRange);
   }
    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space) && Time.time > NextAttack)
        {
            // Play an attack animation
            animator.SetTrigger("IsAttacking");

            NextAttack = Time.time+AttackDelay[0];
        }   
    }
}
