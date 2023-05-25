using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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
        float speed = 0.09f;
        float x = Input.GetAxisRaw("Horizontal");
        float y = Input.GetAxisRaw("Vertical");
        transform.position += new Vector3(x * speed, y * speed, 0);
    }
}
