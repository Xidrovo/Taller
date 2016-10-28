using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class PuntosDeVida : MonoBehaviour {

    public Image image;

    void OnCollisionEnter2D(Collision2D coll)
    {
        if (coll.gameObject.tag == "killerzone")
        {
            image.fillAmount = (image.fillAmount - 0.25f);
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
