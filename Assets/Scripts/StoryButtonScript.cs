using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StoryButtonScript : MonoBehaviour
{
    [SerializeField] GameObject hirakupanel;
    [SerializeField] GameObject kesupanel1;
    [SerializeField] GameObject kesupanel2;

    public void OnClick()
    {
        hirakupanel.SetActive(true);
        kesupanel1.SetActive(false);
        kesupanel2.SetActive(false);
    }
}
