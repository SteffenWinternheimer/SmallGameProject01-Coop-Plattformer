using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    public GameObject greenPlayer;
    public GameObject redPlayer;

    PlayerMovement greenPlayerMovement;
    PlayerMovement redPlayerMovement;

    public GameObject greenDestinationPlattformObject;
    public GameObject redDestinationPlattformObject;

    DestinationPlattform greenDestinationPlattform;
    DestinationPlattform redDestinationPlattform;

    private void Start()
    {
        greenPlayerMovement = greenPlayer.GetComponent<PlayerMovement>();
        redPlayerMovement = redPlayer.GetComponent<PlayerMovement>();

        redPlayerMovement.enabled = false;

        greenDestinationPlattform = greenDestinationPlattformObject.GetComponent<DestinationPlattform>();
        redDestinationPlattform = redDestinationPlattformObject.GetComponent<DestinationPlattform>();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.R)){
            greenPlayerMovement.enabled = !greenPlayerMovement.enabled;
            redPlayerMovement.enabled = !redPlayerMovement.enabled;
        }

        if(greenDestinationPlattform.isPlayerOnPlattform && redDestinationPlattform.isPlayerOnPlattform)
        {
            Debug.Log("LevelWon");
        }
    }



}
