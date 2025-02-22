using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeTimerValue : MonoBehaviour
{
   public float changeAmount = 5f;
    // Start is called before the first frame update
    void Start()
    {
        CountdownTimer.Instance.AddTime(changeAmount);
    }

    
}
