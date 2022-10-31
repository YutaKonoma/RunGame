using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Item : MonoBehaviour
{
    [SerializeField]
    float _restorationTime;

    [SerializeField]
    [Header("クリアテキスト")]
    TextMeshProUGUI _clearText;
    void OnTriggerEnter(Collider other)
    {
        Debug.Log("アイテムゲット");
        GameTimer._timer = _restorationTime;

        Destroy(this.gameObject);
    }
}
