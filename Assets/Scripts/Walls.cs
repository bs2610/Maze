using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
public class Walls : MonoBehaviour {

	private int counter = 0;
	public Transform floorPrefab;
	public Transform pathmakerPrefab;


	void Update () {

		float randRange = Random.Range (0.0f, 1.0f); 
		int colorRange = Random.Range (0,2);

		if (counter < 75) {
			if (randRange < 0.05) {
				transform.position += transform.forward * 6f;
			}else if (randRange < 0.5f) {
				transform.Rotate (0, 90, 0);
				transform.position -= transform.forward * 6f;
			}else if (randRange > 0.25f && randRange < 5.0f){
				transform.Rotate (0, -90, 0);
				transform.position = transform.forward * 6f;
			} else if (randRange > 0.75f){
				transform.position = -transform.forward * 6f;
				Instantiate (pathmakerPrefab, this.transform.position, this.transform.rotation); 
			}

			Transform thingImade = (Transform)Instantiate (floorPrefab, this.transform.position, this.transform.rotation);

			if (thingImade.position.y > 21f) {

				//Transform newOne = (Transform)Instantiate (pathmakerPrefab, this.transform.position, this.transform.rotation);

				thingImade.GetComponent<Renderer> ().material.color = new Color (0.95f, 0.53f, 0.68f);
				if (colorRange == 0) {
					thingImade.GetComponent<Renderer> ().material.color = new Color (Random.Range(0.40f, 0.80f),randRange,randRange );
				}
		
				transform.position += transform.forward; //* 2f;
				thingImade.localScale = Random.value * Vector3.one * 4f;


				if (thingImade.position.x > 50f) {
					transform.position += -transform.right;
				}else if (thingImade.position.x < -50f) {
					transform.position += -transform.right;
				}

				if (thingImade.position.z > 50f) {
					transform.position += -transform.right;
				}else if (thingImade.position.z < -50f) {
					transform.position += -transform.right;
				}

				if (thingImade.position.y > 75f) {
					transform.position += -transform.up * 10f;
					//transform.Rotate (Random.Range (-90, 90), 0, 0);
				}
			}


			transform.position += transform.forward;

			counter++;
		} else {
			Destroy(this);
		}

		if (Input.GetKey (KeyCode.R)) {
			SceneManager.LoadScene ("y");

		}
	}


}
