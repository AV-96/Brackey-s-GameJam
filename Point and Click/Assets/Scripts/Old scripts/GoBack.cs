using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GoBack : MonoBehaviour
{
   public Button targetButton; // Assign the button you want to hide/show

    private void Start()
    {
        if (targetButton != null)
        {
            targetButton.gameObject.SetActive(false); // Hide the button initially
        }
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.H))
        {
            if (targetButton != null)
            {
                bool isActive = targetButton.gameObject.activeSelf;
                targetButton.gameObject.SetActive(!isActive); // Toggle visibility
            }
        }
    }
}
