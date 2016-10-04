using UnityEngine;
using System.Collections;

public class MainMenuScript : MonoBehaviour {
	
	public Texture2D backGroundTexture;
	
	public int buttonWidth=100;
	public int buttonHeight=30;
	
	public int buttonSpacing=70;
	
	public int buttonYStart=300;
	
	public string nameText="";
	

	
	void OnGUI()
	{
		GUI.DrawTexture(new
		Rect(0,0,Screen.width,Screen.height),backGroundTexture);
		
		/*nameText=GUI.TextField (new Rect(Screen.width/2-
		100.0f,50.0f,100.0f,20.0f),nameText);*/
		int buttonyPosition=buttonYStart;
	
		GameObject gameData=GameObject.Find ("GameData");
		if(gameData!=null){
			{
				GameDataScript
				gameDataScript=gameData.GetComponent<GameDataScript>();
				gameDataScript.playerName=nameText;
			}
		
		if(GUI.Button (new Rect(Screen.width/2-buttonWidth/2,
						buttonyPosition,buttonWidth,buttonHeight),"Start"))
		{
			StartCoroutine(PlayButtonClick());
			Application.LoadLevel("Instructions");
		}
		buttonyPosition+=buttonSpacing;
		
		if (GUI.Button(new Rect(Screen.width/2-buttonWidth/2,
			buttonyPosition,buttonWidth,buttonHeight),"Quit"))
		{
			Application.Quit ();
		}
			GUI.Label(new Rect (700, 200, 200, 200), "The Barrel Hunting Game");
		}
	}
	
	IEnumerator PlayButtonClick()
	{
		GetComponent<AudioSource>().Play();
		yield return new WaitForSeconds(GetComponent<AudioSource>().clip.length);
	}
		
		

	// Use this for initialization
	void Start () {}
	
	
	
	// Update is called once per frame
	void Update () {}
	
	
}