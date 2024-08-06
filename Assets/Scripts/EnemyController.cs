using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    private Transform player;
    private Vector3 direction;
    private float speed = 5f;
    private float attackRange = 15f;
    private float distanceToPlayer;
    private Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("Player").transform;
        rb = GetComponent<Rigidbody>();

        // Убедитесь, что Rigidbody установлен в режим isKinematic
        if (rb == null)
        {
            rb = gameObject.AddComponent<Rigidbody>();
        }
        rb.isKinematic = true;
    }

    // Update is called once per frame
    void Update()
    {
        distanceToPlayer = Vector3.Distance(transform.position, player.position);

        if (distanceToPlayer <= attackRange)
        {
            direction = (player.position - transform.position).normalized;
        }
    }

    void FixedUpdate()
    {
        if (distanceToPlayer <= attackRange)
        {
            // Используем MovePosition для перемещения с учетом физики
            rb.MovePosition(transform.position + direction * Time.fixedDeltaTime * speed);
        }
    }
}

