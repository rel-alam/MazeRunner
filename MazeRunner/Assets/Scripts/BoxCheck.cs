using UnityEngine;
using System.Collections;

public class BoxCheck : MonoBehaviour {
	
	public bool Activated;

	void Start ()
	{
		Activated = false;
	}

    void OnTriggerStay(Collider other)
    {

        if (other.gameObject.CompareTag("Player"))
        {
            //print("Colliding with Collider");
            if (Input.GetKeyUp("e"))
            {
				Activated = !Activated;
                print("Triggered! - Current state: " + Activated);
            }
        }
    }
}
