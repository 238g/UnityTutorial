using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fruit : MonoBehaviour {

	public GameObject fruitSlicePrefab;
	public float startForce = 15f;

	Rigidbody2D rb;

	void Start () {
		rb = GetComponent<Rigidbody2D> ();
		rb.AddForce (transform.up * startForce, ForceMode2D.Impulse);
	}

	void OnTriggerEnter2D (Collider2D col) {
		if (col.tag == "Blade") {
			Vector2 direction = (col.transform.position - transform.position).normalized;

			Quaternion rotation = Quaternion.LookRotation (direction);

//			GameObject slicedFruit = Instantiate (fruitSlicePrefab, transform.position, rotation);
			GameObject slicedFruit = Instantiate (fruitSlicePrefab, transform.position, new Quaternion(rotation.x, rotation.y, 0.0f, 0.0f));

			Destroy (slicedFruit, 3f);
			Destroy (gameObject);
		}
	}
}
