using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchTimeDerate : MonoBehaviour
{
public TouchScript touchScript;
void OnMouseUp()
{
    int touchTime;
    touchTime = touchScript.touchTimes;
    touchTime++;
}
}