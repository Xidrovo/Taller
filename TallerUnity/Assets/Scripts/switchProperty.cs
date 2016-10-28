using UnityEngine;
using System.Collections;

public class switchProperty : MonoBehaviour {

    private Animator anim;
    private bool activar = false;
	// Use this for initialization
	void Start () {
        anim = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void activate()
    {
        activar = true;
        anim.SetBool("switched",true);
    }
    public bool getActivate()
    {
        return activar;
    }
}
