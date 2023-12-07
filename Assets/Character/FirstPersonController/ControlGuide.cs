using UnityEngine;
using TMPro;

public class ControlGuide : MonoBehaviour
{
    public TextMeshProUGUI popupText; // Reference to the TextMeshProUGUI component on the UI
    public FirstPersonController movementScript; // Reference to the movement script

    private bool showControlsPopup = true;

    private void Start()
    {
        if (popupText != null)
        {
            popupText.text = "Welcome to the Advanced First Person Controller!\n\nControls:\n" +
                "- Use 'W', 'A', 'S', 'D' to move.\n" +
                "- Hold 'Left Shift' to run.\n" +
                "- Press 'Space' to jump.\n" +
                "- Press 'Left Ctrl' to crouch.\n" +
                "- Move the mouse to look around.\n" +
                "- Adjust camera sensitivity in the script.\n" +
                "- Have fun exploring.\n\n" +
                "Press 'Enter' to start playing."; // Display the initial message
        }
        else
        {
            Debug.LogError("Popup Text is not assigned in the inspector!");
        }

        if (movementScript != null)
        {
            movementScript.enabled = false; // Disable the movement script initially
        }
        else
        {
            Debug.LogError("Movement Script is not assigned in the inspector!");
        }
    }

    private void Update()
    {
        if (showControlsPopup && Input.GetKeyDown(KeyCode.Return))
        {
            if (popupText != null)
            {
                popupText.text = ""; // Clear the text to hide the messages
            }

            if (movementScript != null)
            {
                movementScript.enabled = true; // Enable the movement script
            }

            showControlsPopup = false;
        }
    }
}
