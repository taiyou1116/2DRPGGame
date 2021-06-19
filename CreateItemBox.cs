using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateItemBox : MonoBehaviour
{
    public ItemBox itemBox;
    bool openItemBox;

    void Start()
    {
        StartCoroutine("Startcoroutine");
    }
    IEnumerator Startcoroutine()
    {
        itemBox.gameObject.SetActive(false);
        yield return new WaitForSeconds(1.0f);
    }
   
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space) && openItemBox == false)
        {
            OpenItemBox();
            openItemBox = true;
        }
        else if(Input.GetKeyDown(KeyCode.Space) && openItemBox == true)
        {
            CloseItemBox();
            openItemBox = false;
        }
    }
    public void OpenItemBox()
    {
        itemBox.gameObject.SetActive(true);
    }
    public void CloseItemBox()
    {
        itemBox.gameObject.SetActive(false);
    }
}
