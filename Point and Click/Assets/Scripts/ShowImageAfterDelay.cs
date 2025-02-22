using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShowImageAfterDelay : MonoBehaviour
{
  public float delay = 2f; // Delay in seconds before the image appears
    private Image imageComponent;

    private void Start()
    {
        // Get the Image component
        imageComponent = GetComponent<Image>();

        // Check if the Image component exists
        if (imageComponent != null)
        {
            // Hide the Image component (not the GameObject)
            imageComponent.enabled = false;

            // Start the coroutine to show the image after a delay
            StartCoroutine(ShowImage());
        }
        else
        {
            Debug.LogWarning("No Image component found on this GameObject!");
        }
    }

    private System.Collections.IEnumerator ShowImage()
    {
        Debug.Log("Waiting for delay: " + delay + " seconds.");
        
        // Wait for the specified delay
        yield return new WaitForSeconds(delay);

        Debug.Log("Delay over. Showing the image.");

        // Make the UI Image visible by enabling the component
        imageComponent.enabled = true;
    }
}
