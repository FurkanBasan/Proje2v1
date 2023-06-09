using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class NewBehaviourScript : MonoBehaviour
{

    public TMP_Text Skor;
    public TMP_Text Hskor;
    int x;
    int y;

    public void hskortext()
    {
        y = PlayerPrefs.GetInt("Yskor");
        Hskor.SetText(y.ToString());
    }

    public void skortext()
    {
        x = PlayerPrefs.GetInt("Skor");

        Skor.SetText(x.ToString());

    }
    void Start()
    {
        skortext();
        hskortext();
    }
}