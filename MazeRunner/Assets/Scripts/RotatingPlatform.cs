using UnityEngine;
using System.Collections;

public class RotatingPlatform : MonoBehaviour {


	public GameObject m_Trigger1;
	public BoxCheck m_TrigerCheck1;
	public GameObject m_Trigger2;
	public BoxCheck m_TrigerCheck2;
	public float m_fRotationSpeed;

	// Use this for initialization
	void Start () 
	{
		m_Trigger1 = GameObject.Find ("Left Colliding Box");
		m_TrigerCheck1 = m_Trigger1.GetComponent<BoxCheck> ();
		m_Trigger2 = GameObject.Find ("Right Colliding Box");
		m_TrigerCheck2 = m_Trigger2.GetComponent<BoxCheck> ();
	}
	
	// Update is called once per frame
	void Update () 
	{
		if (m_TrigerCheck1.Activated == false || m_TrigerCheck2.Activated == false)
		{
			this.transform.Rotate (Vector3.right * (m_fRotationSpeed * Time.deltaTime));
		}
	}
}