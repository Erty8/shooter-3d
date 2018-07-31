using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class temaslayokol : MonoBehaviour {
    public float sayac;
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag!="sınır") {
            Destroy(other.gameObject);
            
            sayac++;
            if (sayac == 2)
            {
                Destroy(gameObject);
                sayac = 0;
                

            }
        }
    }

}
