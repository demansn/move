using UnityEngine;
using System.Collections;

public class LD : MonoBehaviour {

	// Use this for initialization

	public GameObject particlePlatform;
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerExit(Collider other){
		Debug.Log ("sdfs");
		Destroy (other);

		//Instantiate(particlePlatform, other.gameObject.transform.position,Quaternion.identity);
	}
}
