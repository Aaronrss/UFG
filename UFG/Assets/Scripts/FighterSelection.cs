using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FighterSelection : MonoBehaviour
{

    public Fighters[] fighters;
    public Transform Spot;

    private List<GameObject> fighters1; 

    // Start is called before the first frame update
    void Start()
    {
        fighters1 = new List<GameObject>();

        foreach (var fighter in fighters)
        {
            GameObject go = Instantiate(fighter.fighter, Quaternion.identity);  
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
