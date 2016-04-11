using UnityEngine;
using System.Collections;

public class TargetingScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
    }
	
	// Update is called once per frame
	void Update () {
        if (!Cursor.visible)
        {
            Vector3 PreviousPos = this.gameObject.transform.position;
            this.gameObject.transform.position = new Vector3(PreviousPos.x + ((10.0F * Input.GetAxis("Mouse X")) * Time.deltaTime), PreviousPos.y + ((10.0F * Input.GetAxis("Mouse Y")) * Time.deltaTime));
        }
    }
}
