using UnityEngine;
using System.Collections;

public class pause : MonoBehaviour {

    public GameObject canvas;
    private bool pausa = false;
	// Use this for initialization
	void Start () {
        canvas.SetActive(false);
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.P))
            pausa = !pausa;
        if (pausa)
        {
            canvas.SetActive(true);
            Time.timeScale = 0;
        }
        else
        {
            canvas.SetActive(false);
            Time.timeScale = 1;
        }
	}
}
