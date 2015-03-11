using UnityEngine;
using System.Collections;

public class BoxCheck : MonoBehaviour {

    public GameObject button;


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

	}

    void OnTriggerStay(Collider other)
    {

        if (other.gameObject.CompareTag("Player"))
        {
            print("Colliding with Collider");
            if (Input.GetKeyUp("e"))
            {
                button.transform.position = new Vector3(0, 0, 0);
                print("Boxed Moved!");
                Destroy(this);
            }
        }
    }
}
