using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejers_ControlComand : MonoBehaviour
{
	public Vector3 dir_obj;
	//Ejercicio 1
	public GameObject cubo;
	//EJercicio 3
	private GameObject cub;
	//Ejercicio 4
	public GameObject cubo4;
	//Ejercicio 5
	public GameObject go_Recept;
	public valuesReceptor val_Recept;
	//Extra 1
	public float vel = 1f;
	public bool dir = true;
	//Extra 2
	public bool dirX = true;
	public bool dirY = true;
	private void Awake()
	{
		cubo4 = GameObject.FindWithTag("id");
		cubo4.transform.localScale = new Vector3(2, 2, 2);
		go_Recept = GameObject.Find("Obj_1");
		val_Recept = go_Recept.GetComponent<valuesReceptor>();
		//Extra 1
		dir_obj = this.gameObject.transform.position;
	}
	void Start()
	{
		//Ejercicio 1
		//this.transform.localScale = new Vector3(2, 2, 2);
		//Ejercicio 2
		//cubo.transform.localScale = new Vector3(2, 2, 2);
		//Ejercicio 4
		cubo4.GetComponent<Rigidbody>().mass = 10;
		this.GetComponent<Rigidbody>().mass = cubo4.GetComponent<Rigidbody>().mass;
		//this.GetComponent<Rigidbody>().mass = 4;
		//Ejercicio 5
		val_Recept.Change();
		//Ejercicio 6
		
		//Ejercicio 8
		//Ejercicio 9
	}

	// Update is called once per frame
	void Update()
	{
		//Ejercicio extra1
		//Direcction_horizontal();
		//extra 2
		Direction_Cubo();
		
	}
	public void Direcction_horizontal() 
	{
		if (this.gameObject.transform.position.x > 4f)
			dir = false;
		else if (this.gameObject.transform.position.x < -4f)
			dir = true;
		
		if (dir != false)
			this.gameObject.transform.position += Vector3.right * vel * Time.deltaTime;
		if (dir != true)
			this.gameObject.transform.position += Vector3.left * vel * Time.deltaTime;
	}
	public void Direction_Cubo() 
	{
		if (this.gameObject.transform.position.x > 4.0f && dir_obj.y >= 0)
			dirY = false;
		if (this.gameObject.transform.position.y > 4.0f)
			dirX = false;
		if (this.gameObject.transform.position.x < -4.0f)
			dirY = true;
		if (this.gameObject.transform.position.y < 0)
			dirX = true;

		if (dirX && dirY)
			this.gameObject.transform.position += Vector3.right * vel * Time.deltaTime;
		if (dirX && !dirY)
			this.gameObject.transform.position += Vector3.up * vel * Time.deltaTime;
		if (!dirX && !dirY)
			this.gameObject.transform.position += Vector3.left * vel * Time.deltaTime;
		if (!dirX && dirY)
			this.gameObject.transform.position += Vector3.down * vel * Time.deltaTime;
	}

}
