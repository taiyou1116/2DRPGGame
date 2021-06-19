using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Friend1 : MonoBehaviour
{
    bool stopMove = true;

    public Collider2D col;

    void Start()
    {
        
    }

    void Update()
    {

    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.GetComponent<Collider2D>() == col)
        {
            Debug.Log("kami");
            stopMove = false;

        }
    }

    public void FriendMove()
    {
        Debug.Log("kiteru");
        //スタート位置とゴール位置を設定して移動させる
        Vector3 endPos = new Vector3(10f,2f,0);
        

        transform.position = endPos;
        
        
    }
    public void GoToFloor2()
    {
        Vector3 floor2 = new Vector3(23f,0,0);
        transform.position = floor2;
    }
    
}
