using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnScript : MonoBehaviour
{
    public GameObject enemy;
    public GameObject[] islands;
    void Start()
    {
        islands = GameObject.FindGameObjectsWithTag("Island");

        for (int i = 0; i < islands.Length; i++)
        {
            Vector3 position = islands[i].transform.position + new Vector3(Random.Range(0, 3), Random.Range(0, 3), Random.Range(0, 3));
            Instantiate(enemy, position, Quaternion.identity);
        }
    }

  
}
