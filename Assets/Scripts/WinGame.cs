using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinGame : MonoBehaviour
{
    public GameObject WinScreen;
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Teleport"))
        {
            Debug.Log("Game Over");
            WinScreen.SetActive(true);
        }
    }
}
