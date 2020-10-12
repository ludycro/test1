using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KretanjeProtivnika : MonoBehaviour
{
    public float brzinaKretanjaProtivnika;
    Rigidbody2D objekt;

    // Use this for initialization
    void Awake ()
    {
        objekt = GetComponent<Rigidbody2D> ();
    }

    //FixedUpdate is called at a fixed interval and is independent of frame rate. Put physics code here.
    void Update()
    {
        if (Input.GetKey (KeyCode.A)) {
        objekt.velocity = new Vector2 (brzinaKretanjaProtivnika * -1, 0);
        }
        

        else if (Input.GetKey (KeyCode.D)){
        objekt.velocity = new Vector2 (brzinaKretanjaProtivnika , 0);
        }
        
        else objekt.velocity = new Vector2 (0, 0);
    }
}