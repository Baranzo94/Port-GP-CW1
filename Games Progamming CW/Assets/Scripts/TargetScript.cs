using UnityEngine;
using System.Collections;

public class TargetScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	
	IEnumerator PlaySoundAndRemove()
	{
		GetComponent<AudioSource>().Play();
		yield return new WaitForSeconds(GetComponent<AudioSource>().clip.length);
		yield return new WaitForSeconds(0.5f);
		Destroy(gameObject);
	}
	
	
	public void HitApplyForce(Vector3 direction, float force)
	{
		GetComponent<Rigidbody>().AddForce(direction*force);
		StartCoroutine(PlaySoundAndRemove());
	}
}
