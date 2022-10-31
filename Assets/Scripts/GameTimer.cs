using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameTimer : MonoBehaviour
{
    [Header("時間制限")]
    public static float _timer;

    [SerializeField]
    [Header("時間制限を表示するテキスト")]
    TextMeshProUGUI _timerText;

    [SerializeField]
    TextMeshProUGUI _gameOver;
    private void Awake()
    {
        _timer = 10.00f;
        _timerText.text = "Time:" + _timer;

        _gameOver.enabled =false;
    }

    void Update()
    {
        _timer -= Time.deltaTime;
        _timerText.text ="time:" + _timer.ToString("f2");

        if(_timer <=0)
        {
            _gameOver.enabled = true;
        }
    }
}
