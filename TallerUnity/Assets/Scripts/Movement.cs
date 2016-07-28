using UnityEngine;
using System.Collections;

public class Movement : MonoBehaviour {

	public float speed = 5f;
	public float impulso = 5f;

	public Rigidbody2D cuerpo;
	// Use this for initialization
	void Start () {
//		cuerpo = this.GetComponent<Rigidbody2D>();

	}
	
	// Update is called once per frame
	void Update () {
		movimientos ();
		salto ();
	}

	private void movimientos()
	{
		if (Input.GetKey (KeyCode.RightArrow)) 
		{
			//transform.Translate(speed * Time.deltaTime,0,0);
			transform.Translate(Vector3.right * speed * Time.deltaTime);
		}	

		if (Input.GetKey (KeyCode.LeftArrow)) 
		{
			transform.Translate(Vector3.left * speed * Time.deltaTime);
		}	
	}

	private void salto()
	{
		if (Input.GetKey (KeyCode.UpArrow))
		{
			cuerpo.AddForce(Vector2.up, ForceMode2D.Impulse);
		}
	}
}
