using UnityEngine;
using System.Collections;

public class InstructionsScript : MonoBehaviour {
	
	public Texture2D backGroundTexture;
	
	void OnGUI () {
		
		GUI.DrawTexture(new
		Rect(0,0,Screen.width,Screen.height),backGroundTexture);
		
		GUI.Label (new Rect (25, 25, 150, 100), "The following are basic instructions for the Barrel Hunting game");
		GUI.Label (new Rect (25, 150, 100, 100), "1. To centre the crosshair and to remove the mouse cursor click at the beginning of the game");
		GUI.Label (new Rect (25, 250, 100, 100), "2. To move around use the WASD keys. Left Click to fire (once gun is acquired)");
		GUI.Label (new Rect (25, 350, 100, 100), "3. Aim using the crosshair and shoot the barrels to score points and multiple hits adds more points");
		GUI.Label (new Rect (125, 150, 100, 100), "4. Beware the flying cubes as you make your way to the jet to escape");
	    GUI.Label (new Rect (125, 250, 100, 100),"5. If you wish to leave at anytime hit Esc key to show mouse cursor");
		GUI.Label (new Rect (125, 350, 100, 100),"6. Good Luck");
		if (GUI.Button (new Rect (25, 600, 100, 30), "Ready ?")) 
		{
			//StartCoroutine(PlayButtonClick());
			Application.LoadLevel("MainGame");
		}
		
		if (GUI.Button (new Rect (150,600, 100, 30), "Back"))
		{
			Application.LoadLevel ("MainMenu");
		}
		
		if (GUI.Button (new Rect (275, 600, 100, 30),"Quit"))
		{
			Application.Quit();
		}
		
		//IEnumerator PlayButtonClick()
	//{
	//	audio.Play();
	//	yield return new WaitForSeconds(audio.clip.length);
	//}
		
	}
}
	
		
	
	
	

	// Use this for initialization
	//void Start () {
	
	//}
	
	// Update is called once per frame
	//void Update () {
	
	//}
