using UnityEngine;
using System.Collections;

public class Door : MonoBehaviour {

	public bool m_IgnoreTriggers;
	public GameObject m_DoorTrigger1;
	public BoxCheck m_DoorCheck1;
	public GameObject m_DoorTrigger2;
	public BoxCheck m_DoorCheck2;
	public GameObject m_Door;
	public float m_fVelocity;
	public float m_fMaxHeight;

	// Use this for initialization
	void Start () 
	{
		m_DoorTrigger1 = GameObject.Find ("Platform Colliding Box");
		m_DoorCheck1 = m_DoorTrigger1.GetComponent<BoxCheck> ();
		m_DoorTrigger2 = GameObject.Find ("Wall Colliding Box");
		m_DoorCheck2 = m_DoorTrigger2.GetComponent<BoxCheck> ();
	}
	
	// Update is called once per frame
	void Update () 
	{
		if (!m_IgnoreTriggers) 
		{
			if (m_DoorCheck1.Activated == true && m_DoorCheck2.Activated == true) 
			{
					if (m_Door.transform.position.y <= m_fMaxHeight) 
					{
							m_Door.transform.position = new Vector3 (m_Door.transform.position.x, m_Door.transform.position.y + (m_fVelocity * Time.deltaTime), m_Door.transform.position.z);
					}

					if (m_Door.transform.position.y >= m_fMaxHeight) 
					{
							Destroy (m_Door);
					}
				}
		} 
		else if (m_IgnoreTriggers)
		{
			if (m_Door.transform.position.y <= m_fMaxHeight) 
			{
				m_Door.transform.position = new Vector3 (m_Door.transform.position.x, m_Door.transform.position.y + (m_fVelocity * Time.deltaTime), m_Door.transform.position.z);
			}
			
			if (m_Door.transform.position.y >= m_fMaxHeight) 
			{
				Destroy (m_Door);
			}
		}
	}
}
