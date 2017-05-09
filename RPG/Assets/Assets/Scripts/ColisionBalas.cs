using UnityEngine;
using System.Collections;

public class ColisionBalas : MonoBehaviour {

    public bool destroySelfOnImpact = false;
   	public bool damageOnCollision = false;
    public GameObject explosionPrefab;
    

	// Use this for initialization
	void Start () 
    {
        
	}
    
	// Update is called once per frame
    void OnCollisionEnter(Collision collision) 						// this is used for things that explode on impact and are NOT triggers
    {
        if (damageOnCollision) 
        {
            if (explosionPrefab != null)
            {
                 Instantiate(explosionPrefab, transform.position, transform.rotation);
            }     
            

            if (destroySelfOnImpact) 
            {
				Destroy (gameObject);	  // destroy the object whenever it hits something
			}
        }
    }
    
    }     

