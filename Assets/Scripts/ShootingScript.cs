using UnityEngine;
using System.Collections;

public class ShootingScript : MonoBehaviour {

    private bool shooting;
    public float Updates;
    float TBP = 0;
    public int ActiveBullets;
    public GameObject Bullet;

    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetMouseButtonDown(0))
            shooting = true;
        if (Input.GetMouseButtonUp(0))
            shooting = false;
        Updates += 1 * Time.deltaTime;
        if (!Cursor.visible)
        {
            if (shooting && (Updates - TBP) > (9 * Time.deltaTime))
            {
                TBP = Updates;
                SpawnBullet();
            }
        }
        
    }

    void SpawnBullet()
    {
        ActiveBullets++;
        Instantiate(Bullet);
    }
}
