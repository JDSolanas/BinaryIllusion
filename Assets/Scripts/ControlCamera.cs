using UnityEngine;
using System.Collections;

public class ControlCamera : MonoBehaviour {

	public GameObject Player;
	// Update is called once per frame
	void Update () {
		//All that is here, it begins one time for frame.
		transform.position = new Vector3(Player.transform.position.x + 5,transform.position.y, transform.position.z);
	}
}
