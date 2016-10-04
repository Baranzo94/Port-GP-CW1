using UnityEngine;
using System.Collections;

public class PlayerScriptIsland : MonoBehaviour {
	
	public int score;
	public AudioClip footStepSound;
	public AudioClip jumpSound;
    public string playerName;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		
		
		
		if(Input.GetButtonDown ("Horizontal")||Input.GetButtonDown ("Vertical"))
	
		{
	
			if(!GetComponent<AudioSource>().isPlaying)
			{
				GetComponent<AudioSource>().loop=true;
				GetComponent<AudioSource>().PlayOneShot(footStepSound);
			}
		}
		else if(Input.GetButtonUp ("Horizontal")||Input.GetButtonUp ("Vertical"))
		{
			GetComponent<AudioSource>().loop=false;
			GetComponent<AudioSource>().Stop ();
		}
	
		if(Input.GetButtonDown("Jump"))
		{
			GetComponent<AudioSource>().PlayOneShot(jumpSound);
		}
		

	
	}
	
                   
}
