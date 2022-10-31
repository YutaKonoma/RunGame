using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class RemainderItem : MonoBehaviour
{
    [SerializeField]
    [Header("残りアイテム")]
    public static List<GameObject> _remainderItems;

    [SerializeField]
    public List<GameObject> __remainderSpeedItems;

    [SerializeField]
    [Header("アイテムの生成数")]
    int _itemCount;

    [SerializeField]
    [Header("アイテムの生成数")]
    int _speedUpItemCount;

    [SerializeField]
    [Header("生成範囲")]
    Vector3 _generationRangePos;

    [SerializeField]
    [Header("生成するアイテム")]
    GameObject _item;

    [SerializeField]
    [Header("生成するスピードアップアイテム")]
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
