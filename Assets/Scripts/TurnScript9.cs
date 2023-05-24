using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TurnScript9 : MonoBehaviour
{
    [SerializeField] GameObject touchPanel;
    [SerializeField] List<GameObject> objectList = new List<GameObject>();

    public void OnMouseUp()
    {       
        objectList[0].transform.Rotate(new Vector3(0, 180, 0));
        objectList[1].transform.Rotate(new Vector3(0, 180, 0));
        objectList[2].transform.Rotate(new Vector3(0, 180, 0));
        objectList[3].transform.Rotate(new Vector3(0, 180, 0));
        objectList[4].transform.Rotate(new Vector3(0, 180, 0));
        objectList[5].transform.Rotate(new Vector3(0, 180, 0));
        objectList[6].transform.Rotate(new Vector3(0, 180, 0));
        objectList[7].transform.Rotate(new Vector3(0, 180, 0));
        objectList[8].transform.Rotate(new Vector3(0, 180, 0));
    }
}