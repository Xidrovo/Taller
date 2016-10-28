using UnityEngine;
using System.Collections;

public class activateFloor : MonoBehaviour {

    public float blinkTime = 0;
    public float startBlink = 0;
    private bool isVisible = false;
    public bool begin = false;
    private bool looping = true;
	// Use this for initialization

	void Start () {
        if (begin)
        {
            InvokeRepeating("blinking", startBlink, blinkTime);
        }
	}
	
	// Update is called once per frame
	void Update () {
        if (looping)
        {
            if (begin == false)
            {
                begin = true;
                looping = false;
                Start();
            }
        }
	}

    private void blinking()
    {
        if (isVisible)
        {
            this.gameObject.SetActive(true);
        }
        else
            this.gameObject.SetActive(false);

    }
}
