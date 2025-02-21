using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanger : MonoBehaviour
{
   public string nextSceneName = "01Start Screen"; // Name of the next scene

    private void Start()
    {
        StartCoroutine(ChangeSceneAfterDelay(4f)); // Waits for 5 seconds
    }

    private IEnumerator ChangeSceneAfterDelay(float delay)
    {
        yield return new WaitForSeconds(delay);
        SceneManager.LoadScene(nextSceneName); // Loads Scene B
    }
}
