using UnityEngine;
using System.Collections;

public class LevelEndScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	
	void OnTriggerEnter(Collider x)
	{
		if (x.GetComponent<Collider>().gameObject.name=="Player")
		{
			Application.LoadLevel("IslandLevel");
		}
	}
}
