using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy_yokol : MonoBehaviour {


    float sayac;
    public GameObject patlama;
    public GameObject player_patlama;
    GameObject oyunkontrol;
    oyunkontrol kontrol;

    private void Start()
    {
        oyunkontrol = GameObject.FindGameObjectWithTag("oyunkontrol");
        kontrol = oyunkontrol.GetComponent<oyunkontrol>();

    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag != "sınır")
        {
            Destroy(other.gameObject);

            sayac++;
            if (sayac == 2)
            {
                Destroy(gameObject);
                Instantiate(patlama, transform.position, transform.rotation);
                sayac = 0;
                kontrol.ScoreArttır(20);

            }

        }
        if (other.tag == "Player")
        {
            Instantiate(player_patlama, other.transform.position, other.transform.rotation);
            kontrol.oyunbitti();
        }
    }

}


