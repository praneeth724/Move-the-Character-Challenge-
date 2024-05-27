using UnityEngine;

public class StartScreen : MonoBehaviour
{
    public GameObject instructionsText;

    void Start()
    {
        // Show instructions when the game starts
        instructionsText.SetActive(true);
    }

    // Method to start the game
    public void StartGame()
    {
        // Start the game by hiding the instructions
        instructionsText.SetActive(false);
        // Add any other logic to start your game here

        // You can also send a message to start the game to other components or systems here
        FindObjectOfType<PlayerController>().StartGame();
    }
}
