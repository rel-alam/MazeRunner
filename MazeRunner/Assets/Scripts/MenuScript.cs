using UnityEngine;
using System.Collections;

public class MenuScript : MonoBehaviour {

    public Rect button1;
    public Rect button2;
    public Texture texture1;
    public Texture texture2;
    
	// Use this for initialization
	void Start () {
	
        button1 = new Rect(Screen.width/2 - 100, Screen.height/2, 100, 30);
        button2 = new Rect(Screen.width / 2 + 100, Screen.height / 2, 100, 30);
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnGUI()
    {
        if (GUI.Button(button1, "Start Game"))
        {
            Application.LoadLevel("MainScene"); 
        }
        if (GUI.Button(button2, "Quit Game"))
        {
            Application.Quit();
        }
    }
}
