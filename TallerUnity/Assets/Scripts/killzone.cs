using UnityEngine;
using System.Collections;

public class killzone : MonoBehaviour {

    public GameObject respawn;
	// Use this for initialization
	void Start () {
	
	}

    void OnCollisionEnter2D(Collision2D coll)
    {
        if (coll.gameObject.tag == "Player")
        {
            coll.transform.position = respawn.transform.position;
        }
    }
	// Update is called once per frame
	void Update () {
	
	}
}
