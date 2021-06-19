using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ShowItem : MonoBehaviour
{
    public GameObject textPanel;
    bool openPanel;

    void Start()
    {
        textPanel.gameObject.SetActive(false);
    }

    

    public void OnClickObj()
    {
        if(openPanel == false)
        {
            if(PlayerManager.instance.near == true)
            {
                 ShowPanel();
            }
          
           
            //パネルを表示
           
        }
        else　if (openPanel == true)
        {
           ClosePanel();
        }
        
    }

    void ShowPanel()
    {
         textPanel.gameObject.SetActive(true);
            openPanel = true;
            PlayerManager.instance.near = false;
    }
    void ClosePanel()
    {
         textPanel.gameObject.SetActive(false);
            openPanel = false;
    }
}
