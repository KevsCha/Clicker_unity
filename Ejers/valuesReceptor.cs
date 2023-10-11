using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class valuesReceptor : MonoBehaviour
{
	public GameObject obj_contain;
	public valuesContainer contain;
	public Vector3 val;

	public void Awake()
	{
		//Ejercicio 5
		obj_contain = GameObject.Find("Obj_2");
		contain = obj_contain.GetComponent<valuesContainer>();
		//Ejercicio 6
		/*
		contain = GameObject.Find("Obj_2").GetComponent<valuesContainer>();
		*/
	}
	public void Change() 
	{
		val = new Vector3(contain.val1, contain.val2, contain.val3);
		this.gameObject.transform.position = val;
	}
}
