using UnityEngine;
using System.Collections;

public class Death : MonoBehaviour {

	void onTriggerEnter( Collider other )
	{
		if (other.gameObject.CompareTag("Kill"))
		{
			print ("You are dead!");
		}
	}
}
