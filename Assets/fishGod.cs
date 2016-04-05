using UnityEngine;
using System.Collections;

using System.Collections.Generic;//to make lists

public class fishGod : MonoBehaviour {
	
	public Fish fishPrefab;
	//public Vector3 destination;
	List<Fish>listOffFish = new List<Fish>();

	// this will create and command fish
	void Start () {
		
		//int counter = 0;
		while(listOffFish.Count < 200){
		
			Fish newFish = (Fish)Instantiate (fishPrefab, Random.insideUnitSphere *100f, Random.rotation);
			listOffFish.Add (newFish);//add the new fish to ur list of fish
			//counter ++;
		}


	
	}
	
	// Update is called once per frame
//	void Update () {
//
//			if (Input.GetKeyDown (KeyCode.Space)){
//				foreach (Fish Kanye in listOffFish) {
//				Kanye.destination = Random.insideUnitSphere * 10f;
//			}
//		}
//
//
//		Ray fishRay = Camera.main.ScreenPointToRay (Input.mousePosition);
//		RaycastHit  fishRayHitInfo = new RaycastHit();
//
//		if (Input.GetMouseButtonDown(0)) && (Physics.Raycast(fishRay, out fishRayHitInfo, 1000f){
//		}
//
//		if () {
//
//			foreach (Fish Kanye in listOffFish) {
//				Kanye.transform.position = Random.insideUnitSphere;
//			}
//		
//		}
//
//	}
}
