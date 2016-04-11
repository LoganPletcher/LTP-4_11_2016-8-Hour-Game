using UnityEngine;
using System.Collections;

public class SpawningScript : MonoBehaviour {

    public GameObject Enemy;
    float GameLength;
    float TBP = 0;
    float delay = 1.0F;

    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

        GameLength += 1 * Time.deltaTime;
        delay = .001F;
        if ((GameLength - TBP) > (100 * Time.deltaTime))
        {
            TBP = GameLength;
            Instantiate(Enemy);
        }
    }
}
