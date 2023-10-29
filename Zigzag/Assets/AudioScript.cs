using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.N3DS;

public class AudioScript : MonoBehaviour {

	public AudioSource ClickSource;
	public AudioSource CoinSource;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetMouseButtonDown(0) || GamePad.GetButtonTrigger(N3dsButton.A)){
            ClickSource.Play();
        }
	}

}
