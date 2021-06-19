using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SampleGimic : MonoBehaviour
{
    [SerializeField] Item.Type clearItem;
   public void OnClickObj()
   {
       bool clear = ItemBox.instance.TryUseItem(clearItem);
       if(clear == true)
       {
           gameObject.SetActive(false);
       }
   }

   
}
