using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PowerManager : MonoBehaviour
{

    public int currentPower;
    public int minPower;

    public Text powerText;

    public bool isRespawning;
    private Vector2 respawnPoint;
    public Transform player;


    void Start()
    {
        currentPower = minPower;
        powerText.text = "Current Power: " + currentPower;

        respawnPoint = player.transform.position;

    }


    void Update()
    {
        powerText.text = "Current Power: " + currentPower;
    }

    public void HurtPlayer(int damage)
    {
        currentPower -= damage;

        if (currentPower < minPower)
        {
            currentPower = minPower;
        }
    }

    public void HealPlayer(int healAmount)
    {
        currentPower += healAmount;

        if (currentPower <= -1)
        {
            Respawn();
        }
    }

    public void Respawn()
    {
        player.transform.position = respawnPoint;
        currentPower = minPower;
    }
}







