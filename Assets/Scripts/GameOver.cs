using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOver : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Lava"))
        {
            Debug.Log("Game Over");
        }
        else if (collision.gameObject.CompareTag("Enemy"))
        {
            Debug.Log("Game Over");
        }
    }                  
}
