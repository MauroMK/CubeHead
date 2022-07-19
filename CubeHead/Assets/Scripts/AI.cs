using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AI : MonoBehaviour
{
    public Animator anim;
    public float speed = 0.003f;
    public int hp = 5;

    void Start()
    {
        anim.Play("Enemie Running");
    }

    void Update()
    {
        transform.eulerAngles = new Vector3(0, GameObject.Find("Main Camera").transform.eulerAngles.y, 0);

        transform.position -= transform.forward * this.speed;


    }
}
