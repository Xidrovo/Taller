using UnityEngine;
using System.Collections;

public class CaminaIz : MonoBehaviour {
    private float inicio = 0;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        if (Time.time-inicio==1 && inicio != 0)
        {
            EbolitaController.MoveIz = true;
        }
	}

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("gnd") && inicio == 0)
        {
            inicio = Time.time;
            EbolitaController.MoveDer = false;
            this.gameObject.GetComponent<Collider2D>().enabled = false;
        }
    }

    void OnTriggerExit2D(Collider2D other)
    {
        this.gameObject.GetComponent<Collider2D>().enabled = true;
    }
}
