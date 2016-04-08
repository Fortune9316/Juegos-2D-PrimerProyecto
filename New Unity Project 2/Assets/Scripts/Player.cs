using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {

    // Use this for initialization
    HudController hudController;
	void Start () {
        hudController = GameObject.Find("MainCamera").GetComponent<HudController>();
	}
	
	// Update is called once per frame
	void Update () {
        if (Time.timeScale > 0)
        {
            Vector3 position = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            transform.position = new Vector3(transform.position.x, position.y, transform.position.z);
        }
	}

    void OnTriggerEnter2D(Collider2D coll)
    {
        coll.gameObject.SetActive(false);
        if(coll.gameObject.tag == "food")
        {
            hudController.updateScore();
        }else if(coll.gameObject.tag == "enemy")
        {
            hudController.ReduceLife();
           
        }
    }
}
