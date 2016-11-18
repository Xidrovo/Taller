using UnityEngine;
using System.Timers;
using System.Collections;

public class EbolitaController : MonoBehaviour {

    public static bool MoveDer = true, MoveIz = false, idle=false;
    float speedBolita =0.5f;
    private Animator anim;
    // Use this for initialization
    void Start () {
        anim = this.GetComponent<Animator>();
        anim.SetBool("Move", true);
    }
	
	// Update is called once per frame
	void FixedUpdate() {
        Movimiento();
        //Physics2D.IgnoreLayerCollision(10,8);
    }

    public void Movimiento()
    {
        if(idle)
        {
            anim.SetBool("Move", false);
            return;
        }
        if (MoveIz)
        {
            transform.rotation = Quaternion.Euler(0, 180, 0);
            anim.SetBool("Move", true);
            transform.Translate(Vector2.left * -speedBolita * Time.deltaTime);
        }
        else if (MoveDer)
        {
            transform.rotation = Quaternion.Euler(0, 0, 0);
            anim.SetBool("Move", true);
            transform.Translate(Vector2.right * speedBolita * Time.deltaTime);
        }
        
    }

}
