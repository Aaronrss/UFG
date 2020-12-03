/*
    SCRIPT THAT DEFINES HOW THE STAMINA BAR INTERACTS

*/


using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StaminaBar : MonoBehaviour
{
    // VARIABLES
    public int maxStamina = 100;
    public int currentStamina;
    public HealthBar staminaBar;
    public bool power = false;
    public float staminaDelay = 0.1f;
    public float nextUpdate;
    public Color32 staminaColor;
    public Color32 powered;

    public string playerId;
    public PlayerHealth ownPlayerHealth;



    // Start is called before the first frame update
    void Start()
    {
        currentStamina = 0;
        staminaBar.SetMaxHealth(maxStamina);
        ownPlayerHealth = gameObject.GetComponent <PlayerHealth>();
    }

    // METHOD TO INCREASE STAMINA
    public void IncreaseStamina(int value)
    {
        // OPERATION TO INCREASE AND SAVE THE STAMINA
        currentStamina += value;

        // HELP TO VISULIZE THE STAMINA
        staminaBar.SetHealth(currentStamina);

        // CONDITION THAT DETECTS AND ACTIVATE THE SUPER POWER
        if (currentStamina >= 100)
        {
            staminaBar.SetColor(powered);
            power = true;
        }
    }
    public void Update()
    {
        // CONDITION THAT DETECTS IF PLAYER IS ALIVE TO CONTIUE INCREASING STAMINA
        if(ownPlayerHealth.alive)
        {
            if (Time.time > nextUpdate)
            {
                IncreaseStamina(1);
                nextUpdate = Time.time + staminaDelay;
            }
        }
    }
    // METHOD TO RESET THE STAMINA BAR
    public void Reset()
    {
        // DELETES THE STAMINA IF IS UDES
        staminaBar.SetColor(staminaColor);
        power = false;
        Start();
    }

}
