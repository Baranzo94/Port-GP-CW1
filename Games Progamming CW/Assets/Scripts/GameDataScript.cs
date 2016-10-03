using UnityEngine;
using System.Collections;

public class GameDataScript : MonoBehaviour {
	
	public string playerName="";
	public int score;
	// Use this for initialization
	void Start () {
		DontDestroyOnLoad (this);
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
