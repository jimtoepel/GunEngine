using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

	public float speed = 5.0F;
	private Vector3 moveDirection = Vector3.zero;

	// Use this for initialization
	void Start () {

		StartCoroutine (Spawn());

	}
	
	// Update is called once per frame
	void FixedUpdate () {
	
		CharacterController controller = GetComponent<CharacterController> ();
//		double tempHoriz = -1.0 * Input.GetAxis ("Horizontal");
		moveDirection = new Vector3 (-Input.GetAxis ("Horizontal"), 0, Input.GetAxis ("Vertical"));
		moveDirection = transform.TransformDirection (moveDirection);
		moveDirection *= speed;

		controller.Move (moveDirection * Time.deltaTime);
	}

	IEnumerator Spawn() {
		float originalSpeed = speed;
		Debug.Log("Locking in Place");
		speed = 0;
        yield return new WaitForSeconds(5);
		Debug.Log("Time to Dance");
		speed = originalSpeed;
	}

	IEnumerator Dead() {
		speed = 0;
		Debug.Log("Oh noes!");
		yield return new WaitForSeconds(5);
	}

}
