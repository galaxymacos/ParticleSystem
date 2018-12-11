using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sfx : MonoBehaviour {

	[SerializeField] private AudioClip[] sounds;

	private AudioSource audioS;
	// Use this for initialization
	void Start () {
		audioS = GetComponent<AudioSource>();
	}

	public void PlaySound() {
		int rand = Random.Range(0, sounds.Length);
		audioS.PlayOneShot(sounds[rand]);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
