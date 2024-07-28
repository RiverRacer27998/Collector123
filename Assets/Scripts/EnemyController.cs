using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    private Transform player;
    private Vector3 direction;
    private float speed = 10f;
    private float attackRange = 15f;
    private float distanceToPlayer;



    // Start is called before the first frame update
    void Start()
    {
       player = GameObject.Find("Player").transform;
    }

    // Update is called once per frame
    void Update()
    {
        distanceToPlayer = Vector3.Distance(transform.position, player.position);

        if (distanceToPlayer <= attackRange)
        {
            direction = (player.position - transform.position).normalized;

            transform.Translate(direction * Time.deltaTime * speed);
        }
    }
}
