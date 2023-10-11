using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class input : MonoBehaviour
{
	// Start is called before the first frame update
	void Start()
	{
	   
	}
    // Update is called once per frame
    public float vel = 10;
	public float dir = 1;
	public GameObject esferita;
	public GameObject[] esferitas;
	void Update()
	{
		if (Input.GetKeyDown(KeyCode.Q))
			Instantiate(esferita, this.gameObject.transform.position,Quaternion.identity);
		if (Input.GetKeyDown(KeyCode.B))
		{
			esferitas = GameObject.FindGameObjectsWithTag("Player");
			foreach (GameObject dest in esferitas)
				Destroy(dest);
		}
		/*
		if (Input.GetKeyDown(KeyCode.A))
			dir = -1;
		if (Input.GetKeyDown(KeyCode.D))
			dir = 1;
		if (Input.GetKeyDown(KeyCode.Space))
			dir = 0;
		if (Input.GetKeyDown(KeyCode.W))
			vel += 1;
		if (Input.GetKeyDown(KeyCode.S))
			vel -= 1;
		this.gameObject.transform.position += new Vector3(vel * dir, 0, 0) * Time.deltaTime;
		*/
		/*
		if (Input.GetMouseButtonDown(0)) 
			Debug.Log("Repite cada frame, click baja");
		if (Input.GetMouseButtonUp(0))
			Debug.Log("Repite cada frame, click sube");
		if (Input.GetKeyDown(KeyCode.A))
			Debug.Log("Repite cada frame, letra a");
		if (Input.GetKeyUp(KeyCode.A))
			Debug.Log("sube  la 'a'");
		*/

		//this.gameObject.transform.position += new Vector3(vel * dir, 0, 0) * Time.deltaTime;
		/*
		this.gameObject.transform.position += Vector3.right; //new vector(1, 0, 0);
		this.gameObject.transform.position += Vector3.left; //new vector(1, 0, 0);
		this.gameObject.transform.position += Vector3.up; //new vector(0, 1, 0);
		this.gameObject.transform.position += Vector3.down; //new vector(0, -1, 0);
		this.gameObject.transform.position += Vector3.forward; //new vector(0, 0, 1);
		this.gameObject.transform.position += Vector3.back; //new vector(0, 0, -1);
		*/
	}
}
