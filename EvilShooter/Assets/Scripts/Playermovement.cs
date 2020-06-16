using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Playermovement : MonoBehaviour
{
   public int hit = 0;
    public GameObject[] heart;
    private void Update()
    {
        if (hit == 3)
        {
            SceneManager.LoadScene(2);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag=="enemy")
        {
            hit += 1;
            Handheld.Vibrate();
            heart[hit - 1].SetActive(false);
        }
    }
}
