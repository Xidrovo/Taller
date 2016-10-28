using UnityEngine;
using System.Collections;

public class CaminaDer : MonoBehaviour {
    private float inicio = 0;
    // Use this for initialization
    void Start () {
	}
	
	// Update is called once per frame
	void Update () {
        Debug.Log(Time.time - inicio);
        if (Time.time - inicio == 1 && inicio!=0)
        {
            EbolitaController.MoveDer = true;
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("gnd") && inicio==0)
        {
            inicio = Time.time;
            EbolitaController.MoveIz = false;
            this.gameObject.GetComponent<Collider2D>().enabled = false;
        }
    }

    void OnTriggerExit2D(Collider2D other)
    {
        this.gameObject.GetComponent<Collider2D>().enabled = true;
    }
}
