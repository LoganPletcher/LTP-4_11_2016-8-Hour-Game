using UnityEngine;
using System.Collections;

public class BulletScript : MonoBehaviour {

    public GameObject Player;
    public GameObject Parent;

	// Use this for initialization
	void Start () {
        transform.position = Player.transform.position;
        transform.rotation = Player.transform.rotation;
	}
	
	// Update is called once per frame
	void Update () {
        transform.Translate(Vector3.up * (5 * Time.deltaTime));
        OutsideScreen();
	}

    void OutsideScreen()
    {
        if (Parent.transform.name == "Capsule(Clone)")
        {
            if (transform.position.x > 10 || transform.position.x < -10)
                Destroy(Parent);
            if (transform.position.y > 8 || transform.position.y < -8)
                Destroy(Parent);
            Player.GetComponent<ShootingScript>().ActiveBullets--;
        }
    }

    void OnTriggerEnter (Collider enemy)
    {
        if (enemy.gameObject.name == "Cube(Clone)")
            enemy.gameObject.GetComponent<EnemyScript>().m_HP--;
    }

}
