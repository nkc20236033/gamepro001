using System.Collections;
using System.Collections.Generic;
using System.Net;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class gamedirec: MonoBehaviour
{
    GameObject gauge;
    @[SerializeField]float time;//ŠÔŠÖ˜A‚Ì•Ï”
    @[SerializeField]float Limit;
    void Start()
    {
    gauge = GameObject.Find("HP");
    }
    public void DecreaseHp()
    {
        gauge.GetComponent<Image>().fillAmount -= 0.1f;
        time -= 1f / Limit;
    }
   
    void Update()
    {
     time -=1f/Limit* Time.deltaTime;
        
        gauge.GetComponent<Image>().fillAmount -= 1f / Limit * Time.deltaTime;
        if (gauge.GetComponent<Image>().fillAmount <= 0)
        {
            SceneManager.LoadScene(1);
        }
        
    }
   
    
}