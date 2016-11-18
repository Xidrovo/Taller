using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class FrankMovement : MonoBehaviour {

    private int speed=2;
    public GameObject player, balas;
    private GameObject villano,nueva;
    private Quaternion rotacion;
    public bool disparar = false;
    public float inicio = 0, posX = 0, playerX = 0;
    Animator anim;
	// Use this for initialization
	void Start () {
        anim = this.GetComponent<Animator>();
        villano = this.gameObject;
        rotacion = Quaternion.Euler(0,0,0);
	}
	
	// Update is called once per frame
	void FixedUpdate () {
        Disparo();
	}

    void Disparo()
    {
        float difTiempo =(Time.time - inicio);
        if (disparar && inicio!=0 && difTiempo>=1)
        {
            inicio = Time.time;
            nueva = (GameObject)Instantiate(balas, new Vector3(villano.transform.position.x, villano.transform.position.y, 0), rotacion);
            nueva.GetComponent<Rigidbody2D>().gravityScale = 0;
            nueva.GetComponent<Rigidbody2D>().AddRelativeForce((new Vector2(0, -4f)), ForceMode2D.Impulse);

            nueva = (GameObject)Instantiate(balas, new Vector3(villano.transform.position.x, villano.transform.position.y, 0), Quaternion.Euler(0, 0, 45));
            nueva.GetComponent<Rigidbody2D>().gravityScale = 0;
            nueva.GetComponent<Rigidbody2D>().AddRelativeForce((new Vector2(0, -4f)), ForceMode2D.Impulse);

            nueva = (GameObject)Instantiate(balas, new Vector3(villano.transform.position.x, villano.transform.position.y, 0), Quaternion.Euler(0, 0, -45));
            nueva.GetComponent<Rigidbody2D>().gravityScale = 0;
            nueva.GetComponent<Rigidbody2D>().AddRelativeForce((new Vector2(0, -4f)), ForceMode2D.Impulse);
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        inicio = Time.time;
        if (other.CompareTag("Player"))
        {
            anim.SetBool("iddle", false);
            posX = this.gameObject.transform.position.x;
            playerX = player.transform.position.x;
            float dif = playerX - posX;
            anim.SetInteger("DisDer", (int)dif);
            disparar = true;
        }
    }

    void OnTriggerStay2D(Collider2D other)
    {
        posX = this.gameObject.transform.position.x;
        playerX = player.transform.position.x;
        float dif = playerX - posX;
        if (other.CompareTag("Player") && dif != 0)
        {
            anim.SetBool("iddle", false);
            disparar = true;
            if (dif > 0)
            {
                this.gameObject.transform.Translate(Vector2.left * -speed * Time.deltaTime);
            }
            else
            {
                this.gameObject.transform.Translate(Vector2.left * speed * Time.deltaTime);
            }
        }
    }

    void OnTriggerExit2D(Collider2D other)
    {
        disparar = false;
        anim.SetInteger("DisDer", 0);
        anim.SetBool("iddle", true);
    }
}
