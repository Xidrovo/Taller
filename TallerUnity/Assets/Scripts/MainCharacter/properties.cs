using UnityEngine;
using System.Collections;

public class properties : MonoBehaviour {
    Physics2D prueba;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
        Physics2D.IgnoreLayerCollision(9,8,true);
    }
}
