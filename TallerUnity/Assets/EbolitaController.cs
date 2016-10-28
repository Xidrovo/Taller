using UnityEngine;
using System.Timers;
using System.Collections;

public class EbolitaController : MonoBehaviour {

    public static bool MoveDer = true, MoveIz = false;
    public float speedBolita =0.1f;
    private Animator anim;
    public GameObject escalera;
    // Use this for initialization
    void Start () {
        anim = this.GetComponent<Animator>();
        anim.SetBool("Move", true);
        Physics.IgnoreCollision(escalera.GetComponent<Collider>(), this.gameObject.GetComponent<Collider>());
    }
	
	// Update is called once per frame
	void FixedUpdate() {
        Movimiento();

    }

    public void Movimiento()
    {
        if (MoveDer)
        {
            this.transform.rotation = Quaternion.Euler(0, 0, 0);
            anim.SetBool("Move", true);
            transform.Translate(Vector2.left * speedBolita * Time.deltaTime);
        }
        else if (MoveIz)
        {
            this.transform.rotation = Quaternion.Euler(0, 180, 0);
            anim.SetBool("Move", true);
            transform.Translate(Vector2.right * speedBolita * Time.deltaTime);
        }
        else
        {
            anim.SetBool("Move", false);
        }
    }

}
