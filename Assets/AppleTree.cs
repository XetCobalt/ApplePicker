using UnityEngine;
using System.Collections;

public class AppleTree : MonoBehaviour {

	//prefab for instantiating apples
	public GameObject applePrefab;

	//speed at which the AppleTree moves in m/s
	public float speed = 10f;

	//distance where AppleTree turns around
	public float leftAndRightEdge = 10f;

	//chance that the AppleTree will change directions
	public float chanceToChangeDirections = 0.1f;

	//rate at which apples will be instantiated
	public float secondsBetweenAppleDrops = 1f;

	// Use this for initialization
	void Start () {
		//dropping apples every second
		InvokeRepeating ("DropApple", 2f, secondsBetweenAppleDrops);
	}

	void DropApple(){
		GameObject apple = Instantiate (applePrefab) as GameObject;
		apple.transform.position = transform.position;
	}
	
	// Update is called once per frame
	void Update () {
		//basic movement
		Vector3 pos = transform.position;
		pos.x += speed * Time.deltaTime;
		transform.position = pos;
		//changine direction
		if (pos.x < -leftAndRightEdge) {
			speed = Mathf.Abs (speed); //move right
		} else if (pos.x > leftAndRightEdge) {
			speed = -Mathf.Abs (speed); //move left
		}
	}

	void FixedUpdate(){
		//changing direction randomly
		if (Random.value < chanceToChangeDirections) {
			speed *= -1; //change directions
		}
	}
}
