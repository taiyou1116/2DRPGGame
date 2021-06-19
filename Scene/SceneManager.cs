using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneManager : MonoBehaviour
{
    public Friend1 friend1;
    public PlayPanel playPanel;
    public bool isFoor2 =false;
    void OnCollisionEnter2D(Collision2D other)
    {
        if(other.gameObject.tag == "Player")
        {
            
            Vector3 floor2 = new Vector3(24f,-3f,0);
            other.gameObject.transform.position = floor2;
            friend1.GoToFloor2();
            StartCoroutine("FadeInOut");
            isFoor2 = true;

        }
    }
    IEnumerator FadeInOut()
    {
        playPanel.isFadeOut = true;
        yield return new WaitForSeconds(0.3f);
        playPanel.isFadeIn = true;
       
    }
}
