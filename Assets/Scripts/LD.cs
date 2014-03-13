using UnityEngine;
using System.Collections;

public class LD : MonoBehaviour {

	public GameObject particlePlatform;

	void OnTriggerExit(Collider other){

		if (other.tag == "Platform") {
			Destroy (other.gameObject);

			//Instantiate(particlePlatform, other.gameObject.transform.position,Quaternion.identity);
		}
	
	}
}
