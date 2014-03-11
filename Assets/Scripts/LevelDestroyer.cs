using UnityEngine;
using System.Collections;

public class LevelDestroyer : MonoBehaviour {

	void OnTriggerExit(Collider other){
		Destroy (other);
		Debug.Log (other.name + "  " + other.transform.position);
	}
}
