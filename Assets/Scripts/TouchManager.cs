using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TouchManager : MonoBehaviour
{
    [SerializeField] GameObject gameOverPanel;
    [SerializeField] Text touchText;
    [SerializeField] int touchOfTimes;

    private int attack;
    private int deattack;

    void Start()
    {
        attack = 0;
    }

    public void OnClick()
    {
        attack++;
    }

    void Update()
    {
        if(attack == touchOfTimes)
        {
            gameOverPanel.SetActive(true);
        }
        deattack = touchOfTimes - attack;
        string deattackStr = deattack.ToString();
        touchText.text = deattackStr;
    }
}