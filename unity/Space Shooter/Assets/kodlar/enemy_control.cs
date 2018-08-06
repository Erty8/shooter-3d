using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy_control : MonoBehaviour {

    Rigidbody fizik;
    public float hız;

    void Start()
    {
        fizik = GetComponent<Rigidbody>();
        fizik.velocity = transform.forward * hız;



    }


    // Update is called once per frame
    void Update () {
		
	}
}
