using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExitMenu : MonoBehaviour
{
    public static ExitMenu Instance;
    public GameObject exitButton; // Assign the button in the Inspector

    private void Awake()
    {
        // Ensure only one instance exists across scenes
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
            return;
        }
    }

    private void Start()
    {
        // Make sure the exit button is initially hidden
        if (exitButton != null)
        {
            exitButton.SetActive(false);
        }
    }

    private void Update()
    {
        // Press "Esc" to toggle the exit button
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            ToggleExitButton();
        }
    }

    void ToggleExitButton()
    {
        if (exitButton != null)
        {
            exitButton.SetActive(!exitButton.activeSelf);
        }
    }

    public void ExitGame()
    {
        Debug.Log("Exiting game...");
        Application.Quit();
    }
}
