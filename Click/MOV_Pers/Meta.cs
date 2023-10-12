using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Meta : MonoBehaviour
{
	private void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.name == "Enemy")
			Debug.Log("enemigo gano");
		if (other.gameObject.name == "Play")
			Debug.Log("has ganado");
	}
}
