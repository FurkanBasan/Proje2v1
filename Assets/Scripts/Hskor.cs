using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hskor : MonoBehaviour
{

    public SkorSistem SkorScoreNum;

    public void Yskor() //Y�ksek Skor Ata
    {
        if (PlayerPrefs.HasKey("Yskor")){

        }
        else
        {
            PlayerPrefs.SetInt("Yskor", 0);
        }
    }
    public void YskorY() //Y�ksek Skor Y�kselt
    {
        int x = PlayerPrefs.GetInt("Skor");
        int skor1 = PlayerPrefs.GetInt("Yskor");
        PlayerPrefs.SetInt("Yskor", (skor1 + x));
    }
    public void DskorR() //Anl�k Skor Y�kselt (Reklamda)
    {
        int x = PlayerPrefs.GetInt("Skor");
        PlayerPrefs.SetInt("Skor", (x*2));
    }
}