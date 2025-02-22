using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dontdontonload : MonoBehaviour
{
    private void Awake()
    {
    
        DontDestroyOnLoad(gameObject); // Persist this Text UI across scenes
    
    }
}
