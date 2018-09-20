using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class Player : MonoBehaviour {

    public float movementSpeed = 10f;
    public float upwardSpeed = 0.1f;

    float movement = 0f;
    Rigidbody2D rb;

    // Use this for initialization
    void Start () {
        rb = GetComponent<Rigidbody2D>();
	}

    // Update is called once per frame
    // Increase horizontal movement speed
    void Update()
    {
        movement = Input.GetAxis("Horizontal") * movementSpeed;
    }

    void FixedUpdate () {
        Vector2 velocity = rb.velocity;
        velocity.x = movement;
        rb.velocity = velocity;

        //transform.position = new Vector3(transform.position.x, transform.position.y + upwardSpeed * Time.fixedDeltaTime);
    }



}
