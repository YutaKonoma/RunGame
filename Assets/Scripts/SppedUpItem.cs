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
        Debug.Log("アイテムゲット");

        this.gameObject.SetActive(false);
        UnityChanControlScriptWithRgidBody.forwardSpeed += _upSpeed;
    }
}
