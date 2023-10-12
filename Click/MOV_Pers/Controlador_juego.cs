using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controlador_juego : MonoBehaviour
{
	public GameObject play;
	public bool startGame = true;
	public void Play_game() 
	{
		Debug.Log("start");
		play.SetActive(false);
		startGame = false;
	}
}
