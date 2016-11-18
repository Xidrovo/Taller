using UnityEngine;
using System.Collections;

public class CaminaDer : MonoBehaviour {
    private float inicio = 0;
    // Use this for initialization
    void Start () {
        if (!EbolitaController.MoveIz)
        {
            this.gameObject.GetComponent<Collider2D>().enabled = false;
        }
    }
	
	// Update is called once per frame
	void FixedUpdate() {
        if (EbolitaController.MoveIz)
        {
            inicio = 0;
            this.gameObject.GetComponent<Collider2D>().enabled = true;
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("gnd") && inicio==0)
        {
            inicio = Time.time;
            EbolitaController.MoveIz = false;
            EbolitaController.MoveDer = true;
            this.gameObject.GetComponent<Collider2D>().enabled = false;
        }
    }
    
}
