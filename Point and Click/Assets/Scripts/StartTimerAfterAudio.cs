using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartTimerAfterAudio : MonoBehaviour
{

    public float delay = 2f; // Delay before starting the timer
    public float startTimer = 30f;
    private void Start()
    {
        // Start the coroutine to wait before starting the timer
        StartCoroutine(StartTimerAfterDelayCoroutine());
    }

    private IEnumerator StartTimerAfterDelayCoroutine()
    {
        // Wait for the specified delay
        yield return new WaitForSeconds(delay);

        // Start the timer (Adjust timeToWait as needed)
        CountdownTimer.Instance.StartTimer(startTimer); // Starts timer with 60 seconds
    }
}
