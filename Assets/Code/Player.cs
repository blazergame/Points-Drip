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
    private float screenCenterX;

    void Start () {
        rb = GetComponent<Rigidbody2D>();
        screenCenterX = Screen.width;
    }

    /*********
     * FIX:
     * There is something wrong with movement. It moves smoothly left/right but game object suddenly disappears from screen. 
     *********/

    void Update()
    {
        // movement = Input.GetAxis("Horizontal") * movementSpeed;

        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0); // get first touch since touch count is greater than zero

            if (touch.phase == TouchPhase.Stationary || touch.phase == TouchPhase.Moved)
            {
                // get the touch position from the screen touch to world point
                Vector3 touchedPos = Camera.main.ScreenToWorldPoint(new Vector3(touch.position.x * 1.0f, 0, 0));
                // lerp and set the position of the current object to that of the touch, but smoothly over time.
                transform.position = Vector3.Lerp(transform.position, touchedPos, Time.deltaTime);
                
            }
        }
    }

    private void moveCharacter(float horizontalInput)
    {
        rb.AddForce(new Vector2(horizontalInput * movementSpeed * Time.deltaTime, 0));
    }

    void FixedUpdate () {
        Vector2 velocity = rb.velocity;
        velocity.x = movement;
        rb.velocity = velocity;
    }

	private void OnTriggerEnter2D(Collider2D collision)
	{
		switch(collision.gameObject.tag)
		{
			case Helper.Tag.DEAD_TAG:

				GameManager.GameOver();
				return;

			case Helper.Tag.POINT_TAG:

                GameManager.DisappearOnTouch(collision.gameObject);
                GameManager.AddPoint();
                GameManager.UpdateScore();       
				return;

			default:
				return;
		}
	}
}
