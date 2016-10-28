using UnityEngine;
using System.Collections;

public class salto : MonoBehaviour {

    public static bool isGrounded = true;

    void OnTriggerStay2D(Collider2D trigg)
    {
        if (trigg.gameObject.tag == "gnd")
        {
            isGrounded = true;
        }
    }

    void OnTriggerExit2D(Collider2D trigg)
    {
        if (trigg.gameObject.tag == "gnd")
        { 
            isGrounded = false;
        }
    }

    // Update is called once per frame
    void Update () {
	
	}
}
