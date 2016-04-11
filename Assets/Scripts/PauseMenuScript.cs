using UnityEngine;
using System.Collections;

public class PauseMenuScript : MonoBehaviour {

    public bool Paused = false;
    //float Updates;
    //float TBP = 0;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        //Updates += 1 * Time.deltaTime;
        if (Input.GetKeyDown("p")/* && (Updates - TBP) > 1*/)
        {
            //TBP = Updates;
            PauseGame();
        }
	}

    // Function called upon press of the "P" key
    void PauseGame()
    {
        if (Cursor.visible)
        {
            Cursor.visible = false;
            Cursor.lockState = CursorLockMode.Locked;
        }
        else
        {
            Cursor.visible = true;
            Cursor.lockState = CursorLockMode.None;
        }
    }
}
