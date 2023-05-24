using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TouchScript : MonoBehaviour
{
    [SerializeField] GameObject GameOverPanel;
    [SerializeField] Text touchText;
    [SerializeField] int touchOfTimes;

    public int touchTimes;
    private int detouchTimes;

    void Start()
    {
        touchTimes = 0;
    }

    void Update()
    {
        if(touchTimes == touchOfTimes)
        {
            GameOverPanel.SetActive(true);
        }
        detouchTimes = touchOfTimes - touchTimes;
        string detouchTimesStr = detouchTimes.ToString();
        touchText.text = detouchTimesStr;
    }
}