using UnityEngine;
using System.Collections;

public class FollowPlayer : MonoBehaviour {
	[SerializeField] private Transform player;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		Vector3 playerPosition = player.position;
		Vector3 v3 = new Vector3(playerPosition.x,transform.position.y,playerPosition.z);
		transform.position = v3;
	}
}
