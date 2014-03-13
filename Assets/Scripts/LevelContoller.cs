using UnityEngine;
using System.Collections;

public class LevelContoller : MonoBehaviour {

	public GameObject platform;
	public GameObject gameArea;
	public GameObject boundary;
	private float platformScaleZ;
	private float lastPositionZ;

	void Start () {


		platformScaleZ = platform.transform.GetChild (1).transform.localScale.z;
		float z = 0;
		float maxZ = transform.position.z;

		while (z < maxZ) {
			CreatePlatform(z);
			z += platformScaleZ;

		}

		lastPositionZ = z;

	}
	

	void CreatePlatform (float z) {

		Vector3 position = new Vector3 (0, 0, z);

		Instantiate (platform, position, Quaternion.identity);	 
	}

	void FixedUpdate(){

	}

	void OnTriggerExit(Collider other){

		if (other.tag == "Platform") {

			CreatePlatform (other.transform.position.z + platformScaleZ);

		}

	}



}
