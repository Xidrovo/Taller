  using UnityEngine;
using System.Collections;

public class Movement : MonoBehaviour {

	public float speed = 5f;
	public float impulso = 5f;

	public Rigidbody2D cuerpo;
    private bool canClimb;
    private float defaultGravity;
    // Use this for initialization

    void OnTriggerStay2D(Collider2D trigg)
    {
        if (trigg.tag == "ladder")
        {
            canClimb = true;
            cuerpo.gravityScale = 0;
        }
    }
    void OnTriggerExit2D(Collider2D trigg)
    {
        if (trigg.tag == "ladder")
        {
            canClimb = false;
            cuerpo.gravityScale = defaultGravity;
        }
    }

    void Start () {
        defaultGravity = cuerpo.gravityScale;
	}

    // Update is called once per frame
    void FixedUpdate () {
		movimientos ();
		jump ();
        climb();
	}

    private void climb()
    {
        if (canClimb && Input.GetKeyDown(KeyCode.UpArrow))
        {
            cuerpo.velocity = new Vector2(0, impulso/4);
        }
        if (canClimb && Input.GetKeyDown(KeyCode.DownArrow))
        {
            cuerpo.velocity = new Vector2(0, -impulso/4);
        }
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
		if (Input.GetKey (KeyCode.Space) && salto.isGrounded)
		{
            cuerpo.velocity = new Vector2(0,impulso);
        }
	}
}
