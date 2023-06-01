using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.GlobalIllumination;

public class PlyerCon : MonoBehaviour
{
    Vector3 dir = Vector3.zero;  // ˆÚ“®•ûŒü‚ğ•Û‘¶‚·‚é•Ï”

    Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        Application.targetFrameRate = 60;
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame

    void Update()
    {
        float speed = 0.1f;
        float px = Input.GetAxisRaw("Horizontal");
        float py = Input.GetAxisRaw("Vertical");
        transform.position += new Vector3(px * speed, py * speed, 0);

       
        if (py == 0)
        {
            anim.Play("player Animation");
        }
        else if (py == 1)
        {
            anim.Play("PlayerL");
        }
        else
        {
            anim.Play("PlayerP");
        }
    }
}
