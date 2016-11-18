using UnityEngine;
using System.Collections;

public class CaminaIz : MonoBehaviour {
    public float inicio = 0;
    // Use this for initialization
    void Start () {
    }
	
	// Update is called once per frame
	void FixedUpdate () {
        if (inicio != 0 )
        {
            Cambio();
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("gnd") && inicio == 0)
        {
            inicio = Time.time;
            EbolitaController.idle = true;
        }
    }

    public void Cambio()
    {
        if (Time.time - inicio >= 0.45f && EbolitaController.idle)
        {
            EbolitaController.idle = false;
            inicio = 0;
            if (EbolitaController.MoveDer)
            {
                EbolitaController.MoveIz = true;
                EbolitaController.MoveDer = false;
            }
            else
            {
                EbolitaController.MoveIz = false;
                EbolitaController.MoveDer = true;
            }
        }
    }
}
