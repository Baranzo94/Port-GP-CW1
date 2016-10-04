using UnityEngine;
using System.Collections;

public class SummaryScript : MonoBehaviour {
	
	public Texture2D backGroundTexture;
	
	void OnGUI () {
		
		GUI.DrawTexture(new
		Rect(0,0,Screen.width,Screen.height),backGroundTexture);
		
		//print(PlayerPrefs.GetInt("Score"));
		
		GUI.Label (new Rect (600, 500, 200, 200), "Well Done you are merciless barrel hunter and survivor of crashes");
		
		
		if (GUI.Button (new Rect (625, 600, 50, 50),"Quit"))
		{
			Application.Quit();
		}
	}
}

