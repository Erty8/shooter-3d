using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class player_control : MonoBehaviour {

    Rigidbody fizik;
    float horizontal = 0;
    float vertical = 0;
    Vector3 vec;
    public float karakterhiz;
    public float minX;
    public float maxX;
    public float minZ;
    public float maxZ;
    public float egim;
    float ateszamanı = 0;
    public float atessuresi ;
    public GameObject mermi;
    public Transform MermiNereden;
    public GameObject patlama;
    public Text health;
    int sayac = 0;
    int can = 3;
	void Start () {
        fizik = GetComponent<Rigidbody>();
        health.text = "health = 3";
        

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "mermi") {
           Destroy(other.gameObject);
           sayac++;
           health.text = "health= " + (can - sayac);
           
           if (sayac == 3)
            {
                Destroy(gameObject);
                Instantiate(patlama, transform.position, transform.rotation);
            }
        }
    }
    void Update()
    {
        if (Input.GetButton("Fire1") && Time.time>ateszamanı)
        {
            ateszamanı = Time.time + atessuresi;
            Instantiate(mermi, MermiNereden.position, Quaternion.identity);
        }
    }

    void FixedUpdate () {
        horizontal = Input.GetAxis("Horizontal");
        vertical = Input.GetAxis("Vertical");

        vec = new Vector3(horizontal, 0, vertical);

        fizik.velocity = vec*karakterhiz;
        fizik.position = new Vector3(Mathf.Clamp(fizik.position.x, minX, maxX), 0.0f, Mathf.Clamp(fizik.position.z, minZ, maxZ));
        fizik.rotation = Quaternion.Euler(0, 0, fizik.velocity.x*egim);
		
	}
}
