using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

[Serializable] 
public class Item 
{
    public enum Type
    {
        Key,
        Tree,

    }

    public Type type; //種類
    public Sprite sprite; //画像

    public Item(Type type,Sprite sprite)
    {
        this.type = type;
        this.sprite = sprite;
    }
}    

