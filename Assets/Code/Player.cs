using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class Player : MonoBehaviour
{
	public GameManager GameManager;

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

	private void OnTriggerEnter2D(Collider2D collision)
	{
		switch(collision.gameObject.tag)
		{
			case Helper.Tag.DEAD_TAG:

				GameManager.GameOver();
				return;

			case Helper.Tag.POINT_TAG:

                GameManager.AddPoint();
                GameManager.UpdateScore();
                
				return;

			default:
				return;
		}
	}
}
