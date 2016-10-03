using UnityEngine;
using System.Collections;

public class SpawnScript : MonoBehaviour {
	
	public GameObject spawnPrefab;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	
	public void Spawn()
	{
		GameObject barrel=(GameObject)Instantiate(spawnPrefab,
								transform.position,Quaternion.identity);
		barrel.name="barrel";
	}
}
