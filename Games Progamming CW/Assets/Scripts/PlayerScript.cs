using UnityEngine;
using System.Collections;

public class PlayerScript : MonoBehaviour {
	
	public GameObject gun;
	public int score=0;
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
	
	if(gun.active)
		{
			if(Input.GetButtonDown ("Fire1")){
				gun.GetComponent<AudioSource>().Play();
				Ray ray=Camera.main.ScreenPointToRay
					(Input.mousePosition);
				RaycastHit hit=new RaycastHit();
				if(Physics.Raycast(ray,out hit))
				{
					if(hit.collider.gameObject.tag=="Targets")
					{
						Debug.Log ("Hit the barrel");
						TargetScript targetScript=
									hit.collider.gameObject.GetComponent<TargetScript>();
						if(targetScript!=null)
						{
							
									targetScript.HitApplyForce(ray.direction,1000.0f);
						}			
						score++;
					}
				}
			}
		}
	
	}
	
	void OnGUI()
	{
		GUI.Label(new Rect(0,10,100,100),"Score:" + score.ToString ());
		GUI.Label(new Rect(0,20,100,100),"Name:" + playerName.ToString ());
	}
	
	void OnControllerColliderHit(ControllerColliderHit hit)
	{
		if(hit.gameObject.name=="machineGun")
		{
			Debug.Log ("Object picked up" +
											hit.gameObject.name);
			Destroy(hit.gameObject);
			gun.active=true;
		}
	}
}
