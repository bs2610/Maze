using UnityEngine;
using System.Collections;

public class Fish : MonoBehaviour {
	//Serializefield exposes variable to inspector without making it public
	[SerializeField] float stoppingDisance = 1f;
	[SerializeField] float speed = 5f;
	public Vector3 destination;//where the fish are trying to go 

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		Debug.DrawLine (transform.position, destination, Color.magenta);

		float fishDistance = Vector3.Distance (destination, transform.position);

		if (fishDistance > stoppingDisance){

			transform.position += (destination - transform.position).normalized * speed *  Time.deltaTime;
			transform.LookAt (destination);

	

				

		}
	}
}
