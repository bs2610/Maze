using UnityEngine;
using System.Collections;

using System.Collections.Generic;

public class GameManager : MonoBehaviour {

	public static List<Cat>listOfMice = new List<Cat> ();
	public static List<Mouse>listOfPizzas = new List<Mouse> ();

	public Mouse pizzaPrefab;
	public Cat mousePrefab;

	// Use this for initialization
	void Start () {

		GameManager.listOfMice.Clear ();
		GameManager.listOfPizzas.Clear ();
	}




	// Update is called once per frame
	void Update () {

		Ray mouseRay = Camera.main.ScreenPointToRay (Input.mousePosition);

		RaycastHit mouseRayHit = new RaycastHit ();




		if (Physics.Raycast (mouseRay, out mouseRayHit, 1000f)){

		if (Input.GetMouseButtonDown (1)) {

			while (listOfPizzas.Count <= 2f) {
				

				Mouse newPizza =  (Mouse)Instantiate (pizzaPrefab, mouseRayHit.point , Quaternion.identity);
				listOfPizzas.Add (newPizza);


			}
					

		}
			

		if (Input.GetMouseButtonDown (0)) {

			while (listOfMice.Count <= 50f) {


				Cat newMouse =  (Cat)Instantiate (mousePrefab, mouseRayHit.point , Quaternion.identity);
				listOfMice.Add (newMouse);


			}



		}


		}

	}
}
