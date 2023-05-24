using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartScripts : MonoBehaviour
{
    void Start()
    {
        
    }

    void Update()
    {
        
    }

    public void OnStart()
    {
        SceneManager.LoadScene("Map", LoadSceneMode.Single);
    }
}
