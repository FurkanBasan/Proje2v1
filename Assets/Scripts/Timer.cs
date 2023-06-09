using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    [SerializeField] private Image _time;
    [SerializeField] private Text _timeText;
    private float _currentTime;
    [SerializeField] private float _duration;
    public GameObject nextlevel;
    public GameObject Gameover;
    public SkorSistem SkorScoreNum;
    public int BolumGecmeSay;
    public Hskor PP;
    [SerializeField] private AudioSource EndWhistle;


    void Start()
    {
        
        _currentTime = _duration;
        _timeText.text = _currentTime.ToString();
        StartCoroutine(CountdownTime());
    }

    private IEnumerator CountdownTime()
    {
        while (_currentTime >= 0)
        {
            _time.fillAmount = Mathf.InverseLerp(0, _duration, _currentTime);
            _timeText.text = _currentTime.ToString();
            yield return new WaitForSeconds(1f);
            _currentTime--;


            if (_currentTime == 0 && SkorScoreNum.ScoreNum <= BolumGecmeSay) //Bölümü Geçemedi
            {
                EndWhistle.Play();
                Gameover.SetActive(true);
                Time.timeScale = 0;

            }
            else if (_currentTime == 0 && SkorScoreNum.ScoreNum > BolumGecmeSay) //Bölümü Geçti
            {
                EndWhistle.Play();
                nextlevel.SetActive(true);
                Time.timeScale = 0;
                PP.YskorY();
            }

        }
        yield return null;

    }
}