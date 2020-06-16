using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Scorecalculater : MonoBehaviour
{
    public int n;
    
    public TextMeshProUGUI score;
   
    void Start()
    {
        score.text = "Score :";
       
        
    }

    // Update is called once per frame
    void Update()
    {
       // Debug.Log(n);
    }
    public void incrementscore()
    {
        n++;
        score.text = "Score :"+ n.ToString();
        if(n>PlayerPrefs.GetInt("HighScore",0))
        {
            PlayerPrefs.SetInt("HighScore", n);
         
        }
    }
}
