using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class clock : MonoBehaviour
{
    public Transform hoursArmPivot;
    public Transform MinuteArmPivot;
    public Transform SecondArmPivot;


    private void Start()
    {
        hoursArmPivot.localRotation = Quaternion.Euler(0, 0, -150);
    }
    private void Update()
    {
        DateTime t = DateTime.Now;
        hoursArmPivot.localRotation = Quaternion.Euler(0, 0, -30 * t.Hour - (0.5f * t.Minute));
        MinuteArmPivot.localRotation = Quaternion.Euler(0, 0, -6 * t.Minute - (0.1f * t.Second));
        SecondArmPivot.localRotation = Quaternion.Euler(0, 0, -6 * t.Second - (0.006f * t.Millisecond));
    }
}
