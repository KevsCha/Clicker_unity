using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Exan_script : MonoBehaviour
{
	public TextMeshProUGUI press_A;
	public TextMeshProUGUI press_S;
	public TextMeshProUGUI press_D;
	//objet_donde crearlos
	public GameObject obj_rojo;
	public GameObject obj_verde;
	public GameObject obj_azul;
	//spawn
	public GameObject _rojo;
	public GameObject _verde;
	public GameObject _azul;


	private void Awake()
	{
		obj_rojo = GameObject.Find("rojo");
		obj_verde = GameObject.Find("verde");
		obj_azul = GameObject.Find("azul");

		press_A.text = "Pulsa la " + '"' + "A" + '"';
		press_S.text = "Pulsa la " + '"' + "S" + '"';
		press_D.text = "Pulsa la " + '"' + "D" + '"';
	}
	void Start()
	{

	}
	public void Press_A() 
	{
		Instantiate(_rojo, obj_rojo.transform.position, Quaternion.identity);
	}
	public void Press_S()
	{
		Instantiate(_verde, obj_verde.transform.position, Quaternion.identity);
	}
	public void Press_D()
	{
		Instantiate(_azul, obj_azul.transform.position, Quaternion.identity);
	}
	// Update is called once per frame
	void Update()
	{
		if (Input.GetKeyDown(KeyCode.A))
			Press_A();
		if (Input.GetKeyDown(KeyCode.S))
			Press_S();
		if (Input.GetKeyDown(KeyCode.D))
			Press_D();
		if (Input.GetKeyDown(KeyCode.E))
		{
			Press_A();
			Press_S();
			Press_D();
		}
	}
}
