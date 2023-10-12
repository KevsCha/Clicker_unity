using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exam_2 : MonoBehaviour
{
	public GameObject s_cub;
	public float red = 1.9f;
	public void create(float a, float b, float c) 
	{
		Instantiate(s_cub, new Vector3(a, b, c), Quaternion.identity);
	}
	public void Btn_linea(float a, float b, float c) 
	{
		int i = 0;
		float posX = -9f;
		while (i < 10) 
		{
			create(posX, b ,c);
			posX += a;
			i++;
		}
	}
	public void Btn_plano(float a, float b, float c)
	{
		int i = 0;
		float posZ = 0;

		while (i < 10) 
		{
			Btn_linea(a, b, posZ);
			posZ += c;
			i++;
		}
	}
	public void Btn_torre(float a, float b, float c)
	{
		int i = 0;
		float posY = 0;

		while (i < 10) 
		{
			Btn_plano(a, posY, c);
			posY += b;
			Debug.Log(posY);
			i++;
		}
	}
	public void Btn_invocLine() 
	{
		Btn_linea(red, 0, 0);
	}
	public void Btn_invocPlane()
	{
		Btn_plano(red, 0, red);
	}
	public void Btn_invocTower()
	{
		Btn_torre(red, 1.5f, red);
	}

	void Update()
	{
		if (Input.GetKeyDown(KeyCode.A))
			Btn_invocLine();
		if (Input.GetKeyDown(KeyCode.S))
			Btn_invocPlane();
		if (Input.GetKeyDown(KeyCode.D))
			Btn_invocTower();
	}
}
