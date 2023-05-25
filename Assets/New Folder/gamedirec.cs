using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class GameDirector1 : MonoBehaviour
{
    GameObject hp;
    // Start is called before the first frame update
    void Start()
    {
        this.hp = GameObject.Find("ImageHP");
    }
    public void DecreaseHp()
    {
        this.hp.GetComponent<Image>().fillAmount -= 0.1f;
    }
    // Update is called once per frame
    void Update()
    {

    }
}