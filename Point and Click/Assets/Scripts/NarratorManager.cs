using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class NarratorManager : MonoBehaviour
{
    public TextMeshProUGUI narrationText; // UI Text for narration
    [TextArea(3, 5)] public string narration; // Narration text
    public float textDisplayDuration = 5f; // Duration to show text

    public AudioSource audioSource; // Audio source for narration
    public AudioClip narrationAudio; // Voice-over clip

    void Start()
    {
        if (narrationText != null)
        {
            StartCoroutine(DisplayNarration());
        }
    }

    System.Collections.IEnumerator DisplayNarration()
    {
        narrationText.text = narration; // Show the text
        if (audioSource != null && narrationAudio != null)
        {
            audioSource.PlayOneShot(narrationAudio); // Play voice-over
        }

        yield return new WaitForSeconds(textDisplayDuration);
        narrationText.text = ""; // Hide text after duration
    }
}
