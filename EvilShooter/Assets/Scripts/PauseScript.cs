using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class PauseScript : MonoBehaviour
{
    public GameObject panel;
    
   
    public void onPressPause()
    {
        Time.timeScale = 0;
        panel.SetActive(true);
    }
    public void onPressResume()
    {
        panel.SetActive(false);
        Time.timeScale = 1;
    }
    public void onpressexit()
    {
        SceneManager.LoadScene(0);
    }
}
