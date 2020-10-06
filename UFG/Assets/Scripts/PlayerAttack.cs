using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttack : MonoBehaviour
{
    public Animator animator;
    public float[] AttackStrength;
    public float[] AttackDelay;
    float NextAttack = 0;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if(Input.GetKeyDown(KeyCode.Space) && Time.time > NextAttack)
        {
            animator.SetTrigger("IsAttacking");

            NextAttack = Time.time+AttackDelay[0];
        }

        
    }
}
