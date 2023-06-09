using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SkorSistem : MonoBehaviour
{
    public Text Skor;
    public int ScoreNum;
    public GameObject efekt;
    [SerializeField] private AudioSource topefekt;

    void Start()
    {
        ScoreNum = 0;
       
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Top")
        {

            topefekt.Play();
            ScoreNum += 1;
            var myVar = Instantiate(efekt, transform.position, Quaternion.identity);
            Destroy(collision.gameObject);
            Destroy(myVar, 1);
            Skor.text = "Skor : " + ScoreNum;
            PlayerPrefs.SetInt("Skor", ScoreNum);
        }
    }

}