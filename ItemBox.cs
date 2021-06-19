using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemBox : MonoBehaviour
{
    [SerializeField] Slot[] slots;
    [SerializeField] Slot selectedSlot;
    public static ItemBox instance;

    //public Item.Type chooseItem;
    
    
    
    
    
    private void Awake()
    {
        instance = this;
        slots = GetComponentsInChildren<Slot>();
    }
    public void SetItem(Item item)
    {
       for(int i = 0; i<slots.Length; i++)
       {
           if(slots[i].IsEmpty())
           {
               slots[i].SetItem(item);
               break;
           }
       }   
    }

    public void OnSelectSlot(int position)
    {
        //一旦すべてのパネルの選択を非表示にする
        //選択されたスロットの選択パネルを表示
        foreach(Slot slot in slots)
        {
            slot.HideBGPanel();
        }
        if(slots[position].OnSelected())
        {
            selectedSlot = slots[position];
        }    
    }
    
    public bool TryUseItem(Item.Type type)
    {
      if(PlayerManager.instance.near == true)
       {
            //選択スロットがあるか
        if(selectedSlot == null)
        {
            return false;
        }
        if(selectedSlot.GetItem().type == type)
        {
            selectedSlot.SetItem(null);
            selectedSlot.HideBGPanel();
            selectedSlot = null;
            return true;
            PlayerManager.instance.near = false;
        }
        
       }
        return false;
        
    }

    public bool OnGetItem(Item.Type itemtype)
    {
        //アイテムボックスにキーがあるか確かめる。
        //あるならtrue
        for(int i = 0;i <slots.Length; i++)
        {
            if(slots[i].item.type == itemtype)
            {
                
                return true;
            }
            
        }
        return false;
        
    }
    /*void Update()
    {
        OnGetKey();
    }*/
    

}
