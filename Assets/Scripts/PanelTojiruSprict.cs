using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PanelTojiruSprict : MonoBehaviour
{
    [SerializeField] GameObject hirakupanel;
    
    public void OnClick()
    {
        hirakupanel.SetActive(false);
    }
}