using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class temaslayokol : MonoBehaviour {
    public float sayac;
	public GameObject patlama;
	public GameObject player_patlama;
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag!="sınır") {
            Destroy(other.gameObject);
            
            sayac++;
            if (sayac == 2)
            {
                Destroy(gameObject);
				Instantiate (patlama,transform.position,transform.rotation);
                sayac = 0;
                

            }

        }
        if (other.tag == "Player")
        {
            Instantiate(player_patlama, other.transform.position, other.transform.rotation);
        }
    }

}
