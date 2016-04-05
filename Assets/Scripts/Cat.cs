using UnityEngine;
using System.Collections;

public class Cat : MonoBehaviour {


	public Transform mouse;


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void FixedUpdate () {




		foreach (Cat thisMouse in GameManager.listOfMice) {

			Vector3 directionToMouse = mouse.position - transform.position;

			if (Vector3.Angle (transform.forward, directionToMouse) < 90f) {
		
				Ray catRay = new Ray (transform.position, directionToMouse);

				RaycastHit catRayHitInfo = new RaycastHit ();

				if (Physics.Raycast (catRay, out catRayHitInfo, 50f)) {
					if (catRayHitInfo.collider.tag == "mouse") {
				
						Debug.DrawRay (catRay.origin, catRay.direction * 5f, Color.magenta);
						if (catRayHitInfo.distance <= 0.5f) {
							
							foreach (Mouse somePizza in GameManager.listOfPizzas) {
							OnDestroy ();

							Destroy (somePizza.gameObject);
							}
						} else {
							GetComponent<Rigidbody> ().AddForce (directionToMouse.normalized * 300f);

						}
				
					}

			
				}
		
			}

		}


	}


	void OnDestroy () {

		Destroy (this.gameObject);
	}

}
