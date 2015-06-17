using UnityEngine;
using System.Collections;
using BellaProject;

public class SceneChangeButton2 : MonoBehaviour {

	[SerializeField]
	private int
		sceneIndexToLoad = 0;
	public void OnButtonPress ()
	{
		Application.LoadLevel (sceneIndexToLoad);
	} 
}
