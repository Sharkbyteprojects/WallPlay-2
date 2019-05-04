using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EVA : MonoBehaviour
{
    public float speed = 0.09f;
    public bool up = false;
    bool act = false;
    void Update(){
        if(up){
            if(act){
                transform.Translate(Vector3.up * speed);
            }
        }
    }
    void OnCollisionEnter2D(Collision2D coll)
    {
        if (coll.gameObject.name == "PLAYER")
        {
            if(!up){
            transform.Translate(Vector3.down * speed);
            }
            if(up){
                act = true;
            }
        }
    }
}
