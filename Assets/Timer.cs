using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Timer : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI timerText;
    float elapsepTime;

    void Update()
    {
        elapsepTime = Time.time;
        int min = Mathf.FloorToInt(elapsepTime / 60);
        int sec = Mathf.FloorToInt(elapsepTime % 60);
        timerText.text = string.Format("{0:00}:{1:00}", min, sec);
    }
}