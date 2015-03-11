using UnityEngine;
using System.Collections;

public class Door : MonoBehaviour {

	public GameObject m_Door;
	public bool m_bOpenDoor;
	public float m_fVelocity;
	public float m_fMaxHeight;

	// Use this for initialization
	void Start () 
	{

	}
	
	// Update is called once per frame
	void Update () 
	{
		if (m_bOpenDoor)
		{
			if (m_Door.transform.position.y <= m_fMaxHeight)
			{
				m_Door.transform.position = new Vector3(m_Door.transform.position.x, m_Door.transform.position.y + (m_fVelocity * Time.deltaTime), m_Door.transform.position.z);
			}

			if(m_Door.transform.position.y >= m_fMaxHeight)
			{
				Destroy(m_Door);
			}
		}
	}
}
