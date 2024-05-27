using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed = 15f;
    private bool gameStarted = false;

    void Update()
    {
        // Check if the game has started
        if (!gameStarted)
            return;

        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(horizontalInput, 0f, verticalInput) * moveSpeed * Time.deltaTime;
        transform.Translate(movement);
    }

    // Method to start the game
    public void StartGame()
    {
        gameStarted = true;
    }
}
