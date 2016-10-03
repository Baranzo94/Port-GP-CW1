using UnityEngine;
using System.Collections;

public class Fleeingbarrelscript : MonoBehaviour {
	
	public Animation fleeingBarrel;
	
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	
	void OnTriggerEnter(Collider y)
	{
		if (y.GetComponent<Collider>().gameObject.name=="Player")
		{
			fleeingBarrel["Fleeingbarrel"].speed=1.0f;
			fleeingBarrel.Play ("Fleeingbarrel");
		}
	}
}
