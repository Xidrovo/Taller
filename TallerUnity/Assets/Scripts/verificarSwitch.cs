using UnityEngine;
using System.Collections;

public class verificarSwitch : MonoBehaviour {

    public switchProperty switchActivator;
    public GameObject piso;
    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        if (switchActivator.getActivate())
        {
            piso.gameObject.SetActive(true);
        }
	}
}
