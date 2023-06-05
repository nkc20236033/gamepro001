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
    Å@[SerializeField]float time;//éûä‘ä÷òAÇÃïœêî
    Å@[SerializeField]float Limit;
    [SerializeField] float leng;
    void Start()
    {
        leng = 5;
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