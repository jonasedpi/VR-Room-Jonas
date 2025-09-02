using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
public class Clock_analog : MonoBehaviour
{
    public DateTime currentTime;
    public float hourAngle;
    public float minuteAngle;
    public float secondAngle;
    // Start is called before the first frame update
    void Start()
    {
        currentTime = DateTime.Now;
    }

    // Update is called once per frame
    void Update()
    {
        UpdateClock();
    }

    public void UpdateClock()
    {
        // transfortion hours, minutes and seconds to angles
        currentTime = DateTime.Now;
        hourAngle = (currentTime.Hour % 12 + currentTime.Minute / 60f) * 30f; // 360 degrees / 12 hours
        minuteAngle = (currentTime.Minute + currentTime.Second / 60f) * 6f; // 360 degrees / 60 minutes
        secondAngle = currentTime.Second * 6f; // 360 degrees / 60 seconds  

        transform.Find("Clock_Analog_A_Hour").localRotation = Quaternion.Euler(90+hourAngle, 0, -90);
        transform.Find("Clock_Analog_A_Minute").localRotation = Quaternion.Euler(90+minuteAngle, 0, -90);
        transform.Find("Clock_Analog_A_Second").localRotation = Quaternion.Euler(90+secondAngle, 0, -90);
    }
}

