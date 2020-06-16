using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Buttounscript : MonoBehaviour
{
    public AudioSource audio;
    public GameObject panel;
  public  void onpressPlay()
    {
        SceneManager.LoadScene(1);
    }
    public void onpressQuit()
    {
        Application.Quit();
    }
    public void onPressReload()
    {
        SceneManager.LoadScene(1);
    }
    public void onPressSetting()
    {
        panel.SetActive(true);
    }
    public void onClose()
    {
        panel.SetActive(false);
    }
    public void onpressSoundOff()
    {
        audio.Pause();
    }
    public void onpressSoundOn()
    {
        audio.Play();
    }
    void Update()
    {
        
    }
}
