using UnityEngine;
using System.Collections;

public class Autodestruir : MonoBehaviour
{
    public bool autodestruccion = false;
    public float destruir = 0;
    public GameObject explosionPrefab;

	// Use this for initialization
	void Start () {
        Invoke("destruirobject", destruir);
	}

    void destruirobject()
    {
        Destroy(this.gameObject);
        Instantiate(explosionPrefab, transform.position, transform.rotation);
    }

	// Update is called once per frame
	void Update () {
	
	}
}
