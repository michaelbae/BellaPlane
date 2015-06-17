using UnityEngine;
using System.Collections;
using BellaProject;
public class ChangeGameMode : MonoBehaviour {

	[SerializeField]
	private GameMode.GameModes
		gameModeOnPress = GameMode.GameModes.Normal;
	public void OnButtonPress ()
	{
		GameMode.gameMode = gameModeOnPress;
	}
}
