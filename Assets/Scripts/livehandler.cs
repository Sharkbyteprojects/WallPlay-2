using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class livehandler : MonoBehaviour
{
    public string attacker = "liv";
    public GameObject h1;
    public GameObject h2;
    public GameObject h3;
    public GameObject h4;
    public GameObject h5;
    public int lh = 0;

    void Start()
    {
        lh=5;
        h1.SetActive(true);
        h2.SetActive(true);
        h3.SetActive(true);
        h4.SetActive(true);
        h5.SetActive(true);
    }
    void Update()
    {
        if(lh == 4){
            h5.SetActive(false);
        }
        if(lh == 3){
            h4.SetActive(false);
            h5.SetActive(false);
        }
        if(lh == 2){
            h4.SetActive(false);
            h5.SetActive(false);
            h3.SetActive(false);
        }
        if(lh == 1){
            h2.SetActive(false);
            h3.SetActive(false);
            h4.SetActive(false);
            h5.SetActive(false);
        }
        if(lh == 0){
            h1.SetActive(false);
            h2.SetActive(false);
            h3.SetActive(false);
            h4.SetActive(false);
            h5.SetActive(false);
            Application.LoadLevel(1);
        }
    }
    void OnCollisionEnter2D(Collision2D coll)
    {
        if (coll.gameObject.name == attacker)
        {
            lh--;
        }
    }
}
