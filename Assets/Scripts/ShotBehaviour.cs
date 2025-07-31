using UnityEngine;

public class ShotBehaviour : MonoBehaviour
{
    public float speed = 5f; // Adjust this value in the Inspector for desired speed
    private Rigidbody2D rb;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        Destroy(gameObject, 2f);
    }

    // Update is called once per frame
    void Update()
    {

    }
    void FixedUpdate() // Use FixedUpdate for physics-related operations
    {
        // Calculate the new velocity
        Vector2 movement = new Vector2(1 * speed, rb.linearVelocity.y);

        // Apply the new velocity to the Rigidbody2D
        rb.linearVelocity = movement;
    }
}
