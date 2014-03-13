using UnityEngine;
using System.Collections;

public class LevelContoller : MonoBehaviour {

	public GameObject platform;
	public GameObject gameArea;
	private float platformScaleZ;
	private float lastPositionZ;

	void Start () {


		platformScaleZ = platform.transform.GetChild (1).transform.localScale.z;
		float z = transform.position.z - gameArea.transform.localScale.z;
		float maxZ = z + gameArea.transform.localScale.z + transform.localScale.z;

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
