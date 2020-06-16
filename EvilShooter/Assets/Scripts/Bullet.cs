using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Bullet : MonoBehaviour
{

    int num;
    Scorecalculater s;
 
    private void Start()
    {
        s = GameObject.Find("uimanager").GetComponent<Scorecalculater>();
       
      
    }
    private void OnEnable()
    {
        Invoke("kill", 1f);
    }
    void kill()
    {
        GameObject.Find("PlayerRotationButtounmanager").GetComponent<shooting>().putInlist(gameObject);
    }
  
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag=="enemy")
        {
            s.incrementscore();
            Destroy(collision.gameObject);
            gameObject.SetActive(false);
            GameObject.Find("PlayerRotationButtounmanager").GetComponent<shooting>().putInlist(gameObject);
        }
        else
        {
            GameObject.Find("PlayerRotationButtounmanager").GetComponent<shooting>().putInlist(gameObject);
        }

    }
}
