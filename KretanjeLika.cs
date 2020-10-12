using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class KretanjeLika : MonoBehaviour
{
    public float brzinaKretanjaIgraca;
    Rigidbody2D objekt;

    // Use this for initialization
    void Awake()
    {
        objekt = GetComponent<Rigidbody2D>();
    }

    //FixedUpdate is called at a fixed interval and is independent of frame rate. Put physics code here.
    void Update()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            objekt.velocity = new Vector2(brzinaKretanjaIgraca * -1, 0);
        }


        else if (Input.GetKey(KeyCode.RightArrow))
        {
            objekt.velocity = new Vector2(brzinaKretanjaIgraca, 0);
        }

        else objekt.velocity = new Vector2(0, 0);
    }

}