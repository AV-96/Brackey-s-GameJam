using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections.Generic;

public class PreviousScene : MonoBehaviour
{
  private static Stack<string> sceneHistory = new Stack<string>();

    private void Start()
    {
        // Store the current scene name, but not if it's already the last one stored
        string currentScene = SceneManager.GetActiveScene().name;

        if (sceneHistory.Count == 0 || sceneHistory.Peek() != currentScene)
        {
            sceneHistory.Push(currentScene);
        }
    }

    private void Update()
    {
        // Check if "F" is pressed
        if (Input.GetKeyDown(KeyCode.F))
        {
            GoBack();
        }
    }

    public void GoBack()
    {
        // Check if there's a previous scene in history
        if (sceneHistory.Count > 1)
        {
            // Remove current scene
            sceneHistory.Pop();
            // Get the previous scene
            string previousScene = sceneHistory.Peek();
            SceneManager.LoadScene(previousScene);
        }
        else
        {
            Debug.LogWarning("No previous scene to go back to!");
        }
    }
}
