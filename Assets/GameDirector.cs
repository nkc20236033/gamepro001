using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;   // UIを使うので忘れずに追加

public class GameDirector : MonoBehaviour
{
    GameObject hpgauge;

    void Start()
    {
        this.hpgauge = GameObject.Find("hpgauge");
    }

    public void DecreaseHp()
    {
        this.hpgauge.GetComponent<Image>().fillAmount -= 0.01f;
    }
 void Update()
    {
        
    }
}