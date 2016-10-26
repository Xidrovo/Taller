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
    void FixedUpdate () {
		movimientos ();
		jump ();
	}

	private void movimientos()
	{
		if (Input.GetKey (KeyCode.RightArrow)) 
		{
			//transform.Translate(speed * Time.deltaTime,0,0);
			transform.Translate(Vector3.right * -speed * Time.deltaTime);
            this.transform.rotation = Quaternion.Euler(0, 180, 0);
        }	

		if (Input.GetKey (KeyCode.LeftArrow)) 
		{
			transform.Translate(Vector3.left * speed * Time.deltaTime);
            this.transform.rotation = Quaternion.Euler(0, 0, 0);
        }	
	}

	private void jump()
	{
		if (Input.GetKey (KeyCode.UpArrow) && salto.isGrounded)
		{
            cuerpo.velocity = new Vector2(0,impulso);
        }
	}
}
