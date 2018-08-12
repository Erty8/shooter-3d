using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy_control : MonoBehaviour {

    Rigidbody fizik;
    public float hız;
    float ateszamanı = 0;
    public GameObject mermi;
    public Transform MermiNereden;
    public float atessuresi;
    

    void Start()
    {
        fizik = GetComponent<Rigidbody>();
        fizik.velocity = transform.forward * hız;
        



    }


    
    void Update () {

        if ( Time.time > ateszamanı)
        {
            ateszamanı = Time.time + atessuresi;
            Instantiate(mermi, MermiNereden.position, Quaternion.Euler(0,180,0));
        }
    }
}
