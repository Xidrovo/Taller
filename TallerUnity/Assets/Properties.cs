using UnityEngine;
using System.Collections;

public class Properties : MonoBehaviour {
    public float inicio;
        // Use this for initialization
	void Start () {
        inicio = Time.time;
        Physics2D.IgnoreLayerCollision(10,12, true);
        Physics2D.IgnoreLayerCollision(0, 12, true);
        Physics2D.IgnoreLayerCollision(11, 12, true);
    }
	
	// Update is called once per frame
	void Update () {
        if (Time.time - inicio >= 2)
            Destroy(this.gameObject);
	}

    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Player") || other.gameObject.tag == "killerzone")
        {
            Destroy(this.gameObject);
        }
    }
}
