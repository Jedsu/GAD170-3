using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SimpleHealthBar : MonoBehaviour
{
    public Slider healthbar;
    PlayerHealth playerHealth;

    void Start()
    {
        playerHealth = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerHealth>();


        void Update ()
        {
            healthbar.value = playerHealth.health;
        }
    }
}
