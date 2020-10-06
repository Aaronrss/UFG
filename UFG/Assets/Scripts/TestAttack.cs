using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestAttack : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter2D(Collider2D Col)
    {
        // < > template
        PlayerHealth ph = Col.gameObject.GetComponent <PlayerHealth>();
        if(ph != null)
        {
            ph.TakeDamage(20);

        }
    }
}
