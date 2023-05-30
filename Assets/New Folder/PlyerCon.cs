using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.GlobalIllumination;

public class PlyerCon : MonoBehaviour
{
    Vector3 dir = Vector3.zero;  // 移動方向を保存する変数
   

    // Start is called before the first frame update
    void Start()
    {
        Application.targetFrameRate = 60;
    }

    // Update is called once per frame

    void Update()
    {
        float speed = 0.05f;
        float px = Input.GetAxisRaw("Horizontal");
        float py = Input.GetAxisRaw("Vertical");
        transform.position += new Vector3(px * speed, py * speed, 0);

        transform.position =new Vector3
            ( //エリア指定して移動する
             Mathf.Clamp( transform.position.x + px, -10.0f, 10.0f ),
             Mathf.Clamp( transform.position.y + py, -4.5f, 4.5f )
             );
    }
}
