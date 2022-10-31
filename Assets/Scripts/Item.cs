using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Item : MonoBehaviour
{
    [SerializeField]
    float _restorationTime;

    [SerializeField]
    [Header("�N���A�e�L�X�g")]
    TextMeshProUGUI _clearText;
    void OnTriggerEnter(Collider other)
    {
        Debug.Log("�A�C�e���Q�b�g");
        GameTimer._timer = _restorationTime;

        Destroy(this.gameObject);
    }
}
