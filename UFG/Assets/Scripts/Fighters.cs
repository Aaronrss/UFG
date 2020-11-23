using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(fileName = "Fighters", menuName = "Fighter")]
public class Fighters : ScriptableObject
{
    public string Name;

    public float Strenght;

    public float Speed;

    public float Health;

    public float Reach;

    public GameObject fighters1; 
}
