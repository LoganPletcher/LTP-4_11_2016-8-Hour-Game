using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class PlayerScript : MonoBehaviour {

    public int m_Score;
    public GameObject Target;
    private bool left;
    private bool right;
    public Text SCORE;


    // Use this for initialization
    void Start () {
	}
	
	// Update is called once per frame
	void Update () {
        Vector3 PreviousPos = transform.position;
        Vector3 targetDir = Target.transform.position - this.transform.position;
        if(Target.transform.position.x > (PreviousPos.x + .02F))
            transform.rotation = Quaternion.AngleAxis(Vector3.Angle(targetDir * Time.deltaTime,Vector3.up), Vector3.back);
        else if(Target.transform.position.x < (PreviousPos.x - .02F))
            transform.rotation = Quaternion.AngleAxis(Vector3.Angle(targetDir * Time.deltaTime, Vector3.up), Vector3.forward);
        else
            transform.rotation = Quaternion.AngleAxis(Vector3.Angle(targetDir * Time.deltaTime, Vector3.up), Vector3.zero);

        if (Input.GetKeyDown("a"))
            left = true;
        if (Input.GetKeyUp("a"))
            left = false;
        if (left)
            transform.position = new Vector3(PreviousPos.x - (10 * Time.deltaTime), PreviousPos.y);
        if (Input.GetKeyDown("d"))
            right = true;
        if (Input.GetKeyUp("d"))
            right = false;
        if (right)
            transform.position = new Vector3(PreviousPos.x + (10 * Time.deltaTime), PreviousPos.y);
        SCORE.text = "Score: " + m_Score;
    }
}
