using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using UnityEngine.UI;

public class Select_person : MonoBehaviour
{
	/*TODO:
	 * using System.IO;
	 * using UnityEngine.UI; => buscar que hace estas librerias y para que se suelen utilizar
	 * Directory => buscar que hace esat funcion
	 * List<string> imagenes = new List<string>(); => como utilizar
	 */
	public Canvas canvas;
	public Button btn_characters;
	public List<string> list_Person;

	private void Awake()
	{
		canvas = GameObject.Find("Canvas").GetComponent<Canvas>();
		list_Person = List_Person();
		//Debug.Log(canvas);
	}
	void Start()
	{
		//Debug.Log(list_Person);
	}
	//TODO: Generar un boton a partir de la lista de datos q va a recolectar de la carpeta
		//TODO: a partir de la ultima posicion hacer strings para que se añadan a la lista para solo tener el nombre del personaje.
		//TODO: de los strings añadirlos en una lista para generar los personajes
	public List<string> List_Person() 
	{
		int i = 0;
		int ultimate_pos;
		string character;
		string[] img_files;
		string ruta = Directory.GetCurrentDirectory();
		List<string> listPerson = new ();

		ruta += "\\Assets\\Dragon_Ball_Sagas\\1_Select_characters";
		if (Directory.Exists(ruta))
		{
			img_files = Directory.GetFiles(ruta, "*.png");
			//Debug.Log(img_files.Length);
			while (i < img_files.Length)
			{
				ultimate_pos = Ultimate_char(img_files[i], '\\');
				character = Str_person(img_files[i], ultimate_pos + 1);
				//Debug.Log(character);
				listPerson.Add(character);
				//TODO: Generar botones.
				Gn_Btn(character);
				i++;
			}
		}
		return (listPerson);
	}
	public void Gn_Btn(string persons) 
	{
		GameObject btn_dinamico;

		btn_dinamico = new GameObject(persons);
		btn_characters = btn_dinamico.AddComponent<Button>();
		Props(btn_dinamico, persons);

	}
	public void Props(GameObject btn, string nomb) 
	{
		TextMesh btn_text;
		Image btn_img;

		btn_text = btn.AddComponent<TextMesh>();
		btn_img = btn.AddComponent<Image>();

		btn.transform.SetParent(canvas.transform, true);
		btn_text.text = nomb;
		
	}
	//Obtiene la ultima pos del string de la direccion del directorio que le envia
	//TODO: utilizar List<string> para crear mi lista con los personajes,  obtener los sprites de forma manual y asignarles a cada btn creado de forma manual
	public int Ultimate_char(string str, char c) 
	{
		int i;
		i = str.Length - 1;
		while (i > 0 && str[i] != c)
			i--;
		return (i);
	}

	public string Str_person(string str, int pos) 
	{
		string subStr;

		subStr = str.Substring(pos);
		return (subStr);
	}
	/*private void Persons()	
	{

	}*/

	/*	
	public void Salir() 
	{
		Application.Quit();
	}
	*/
}
