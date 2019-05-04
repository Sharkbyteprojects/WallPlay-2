using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WIN : MonoBehaviour
{
    public GameObject destroyi;
    public float speed = 0.09f;
    public float speedup = 0.1f;
    bool winhandler = false;
    void Start()
    {
        winhandler = false;
        destroyi.SetActive(false);
    }
    void Update()
    {
        if(!winhandler){
        if (Input.GetKey("escape"))
        {
            Application.Quit();
        }
        if (Input.GetKey(KeyCode.D)) {
            transform.Translate(Vector3.right * speed);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Translate(Vector3.right * speed);
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(Vector3.left * speed);
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Translate(Vector3.left * speed);
        }
        if (Input.GetKey(KeyCode.Space))
        {
            transform.Translate(Vector3.up * speedup);
        }
        }
        
    }
    void OnCollisionEnter2D(Collision2D coll)
    {
        if (coll.gameObject.name == "ziel")
        {
            winhandler = true;
            Debug.Log("Winhandler: " + winhandler);
            destroyi.SetActive(true);
        }
    }
}
