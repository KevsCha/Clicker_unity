using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemigo_mov : MonoBehaviour
{
	public float vel = 0.5f;
	public GameObject gc;
	Controlador_juego cont;
    private void Awake()
    {
		gc = GameObject.Find("GameObject");
		cont = gc.GetComponent<Controlador_juego>();

	}

    void Update()
	{
		if(cont.startGame == false)
			this.gameObject.transform.position += Vector3.right * vel * Time.deltaTime;
		//transform.position += Vector3.right * vel * Time.deltaTime;
	}
}
