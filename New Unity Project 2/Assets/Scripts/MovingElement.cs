using UnityEngine;
using System.Collections;

public class MovingElement : MonoBehaviour {

    // Use this for initialization
    Vector3 limit;
	void Start () {
        limit = GameObject.Find("Limit").transform.position;
	}
	
	// Update is called once per frame
	void Update () {
        Vector3 position = transform.position;
        position.y -= 5f * Time.deltaTime;
        transform.position = position;
        if(limit.y>transform.position.y)
        {
            Destroy(gameObject);
        }
	}
}
