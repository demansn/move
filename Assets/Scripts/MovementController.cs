using UnityEngine;
using System.Collections;

public class MovementController : MonoBehaviour
{

		public float speed;
		public float horizontalSpeed;
		public GUIText debugText;

		void Start ()
		{
	

				Input.gyro.enabled = true;
				rigidbody.velocity = Vector3.forward * speed;

		}

		void FixedUpdate ()
		{	

				//rigidbody.velocity = Vector3.forward * speed;
			

				if (Input.gyro.enabled) {

						Debug.Log ("gyro enabled");
						debugText.text = "Input.gyro.attitude.y = " + Input.gyro.attitude.y;

						if (Input.gyro.attitude.y > 0.02f || Input.gyro.attitude.y < -0.02f) {

								rigidbody.AddForce (new Vector3 ((Input.gyro.attitude.y * 10) * horizontalSpeed, 0, speed), ForceMode.Acceleration);
								
						} else {
								rigidbody.velocity = new Vector3 (0, 0, speed);
						}

				} else {

						debugText.text = "Input.GetAxis (Horizontal) = " + Input.GetAxis ("Horizontal");

						rigidbody.AddForce (Vector3.right * Input.GetAxis ("Horizontal"), ForceMode.Acceleration);

				}

				

				

		}
}
