using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MoveScript : MonoBehaviour
{
    [SerializeField] string movescene;
    void Start()
    {
        
    }

    void Update()
    {
        
    }
    public void OnStart()
    {
        SceneManager.LoadScene("Sanple", LoadSceneMode.Single);
    }
}