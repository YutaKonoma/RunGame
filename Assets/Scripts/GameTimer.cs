using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameTimer : MonoBehaviour
{
    [Header("���Ԑ���")]
    public static float _timer;

    [SerializeField]
    [Header("���Ԑ�����\������e�L�X�g")]
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
