using UnityEngine;
using System.Collections;

public class CoinController : MonoBehaviour {

	public float rotateSpeed = 1;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		transform.Rotate (Vector3.up * rotateSpeed * Time.deltaTime, Space.World);
	}
}
