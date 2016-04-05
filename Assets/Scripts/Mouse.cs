using UnityEngine;
using System.Collections;

public class Mouse : MonoBehaviour {

	public Transform cat;



	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void FixedUpdate () {


		foreach (Mouse somePizza in GameManager.listOfPizzas) {

			Vector3 directionToCat = cat.position - transform.position;

			if (Vector3.Angle (transform.forward, directionToCat) < 90f) {

				Ray mouseRay = new Ray (transform.position, directionToCat);

				RaycastHit mouseRayHitInfo = new RaycastHit ();

				if (Physics.Raycast (mouseRay, out mouseRayHitInfo, 20f)) {
					if (mouseRayHitInfo.collider.tag == "cat") {

						Debug.DrawRay (mouseRay.origin, mouseRay.direction * 5f, Color.magenta);
						if (mouseRayHitInfo.distance <= 0.5f) {
							
							Destroy (somePizza.gameObject);
							OnDestroy ();

						} else {
							GetComponent<Rigidbody> ().AddForce (-directionToCat.normalized * 10f);

						}

					}


				}

			}

		}
	}


	void OnDestroy () {
	
		GameManager.listOfPizzas.Remove (this);
	
	}



}

