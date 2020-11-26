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


    // Start is called before the first frame update
    void Start()
    {
        currentStamina = 0;
        staminaBar.SetMaxHealth(maxStamina);
    }

    // METODO PARA REGISTAR ATAQUE
    public void IncreaseStamina(int value)
    {
        // OPERACION PARA ALMACENAR VIDA Y REDUCIR DEPENDIENDO EL DAÑO
        currentStamina += value;

        // NOS PERMITE REVISAR VISUALMENTE EL ESTATUS DE VIDA
        staminaBar.SetHealth(currentStamina);

        //CONDICION QUE DETECTA SI SE MUERE
        if (currentStamina >= 100)
        {
            power = true;
        }
    }
    public void Update()
    {
        if (Time.time > nextUpdate)
        {
            IncreaseStamina(1);
            nextUpdate = Time.time + staminaDelay;
        }
    }

    public void Reset()
    {
        // se borra el stamina si se usa el poder
        power = false;
    }

}
