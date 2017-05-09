using UnityEngine;
using System.Collections;

public class Bala : MonoBehaviour {

	public GameObject arma;
	public Transform puntoDisaparo;
	private float acceleracion = 30; 

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		if (Input.GetButtonDown ("Fire1")) 
		
		{
			GameObject bala = (GameObject) Instantiate (arma, puntoDisaparo.position, Camera.main.transform.rotation);
			bala.GetComponent<Rigidbody>().AddRelativeForce(new Vector3(0,0, acceleracion), ForceMode.VelocityChange);
		}
	
	}
}

