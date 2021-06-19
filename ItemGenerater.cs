using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemGenerater : MonoBehaviour
{
    public static ItemGenerater instance;
    private void Awake()
    {
        instance = this;
    }
    [SerializeField] ItemListEntity itemListEntity;

    public Item Spawn(Item.Type type)
    {
        //itemListの中からtypeと一致するitemを生成して渡す
        foreach(Item item in itemListEntity.itemList)
        {
            if(item.type == type)
            {
                return new Item(item.type,item.sprite);
            }
        }
        return null;
    }
}
