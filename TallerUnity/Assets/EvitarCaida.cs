using UnityEngine;
using System.Collections;

public class EvitarCaida : MonoBehaviour {
    private float inicio = 0;
    public static bool seguro = true;
    // Use this for initialization
    void Start() {

    }

    // Update is called once per frame
    void FixedUpdate() {
        
    }

    void OnTriggerExit2D(Collider2D other)
    {
        seguro = false;
        if (inicio == 0)
        {
            inicio = Time.time;
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log(inicio);
        Debug.Log(seguro);
        if (inicio > 0 && !seguro)
        {
            Debug.Log("entre");
            seguro = true;
            EbolitaController.idle = true;
            Cambio();
        }
    }

    void OnTriggerStay2D(Collider2D other)
    {
        seguro = true;
    }


    public void Cambio()
    {
        if (EbolitaController.idle)
        {
            Debug.Log("cambio");
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
