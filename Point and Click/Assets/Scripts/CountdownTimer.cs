using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;
using TMPro;

public class CountdownTimer : MonoBehaviour
{
   public static CountdownTimer Instance;

    public float timeRemaining = 10f; // Starting time in seconds
    public TextMeshProUGUI timerText; // Use TextMeshProUGUI for UI Text
    public AudioSource endSound;

   
    private bool timerRunning = false;

    private void Awake()
    {
        // Singleton Pattern - Only one instance can exist
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject); // Persist across scenes
        }
        else if (Instance != this)
        {
            Destroy(gameObject); // Destroy duplicate instances
            return;
        }
    }

    private void Start()
    {
        timerText.text = "";
    
    }
    

    public void StartTimer(float timetowait)
    {
        timerRunning = true;
        timeRemaining = timetowait;
    }
    private void Update()
    {
        if (timerRunning && timeRemaining > 0)
        {
            timeRemaining -= Time.deltaTime; // Decrease time
            int seconds = Mathf.CeilToInt(timeRemaining); // Display only seconds

            timerText.text = seconds.ToString("00");
        }
        else if (timeRemaining <= 0 && timerRunning)
        {
            timeRemaining = 0;
            timerText.text = "";
            timerRunning = false;
            OnTimerEnd(); // Trigger event when time is up
        }
    }

    public void AddTime(float changeAmount)
    {
        timeRemaining = timeRemaining + changeAmount;
    }

    public void ResetTimer ()
    {
        timeRemaining = 0;
        timerText.text = "";
        timerRunning = false;
    }

    private void OnTimerEnd()
    {
        Debug.Log("Time's up!");

        // Play the end sound effect
        if (endSound != null)
        
        {
            endSound.Play();
        }
    
        SceneManager.LoadScene("01Start Screen");

        // Optional: Load a Game Over scene
        // SceneManager.LoadScene("GameOver");
    }

     private void OnSceneLoaded(Scene scene, LoadSceneMode mode)
    {
        // Check if the player has entered "Scene 11"
        if (scene.name == "11Dentist's office")
        {
            // Subtract 10 seconds from the timer
            Debug.Log("Entered Scene 11 - Subtracting 10 seconds");
            timeRemaining -= 10f;

            // Prevent negative time
            if (timeRemaining < 0)
            {
                timeRemaining = 0;
            }
        }
    }
}
