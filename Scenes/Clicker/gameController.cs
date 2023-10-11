using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class gameController : MonoBehaviour
{
	/* 
	   public AudioSource altavoz;//El altavoz
	   public AudioClip effec1POP;//Disco
	*/
	public GameObject objAparecer;
	public GameObject btn_Mejora;
	public TextMeshProUGUI pointsTxt;
	public TextMeshProUGUI timeTxt;
	public Vector3 rankPos;
	public int vida;
	public int nerf = 10;
	public int damage = 1;
	public int points;
	// Start is called before the first frame update
	//obtner el rango de la pantalla
	//rango definido en coordenadas x, y, z
	//rango aleatorio
	void Start()
	{
		if (points == 5)
			nerf = 15;
		if (points == 3)
			btn_Mejora.SetActive(true);
		//else if ()
		Debug.Log(btn_Mejora.activeSelf);
		vida = nerf;
		rankPos = new Vector3(
			Random.Range(-10f, 10f),
			Random.Range(-5.5f, 5.5f),
			15.5f
			);
	}

	void OnMouseDown()
	{
		vida -= damage;
		Debug.Log(vida);
		if(vida <= 0)
			objDestroy();
		
	}
	public void objDestroy() 
	{
		points++;
		vida = nerf;
		pointsTxt.text = "Puntuacion: " + points.ToString();
		GameObject instancia = Instantiate(objAparecer, rankPos, Quaternion.identity);
		Destroy(objAparecer);
	}
	public void mejoraEnable() 
	{
		damage *= 2;
		Debug.Log("function mejoraE" + damage);
	}
	
		// Update is called once per frame

   void Update()
	{
		//rango en la que aparecera el obejeto, hay q definirla!!!

	}

}
