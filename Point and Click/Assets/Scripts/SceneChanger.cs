using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanger : MonoBehaviour
{
    public string nextSceneName = "01Start Screen"; // Name of the next scene
    public bool resetTimer = false;
    public float Timetowait = 4f;

    private void Start()
    {
        StartCoroutine(ChangeSceneAfterDelay(Timetowait)); // Waits for 5 seconds
    }

    private IEnumerator ChangeSceneAfterDelay(float delay)
    {
        yield return new WaitForSeconds(delay);
        if (resetTimer)
        {
            CountdownTimer.Instance.ResetTimer();
        }
        
        SceneManager.LoadScene(nextSceneName); // Loads Scene B
    }
}
