using UnityEngine;
using System.Collections;

public class camera : MonoBehaviour {

    public GameObject seguir;
    private Vector3 posición;
    // Use this for initialization
	void Start () {
    }
	
	// Update is called once per frame
	void Update () {
        this.transform.position = new Vector3(seguir.transform.position.x, seguir.transform.position.y,-10);
    }
}
