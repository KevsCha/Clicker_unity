using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class script_cubo : MonoBehaviour
{
	//apuntes de acceder a un componente con codigo.
	public GameObject esferita;
	// Start is called before the first frame update
	//Esta funcion se ejecuta un frame antes lo q es recomendable usarlo para buscar objetos
	void Awake()
	{
		esferita = GameObject.FindWithTag("id");
	}
	void Start()
	{
		this.gameObject.transform.position = new Vector3(3, 10, 0);
		this.gameObject.transform.localScale = new Vector3(10, 10, 1);
		esferita.transform.position = new Vector3(1, 1, 0);
		esferita.GetComponent<Rigidbody>().mass = 100;
		int s = esferita.GetComponent<scrip_esfera>().num;
		Debug.Log("mi esfera es.... " + s);

	}

	// Update is called once per frame
	public float vel = 0.1f;
	void Update()
	{
		/*
		this.gameObject.transform.position += new Vector3(vel,0,0);
		this.gameObject.transform.localScale += new Vector3(0, 0, 0);
		*/
		//time.delttime = BUSCAR
		this.gameObject.transform.position += new Vector3(1f, 0.1f, 0.1f) * Time.deltaTime;

	}
}

public class Apuntes : MonoBehaviour
{

	// Start is called before the first frame update
	//Ejemplo de audio
	public AudioSource altavoz;//El altavoz
	public AudioClip effec1POP;//Disco
	public void PauseAudio()
	{
		altavoz.Stop();
	}
	public void PlayAudio()
	{
		altavoz.Play();
	}
	public void BotonPrueba()
	{
		altavoz.PlayOneShot(effec1POP);
	}
	//Ejemplo de escenas
	public void scena1() 
	{
		SceneManager.LoadScene(0);
	}
	public void scena2()
	{
		SceneManager.LoadScene(1);
	}

}
