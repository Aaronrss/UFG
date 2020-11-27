﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CharacterInstances : MonoBehaviour
{
    public GameObject[] prefabs;
    public Transform p1pos;
    public Transform p2pos;
    public HealthBar p1health;
    public HealthBar p1stamina;
    public HealthBar p2health;
    public HealthBar p2stamina;
    public LayerMask p1enemy;
    public LayerMask p2enemy;
    // Start is called before the first frame update
    void Start()
    {
        int char1 = PlayerPrefs.GetInt("Character1");
        int char2 = PlayerPrefs.GetInt("Character2");
        GameObject p1 = Instantiate(prefabs[char1 - 1], p1pos.position, Quaternion.identity);
        GameObject p2 = Instantiate(prefabs[char2 - 1], p2pos.position, Quaternion.identity);

        // set playerID
        p1.GetComponent<PlayerMovement>().playerId = "P1";
        p2.GetComponent<PlayerMovement>().playerId = "P2";

        // set oponent layer
        p1.GetComponent<PlayerAttack>().enemyLayers = p1enemy;
        p2.GetComponent<PlayerAttack>().enemyLayers = p2enemy;

        // set oponent
        p1.GetComponent<CharacterController2D>().oponent = p2.transform;
        p2.GetComponent<CharacterController2D>().oponent = p1.transform;

        // set player health
        p1.GetComponent<PlayerHealth>().healthBar = p1health;
        p2.GetComponent<PlayerHealth>().healthBar = p2health;

        // set stamina bar
        p1.GetComponent<StaminaBar>().staminaBar = p1stamina;
        p2.GetComponent<StaminaBar>().staminaBar = p2stamina;

        // set gravity
        if (PlayerPrefs.GetInt("Stage") == 2)
        {
            // cambiar gravedad
            p1.GetComponent<RigidBody2D>().GravityScale = 4;
        }
    }
}
