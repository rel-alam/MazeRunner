using UnityEngine;
using System.Collections;

public class Death : MonoBehaviour {

	void OnTriggerEnter(Collider other)
	{
		
		if (other.gameObject.CompareTag("Player"))
		{
			print("Game Over!");
			Application.LoadLevel("Menu");
		}
	}
}
