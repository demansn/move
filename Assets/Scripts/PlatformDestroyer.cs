using UnityEngine;
using System.Collections;

public class PlatformDestroyer : MonoBehaviour {

	public float lifetime;

	void Start () {

		StartDestroy ();

		Destroy (gameObject, lifetime);
	}

	void StartDestroy(){

		Rigidbody[] rigidbodys = gameObject.GetComponentsInChildren<Rigidbody>();

		foreach (Rigidbody rg in rigidbodys) {
			rg.angularVelocity = Random.insideUnitSphere * 5;
			Debug.Log("dfs");
		}
	}

}
