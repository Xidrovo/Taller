using UnityEngine;
using System.Collections;

public class salto : MonoBehaviour {

    public static bool isGrounded = true;

    void OnTriggerEnter2D(Collider2D trigg)
    {
        if (trigg.gameObject.tag == "gnd")
        {
            isGrounded = true;
            Debug.Log("im in");
        }
    }

    void OnTriggerExit2D(Collider2D trigg)
    {
        if (trigg.gameObject.tag == "gnd")
        { 
            isGrounded = false;
            Debug.Log("im exit");
        }
    }

    // Update is called once per frame
    void Update () {
	
	}
}
