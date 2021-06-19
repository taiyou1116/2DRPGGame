using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Slot : MonoBehaviour
{
    [SerializeField] Image image;
    [SerializeField] GameObject bgPanel;
    [System.NonSerialized] public Item item;

    

    private void Start()
    {
        bgPanel.SetActive(false);
    }

    

    public void SetItem(Item item)
    {
        this.item = item;
        UpdateImage(item);
    }
    public Item GetItem()
    {
        return item;
    }

    void UpdateImage(Item item)
    {
        if(item == null)
        {
            image.sprite = null;
        }
        else
        {
            image.sprite = item.sprite;
        }
        
    }

    public bool IsEmpty()
    {
        if(item == null)
        {
            return true;
        }
        return false;
    }

    public bool OnSelected()
    {
        if(item == null)
        {
            return false;
        }
        bgPanel.SetActive(true);
        return true;
    }

    public void HideBGPanel()
    {
        bgPanel.SetActive(false);
    }

    /*public bool OnGetKey()
    {
        if(item.type == Item.Type.Key)
        {
            Debug.Log("tensai");
            return true;
        }
        return false;
    }

    void Update()
    {
        OnGetKey();
    }*/
}
