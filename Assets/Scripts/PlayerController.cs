using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;  
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;

public class PlayerController : MonoBehaviour
{
    private int speed = 20;
    private float horizontal;
    private float vertical;
    public int force = 10;
    public Rigidbody rb;
    private bool onIsland;
    // Update is called once per frame
    void Update()
    {
        horizontal = Input.GetAxis("Horizontal");
        vertical = Input.GetAxis("Vertical");

        transform.Translate(Vector3.forward * Time.deltaTime * speed * vertical);
        transform.Rotate(Vector3.up * Time.deltaTime * speed * horizontal);

        if (Input.GetKeyDown(KeyCode.Space) && onIsland == true)
        {
            rb.AddForce(Vector3.up * force, ForceMode.Impulse);
            onIsland = false;
        }

    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Island"))
        {
            onIsland = true;
        }
    }
}
