using UnityEngine;
using TMPro;

public class ControlGuide : MonoBehaviour
{
    public TextMeshProUGUI popupText; // Reference to the TextMeshProUGUI component on the UI
    public FirstPersonController movementScript; // Reference to the movement script
    public GameObject popupPanel; // Reference to the GameObject containing the panel

    private bool showControlsPopup = true;

    private void Start()
    {
        if (popupText != null)
        {
            popupText.text = "Welcome to the Resolute Redemption!\n\n\nControls:\n" +
                "- Use 'W', 'A', 'S', 'D' to move.\n\n" +
                "- Hold 'Left Shift' to run.\n\n" +
                "- Press 'Space' to jump.\n\n" +
                "- Press 'Left Ctrl' to crouch.\n\n" +
                "- Move the mouse to look around.\n\n\n" +
                "- Have fun exploring.\n\n\n\n\n" +
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
            if (popupPanel != null)
            {
                popupPanel.SetActive(false); // Deactivate the panel
            }

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
