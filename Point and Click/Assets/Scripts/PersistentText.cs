using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PersistentText : MonoBehaviour
{
    private void Awake()
    {
        // Check if another instance already exists
        if (GameObject.FindObjectsOfType<PersistentText>().Length > 1)
        {
            Destroy(gameObject); // Destroy duplicate instance
        }
        else
        {
            DontDestroyOnLoad(gameObject); // Persist this Text UI across scenes
        }
    }
}
