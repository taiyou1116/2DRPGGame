using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnTreeGimic : MonoBehaviour
{
    [SerializeField] Item.Type clearItem;
    [SerializeField] GameObject tree;

   
    public void OnClickObj()
   {
       bool clear = ItemBox.instance.TryUseItem(clearItem);
       if(clear == true)
       {
           tree.gameObject.SetActive(true);
       }
   }
}
