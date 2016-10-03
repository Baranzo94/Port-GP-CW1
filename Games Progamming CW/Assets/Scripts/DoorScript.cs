using UnityEngine;
using System.Collections;

public class DoorScript : MonoBehaviour {
	public Animation doorAnimation;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	
	void OnTriggerEnter(Collider c)
	{
		if (c.GetComponent<Collider>().gameObject.name=="Player")
		{
			doorAnimation["OpenDoor"].speed=1.0f;
			doorAnimation.Play ("OpenDoor");
		}
	}
	
	void OnTriggerExit(Collider c)
	{
		if (c.GetComponent<Collider>().gameObject.name=="Player")
		{
			doorAnimation["OpenDoor"].speed=-1.0f;
			doorAnimation.Play("OpenDoor");
		}
	}
}
