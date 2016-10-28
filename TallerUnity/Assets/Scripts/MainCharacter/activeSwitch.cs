using UnityEngine;
using System.Collections;

public class activeSwitch : MonoBehaviour {

    GameObject activador;

    void OnTriggerStay2D(Collider2D trigg)
    {
        if (trigg.tag == "lever" && Input.GetKey(KeyCode.A)) {
            activador = trigg.gameObject;
            activador.GetComponent<switchProperty>().activate();
        }
    }
	// Use this for initialization
	void Start () {
	    
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
