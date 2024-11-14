using UnityEngine;

public class PaddleMovement : MonoBehaviour
{
    public float speed = 10.0f;       // Speed of paddle movement
    public float boundaryY = 4.5f;    // Limits for paddle movement on the y-axis
    public KeyCode upKey;             // Key to move paddle up
    public KeyCode downKey;           // Key to move paddle down

    void Update()
    {
        float move = 0;

        // Check for input from assigned keys
        if (Input.GetKey(upKey))
        {
            move = speed * Time.deltaTime;
        }
        else if (Input.GetKey(downKey))
        {
            move = -speed * Time.deltaTime;
        }

        // Move the paddle up and down
        transform.Translate(0, move, 0);

        // Clamp the paddle's position to keep it within the screen boundaries
        float yPos = Mathf.Clamp(transform.position.y, -boundaryY, boundaryY);
        transform.position = new Vector3(transform.position.x, yPos, transform.position.z);
    }
}