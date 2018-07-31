using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sınır_kod : MonoBehaviour {

	void OnTriggerExit(Collider col)
    {
        Destroy(col.gameObject); 
    }
}
