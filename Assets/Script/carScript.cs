using UnityEngine;
using System.Collections;

public class carScript : MonoBehaviour {

	public float carSpeed;
	public float maxPos = 7.3f;
	Vector3 position;
	public uiManager ui;

	void Awake(){

	}

	void Start () {
		// ui = GetComponent<uiManager> ();
		position = transform.position;
	}
	
	// Update is called once per frame
	void Update () {
		position.x += Input.GetAxis ("Horizontal") * carSpeed * Time.deltaTime;

		position.x = Mathf.Clamp (position.x, -7.3f, 7.3f);

		transform.position = position;
	}

	void OnCollisionEnter2D(Collision2D col) {
		if (col.gameObject.tag == "EnemyCar") {
			Destroy (gameObject);
			ui.gameOverActivated();
		}
	}
}
