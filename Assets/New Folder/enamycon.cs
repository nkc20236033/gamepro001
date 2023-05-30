using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class enamycon : MonoBehaviour
{
    GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        this.player = GameObject.Find("player");
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(-0.1f, 0, 0);
        if (transform.position.x < -10.0f)
        {
            Destroy(gameObject);
        }
        Vector3 p1 = transform.position;
        Vector3 p2 = this.player.transform.position;
        Vector3 dir = p1 - p2 ;
        float d = dir.magnitude;
        float r1 = 0.5f;
        float r2 = 1.0f;
        if (d < r1 + r2)
        {
            GameObject obj = GameObject.Find("gamedirec");
            obj.GetComponent<gamedirec>().DecreaseHp();
            Destroy(gameObject);
        }


    }

}
