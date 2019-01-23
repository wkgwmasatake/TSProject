using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class targetscript : MonoBehaviour {

     int HP = 100;
     int Damage = 50;
	// Use this for initialization
	void Start () {
        
	}
	
	// Update is called once per frame
	void Update () {
	}
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log(HP);
        if (other.tag == "player")
        {
            if (transform.position.y >= other.transform.position.y)
            {
                HP -= Damage;
            }
            else
            {
                HP -= Damage * 2;
               GetComponentInChildren<ParticleSystem>().Play();
                //Destroy(gameObject);
            }
            Debug.Log(HP);
        }
    }
}
