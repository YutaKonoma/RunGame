using System.Collections;
using System.Collections.Generic;
using UnityChan;
using UnityEngine;

public class SppedUpItem : MonoBehaviour
{
    [SerializeField]
    float _upSpeed;
    void OnTriggerEnter(Collider other)
    {
        Debug.Log("�A�C�e���Q�b�g");

        this.gameObject.SetActive(false);
        UnityChanControlScriptWithRgidBody.forwardSpeed += _upSpeed;
    }
}
