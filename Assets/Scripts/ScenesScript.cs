using UnityEngine;
using System.Collections;

public class ScenesScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () 
	{
		if (Input.GetKeyDown("y")) 
		{
			Application.LoadLevel(1);
		}
		if (Input.GetKeyDown("q")) 
		{
			Application.Quit();

		}
		if (Input.GetKeyDown("r")) 
		{
			Application.LoadLevel(1);
		}
	}
}
