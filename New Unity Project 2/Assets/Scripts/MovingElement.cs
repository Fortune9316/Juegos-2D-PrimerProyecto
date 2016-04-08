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
        if (gameObject.activeInHierarchy)
        {
            Vector3 position = transform.position;
            position.x -= 5f * Time.deltaTime;
            transform.position = position;
            if (limit.x > transform.position.x)
            {
                gameObject.SetActive(false);
            }
        }
        
	}
}
