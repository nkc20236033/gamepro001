using System.Collections;
using System.Collections.Generic;
using System.Net;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;


public class gamedirec: MonoBehaviour
{
    GameObject gauge;
    �@[SerializeField]float time;//���Ԋ֘A�̕ϐ�
    �@[SerializeField]float Limit;
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
        Debug.Log(time);
    }
   
    
}