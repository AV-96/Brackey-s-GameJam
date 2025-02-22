using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class NextSceneChanger : MonoBehaviour
{
   public string nextSceneName; // Name of the next scene (leave empty to load next in Build Settings)
    public float delay = 2f;     // Delay before changing scenes

    private void Start()
    {
        // Start the coroutine to change scene after delay
        StartCoroutine(ChangeSceneAfterDelay());
    }

    private IEnumerator ChangeSceneAfterDelay()
    {
        // Wait for the specified delay
        yield return new WaitForSeconds(delay);

        // Check if a scene name is specified in the Inspector
        if (!string.IsNullOrEmpty(nextSceneName))
        {
            // Load the specified scene by name
            SceneManager.LoadScene(nextSceneName);
        }
        else
        {
            // If no name is given, load the next scene in Build Settings order

            // Get the current scene index
            int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;

            // Calculate the next scene index
            int nextSceneIndex = currentSceneIndex + 1;

            // Check if the next scene index is within the total scene count
            if (nextSceneIndex < SceneManager.sceneCountInBuildSettings)
            {
                // Load the next scene by index
                SceneManager.LoadScene(nextSceneIndex);
            }
            else
            {
                Debug.LogWarning("No more scenes in Build Settings!");
            }
        }
    }
}
