using UnityEngine;
using System.Collections;

public class EnemyScript : MonoBehaviour {

    public int m_HP;
    public GameObject Player;
    public GameObject Parent;
    float startX;
    bool moveRight;

	// Use this for initialization
	void Start () {
        m_HP = (int)(Player.GetComponent<ShootingScript>().Updates/10) + 5;
        transform.position = new Vector3(Random.Range(-10, 10), 5.5F, 0);
        startX = transform.position.x;
	}
	
	// Update is called once per frame
	void Update () {
        if (name == "Cube(Clone)")
        {
            Vector3 PrevPos = transform.position;
            if (transform.position.x >= (startX + 2))
                moveRight = false;
            if (transform.position.x <= (startX - 2))
                moveRight = true;
            if(moveRight)
                transform.position = new Vector3(PrevPos.x + (1 * Time.deltaTime), PrevPos.y - (5 * Time.deltaTime), 0);
            else
                transform.position = new Vector3(PrevPos.x - (1 * Time.deltaTime), PrevPos.y - (5 * Time.deltaTime), 0);

            Death();
        }
	}

    void Death()
    {
        if (m_HP <= 0)
        {
            Player.GetComponent<PlayerScript>().m_Score++;
            Destroy(Parent);
        }
    }

    void onTriggerEnter(Collider collision)
    {
        Debug.Log(collision.gameObject.name);
        if (collision.gameObject.name == "Player")
            Destroy(collision);
        if (collision.gameObject.name == "Capsule(Clone)")
            this.m_HP--;
    }

}
