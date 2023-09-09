using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    private int collisionCount = 0;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Player")
        {
            collisionCount++; 

            if (collisionCount >= 3) 
            {
                EndGame(); 
            }
        }
    }

    private void EndGame()
    {
        Debug.Log("Game Over");
        
        Application.Quit();
    }
}