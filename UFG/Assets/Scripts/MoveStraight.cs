/*
    Movment script for the bullet
    Gilberto Echeverria 
*/


using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveStraight : MonoBehaviour
{

    public float speed;

    // Update is called once per frame
    void Update()
    {
        transform.position += transform.right * speed * Time.deltaTime;
        
    }
}
