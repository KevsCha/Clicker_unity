using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movimientos : MonoBehaviour
{
	public float velStep = 0.1f;
	public Controlador_juego gc;
	void Start()
	{
		
	}
	void Update()
	{
		if (gc.startGame == false)
		{
			if (Input.GetKeyDown(KeyCode.W))
				transform.position += new Vector3(velStep, 0, 0);
		}
		/*if (Input.GetKey(KeyCode.W))
			this.gameObject.transform.position += Vector3.forward * vel * Time.deltaTime;
		if (Input.GetKey(KeyCode.S))
			this.gameObject.transform.position += Vector3.back * vel * Time.deltaTime;
		if (Input.GetKey(KeyCode.A))
			this.gameObject.transform.position += Vector3.left * vel * Time.deltaTime;
		if (Input.GetKey(KeyCode.D))
			this.gameObject.transform.position += Vector3.right * vel * Time.deltaTime;*/
	}
    private void OnCollisionEnter(Collision collision)
    {
		/*Debug.Log(collision.gameObject.name);
		if (collision.gameObject.name == "pared Roja")
		{
			Destroy(collision.gameObject);
			Debug.Log("choque con una pared");
		}*/
    }
    private void OnTriggerEnter(Collider other)
    {
        
    }
}
