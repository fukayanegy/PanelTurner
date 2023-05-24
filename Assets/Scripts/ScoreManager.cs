using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour 
{
  [SerializeField] GameObject clearPanel;
    public GameObject gameobject11;
    public GameObject gameobject12;
    public GameObject gameobject13;
    public GameObject gameobject14;
    public GameObject gameobject21;
    public GameObject gameobject22;
    public GameObject gameobject23;
    public GameObject gameobject24;
    public GameObject gameobject31;
    public GameObject gameobject32;
    public GameObject gameobject33;
    public GameObject gameobject34;
    public GameObject gameobject41;
    public GameObject gameobject42;
    public GameObject gameobject43;
    public GameObject gameobject44;


    public GameObject score_object = null; // Textオブジェクト

      void Start ()
      {
      }

      void Update ()
      {

        float Num11 = gameobject11.transform.localEulerAngles.y;
        float Num12 = gameobject12.transform.localEulerAngles.y;
        float Num13 = gameobject13.transform.localEulerAngles.y;
        float Num14 = gameobject14.transform.localEulerAngles.y;
        float Num21 = gameobject21.transform.localEulerAngles.y;
        float Num22 = gameobject22.transform.localEulerAngles.y;
        float Num23 = gameobject23.transform.localEulerAngles.y;
        float Num24 = gameobject24.transform.localEulerAngles.y;
        float Num31 = gameobject31.transform.localEulerAngles.y;
        float Num32 = gameobject32.transform.localEulerAngles.y;
        float Num33 = gameobject33.transform.localEulerAngles.y;
        float Num34 = gameobject34.transform.localEulerAngles.y;
        float Num41 = gameobject41.transform.localEulerAngles.y;
        float Num42 = gameobject42.transform.localEulerAngles.y;
        float Num43 = gameobject43.transform.localEulerAngles.y;
        float Num44 = gameobject44.transform.localEulerAngles.y;

        float NumScore = Num11 + Num12 + Num13 + Num14 + Num21 + Num22 + Num23 + Num24 + Num31 + Num32 + Num33 + Num34 + Num41 + Num42 + Num43 + Num44;

      bool DestroAllPanel()
      {
        if( NumScore < 2800)
        {
          return false;
        }
        return true;
      }

        if(DestroAllPanel())
        {
          clearPanel.SetActive(true);
        }
      }
}