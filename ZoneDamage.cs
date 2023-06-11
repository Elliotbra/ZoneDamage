using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using StarterAssets;

public class ZoneDamage : MonoBehaviour
{
    public int damageAmount = 10; // Die Schadensmenge, die der Spieler erleidet
    public float TickRate = 1f; // Der Zeitintervall, in dem der Schaden angewendet wird

    private float timer = 0f;
    public bool isPlayerInZone = true;
    private ThirdPersonController playerController;

    void Update()
    {

    }


    // Diese Methode wird aufgerufen, wenn der Spieler die Zone betritt
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            isPlayerInZone = true;
        }
    }

    // Diese Methode wird aufgerufen, wenn der Spieler die Zone verlässt
    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            isPlayerInZone = false;
            playerController = other.GetComponent<ThirdPersonController>();
            playerController.playerHealth -= damageAmount;
        }
    }
}