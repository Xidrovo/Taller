using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class PuntosDeVida : MonoBehaviour {

    public Image image;
    public GameObject respawn;
    void OnCollisionEnter2D(Collision2D coll)
    {
        if (coll.gameObject.tag == "killerzone")
        {
            image.fillAmount = (image.fillAmount - 0.25f);
        }
        else if (coll.gameObject.CompareTag("enemies"))
        {
            image.fillAmount = (image.fillAmount - 0.10f);
            this.transform.position = respawn.transform.position;
        }
    }
	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
        if (image.fillAmount <= 0.01)
            Application.LoadLevel("GameOver");
        
	}
}
