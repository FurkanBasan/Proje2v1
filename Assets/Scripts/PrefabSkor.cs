using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrefabSkor : MonoBehaviour
{
    // Start is called before the first frame update
    public void PrefabO()
    {
        if (PlayerPrefs.HasKey("Skor")) {

            PlayerPrefs.SetInt("Skor", 0);
        }
        else
        {
            PlayerPrefs.SetInt("Skor",0);
        }

        if (PlayerPrefs.HasKey("Yskor"))
        {
            PlayerPrefs.SetInt("Yskor", 0);
        }
        else
        {
            PlayerPrefs.SetInt("Yskor", 0);
        }
        
    }
}
