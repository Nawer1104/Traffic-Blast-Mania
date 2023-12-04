using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarPolice : MonoBehaviour
{
    public float speed = 5f; // Adjust this to control the speed of movement

    private Rigidbody2D rb;

    void Start()
    {
        // Get the Rigidbody2D component attached to the GameObject
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        // Move the object up in the y-axis
        MoveUp();
    }

    void MoveUp()
    {
        // Calculate the new position based on the current position and speed
        Vector2 newPosition = rb.position + Vector2.up * speed * Time.deltaTime;

        // Move the Rigidbody2D object to the new position
        rb.MovePosition(newPosition);

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision != null && collision.gameObject.CompareTag("Goal"))
        {
            GameManager.Instance.CheckLevelUp();
        }
    }
}
