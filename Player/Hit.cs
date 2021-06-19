using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hit : MonoBehaviour
{
    public SceneManager sceneManager;
    public Friend1 friend1;
    public Fungus.Flowchart flowchart = null;
    public string[] sendMessage;
    //public Item.Type itemtype;

    bool isTouth;
    bool getKey;
    //Update内の判定を一度だけにする
    bool isCalledOnce = false;

    bool getTree = ItemBox.instance.OnGetItem(Item.Type.Tree);

    Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        Debug.Log("a");
        if(other.gameObject.CompareTag("Player"))
        {
            isTouth = true;
            Debug.Log("in");
        }
    }
    private void OnCollisionExit2D(Collision2D other)
    {
        Debug.Log("a");
        if(other.gameObject.CompareTag("Player"))
        {
            isTouth = false;
            Debug.Log("out");
        }
    }






    void Update()
    {
        if(isTouth == true && getKey == false)
        {
            flowchart.SendFungusMessage(sendMessage[0]);            
        }
        if(!isCalledOnce)
        {
            if(getKey == true && isTouth == true)
            {
                flowchart.SendFungusMessage(sendMessage[1]); 
                friend1.FriendMove();
                isCalledOnce = true;
            }
        }

        if(ItemBox.instance.OnGetItem(Item.Type.Key))
        {
            getKey = true;
        }

        if(isTouth == true && getTree == false && sceneManager.isFoor2 == true)
        {
            flowchart.SendFungusMessage(sendMessage[3]);
        }
        if(ItemBox.instance.OnGetItem(Item.Type.Tree))
        {
            getTree =true;
            if(isTouth == true && getTree == true　&& sceneManager.isFoor2 == true)
            {
                //木のアイテムを持っている状態と二階にいるという条件
                flowchart.SendFungusMessage(sendMessage[2]);
            }
        }

      



        

    }

   
}
