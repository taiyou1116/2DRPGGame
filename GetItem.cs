using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetItem : MonoBehaviour
{
   //特定のボタンを押したらアイテムを消滅させる
   //アイテムの取得
   
   [SerializeField] Item.Type itemType;
   Item item;
   

   private void Start()
   {
       //itemTypeに応じてItemを生成する
       item = ItemGenerater.instance.Spawn(itemType);
   }
   

   public void OnClickObj()
   {
       if(PlayerManager.instance.near == true)
       {
           gameObject.SetActive(false);
           ItemBox.instance.SetItem(item);
           PlayerManager.instance.near = false;
       }
       
   }
  

   
}
