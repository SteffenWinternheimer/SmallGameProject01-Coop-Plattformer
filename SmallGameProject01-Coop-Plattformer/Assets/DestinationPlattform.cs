using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestinationPlattform : MonoBehaviour
{
    public bool isPlayerOnPlattform;
    public GameObject preferedPlayer;


    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject == preferedPlayer)
        {
            isPlayerOnPlattform = true;
            Debug.Log("PreferedPlayerOnPlattform");
        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject == preferedPlayer)
        {
            isPlayerOnPlattform = false;
            Debug.Log("PreferedPlayer left plattform");
        }
    }

}
