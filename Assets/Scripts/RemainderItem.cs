using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class RemainderItem : MonoBehaviour
{
    [SerializeField]
    [Header("�c��A�C�e��")]
    public static List<GameObject> _remainderItems;

    [SerializeField]
    public List<GameObject> __remainderSpeedItems;

    [SerializeField]
    [Header("�A�C�e���̐�����")]
    int _itemCount;

    [SerializeField]
    [Header("�A�C�e���̐�����")]
    int _speedUpItemCount;

    [SerializeField]
    [Header("�����͈�")]
    Vector3 _generationRangePos;

    [SerializeField]
    [Header("��������A�C�e��")]
    GameObject _item;

    [SerializeField]
    [Header("��������X�s�[�h�A�b�v�A�C�e��")]
    GameObject _speedUpItem;


    void Start()
    {
        GenerationItem();
        GenerationSppedUpItem();
    }

    void GenerationItem()
    {
        if(_itemCount > 0)
        {
            _generationRangePos.x = Random.Range(950, 1050);
            _generationRangePos.z = Random.Range(250, 300);

           GameObject _items = Instantiate(_item, _generationRangePos, Quaternion.identity);

            _itemCount--;
            _remainderItems.Add(_items);
            GenerationItem();
        }
    }

    void GenerationSppedUpItem()
    {
        if(_speedUpItemCount > 0)
        {
            _generationRangePos.x = Random.Range(950, 1050);
            _generationRangePos.z = Random.Range(250, 300);

            GameObject _speedItems = Instantiate(_speedUpItem, _generationRangePos, Quaternion.identity);

            _itemCount--;
            _remainderItems.Add(_speedItems);
            GenerationSppedUpItem();
        }
    }

}
