using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemygen : MonoBehaviour
{
    public GameObject enemy;
    float span  = 1.0f;
    float delta = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {//スポーン間隔の設定
        this.delta += Time.deltaTime;
        if(this.delta> this.span)
        {
            this.delta = 0;
            //出現位置の設定
            GameObject go = Instantiate(enemy);
            int ey = Random.Range(-5, 5);
            go.transform.position = new Vector3(10,ey,0);
        }
            }
}
