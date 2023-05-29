using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 0.05f;
   
    void Start()
    {
        Application.targetFrameRate = 100;
    }

    void Update()
    {
        //プレイヤー関連にはｐが付く
        //プレイヤーの移動　X ＝横、Y＝縦
        float px = Input.GetAxisRaw("Horizontal");
        float py = Input.GetAxisRaw("Vertical");

        transform.position = new Vector3(
            //エリア指定して移動する
            Mathf.Clamp(transform.position.x + px, -10.0f, 10.0f),
            Mathf.Clamp(transform.position.y + py, -4.5f, 4.5f)
            );

        transform.position += new Vector3(px * speed, py * speed, 0);
    }
}