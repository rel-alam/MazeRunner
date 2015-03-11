using UnityEngine;
using System.Collections;

public class RotatingPlatform : MonoBehaviour {

	public float m_fRotationSpeed;
	public bool m_bCanRotate;

	// Use this for initialization
	void Start () 
	{
		
	}
	
	// Update is called once per frame
	void Update () 
	{
		if (m_bCanRotate)
		{
			this.transform.Rotate (Vector3.right * (m_fRotationSpeed * Time.deltaTime));
		}
	}
}