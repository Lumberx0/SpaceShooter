using UnityEngine;
using System.Collections;

public class EnemyDamageHandler : MonoBehaviour {

    public int health;

	void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "Lazer")
        {
            health -= 2;
			
        }
        Debug.Log(health);

        if(health <= 0)
        {
            Die();
        }
    }

    void Die()
    {
        Destroy(gameObject);
    }

    
    // Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
