using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EjersBucle : MonoBehaviour
{
	// Start is called before the first frame update
	//Ejercicio 1
	public int counter;
	//Ejercicio 2
	public int counter2;
	//Ejercicio 3
	public int counter3;
	//Ejercicio 4
	public int i;
	//Ejercicio 5
	public int j;
	public int cont;
	//Ejercicio 6
	public int[] numbers = {1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25};
	public int k;
	//Ejercicio 7
	public int[] numbers2 = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25};
	public int n;
	//Ejercicio 8
	public int[] numbers3 = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25};
	//Ejercicio 9
	public float[] val;
	//Ejercicio 10
	public float[] val2;
	//Ejercicio 11
	public string[] edificio1 = { "Kevs", "Antonio","Antonio","Canela","Tammy","Zeus", "David", "Sara", "Alba", "Dardo", "Dhaily", "Andrea" };
	//Ejercicio 12
	public string[] edificio2;
	//Ejercicio 13
		//Ejercicio 11FOR
		public string[] edFOR = { "Kevs", "Antonio", "Antonio", "Canela", "Tammy", "Zeus", "David", "Sara", "Alba", "Dardo", "Dhaily", "Andrea" };

		//Ejercicio 12FOR
		public string[] ed2FOR;
	//Ejercicio 14
		//Ejercicio 11V2
		public string[] edV2 = { "Kevs", "Antonio", "Antonio", "Canela", "Tammy", "Zeus", "David", "Sara", "Alba", "Dardo", "Dhaily", "Andrea" };
		//Ejercicio 12FOREACH
		public string[] ed2V2;
	//Ejercicio 10
	void Start()
	{
		/*
		//Ejercicio 1
		while (counter <= 100)
		{
			Debug.Log(counter);
			counter++;
		}
		//Ejercicio 2
		while (counter2 <= 10000) 
		{
			Debug.Log(counter2);
			counter2++;
		}
		//Ejercicio 3
		counter3 = 10000;
		while (counter3 >= 0) 
		{
			Debug.Log(counter3);
			counter3++;
		}
		//Ejercicio 4
		while (i < 10000) 
		{
			if (i > 5000)
				break;
			i += 3;
		}
		//Ejercicio 5
		while (j < 10000) 
		{
			if (j > 5000)
				break;
			cont++;
			j += 3;
		}
		Debug.Log("Numero de iteracione: " + cont);
		//Ejercicio 6
		while (k < numbers.Length) 
		{
			if (numbers[k] % 2 == 0)
				Debug.Log("multiple de 2: " + numbers[k]);
			k++;
		}
		//Ejercicio 7
		while (n < numbers2.Length)
		{
			if (numbers[n] % 3 == 0)
				Debug.Log("multiple de 3: " + numbers[n]);
			if (numbers[n] % 5 == 0)
				Debug.Log("multiple de 5: " + numbers[n]);
			n++;
		}
		//Ejercicio 8
		int a = 0;
		int tot = 0;
		while (a < numbers3.Length)
		{
			tot += numbers3[a] * 10;
			a++;
		}
		Debug.Log("La suma Total es: " + tot);
		*/
		//Ejercicio 9
		int b = 0;

		val = new float[25];
		while (b < val.Length) 
		{
			val[b] = Random.Range(0f, 10f);
			b++;
			Debug.Log(Random.Range(0f, 10f));
		}
		
		//Ejercicio 10
		/*
		float average = 0;
		int a2 = 0;
		val2 = new float[25];
		while (a2 < val2.Length) 
		{
			val2[a2] = Random.Range(0f, 10f);
			average += val2[a2];
			a2++;
			if (a2 == val2.Length)
				average /= val2.Length;
		}
		Debug.Log(average);
		*/
		//Ejercicio 11
		
		Debug.Log(edificio1.Length);
		int iVal;
		int temp;

		iVal = 0;
		temp = 0;
		while (i < edificio1.Length) 
		{
			if (edificio1[iVal] == "Antonio")
				temp++;
			i++;
		}
		if (temp == 0)
			Debug.Log("No hay ningun Antonio en este edificio");
		if (temp == 1)
			Debug.Log("he encontrado a Antonio");
		if (temp >= 2)
			Debug.Log("He encontrado a los Antonios");
		
		//Ejercicio 12
		/*
		int it;
		int jt;
		int vecC;

		it = 0;
		vecC = 0;

		while (it < edificio1.Length) 
		{
			jt = 0;
			while (jt < edificio2.Length) 
			{
				if (edificio1[it] == edificio2[jt] && edificio2[0] != null)
					vecC++;
				else
					Debug.Log("Llenar la lista de vecinos del edificio Nº 2");
				jt++;
			}
			it++;
		}
		Debug.Log("El numero  de coincidencia de vecinos es: " + vecC);
		*/
		//Ejercicio 13
		/*
			//Ejercicio 11FOR
			int tempFOR = 0;

			for (int iFOR = 0; i < edFOR.Length; iFOR++)
			{
				if (edFOR[i] == "Antonio")
					tempFOR++;
			}
			if (tempFOR == 1)
				Debug.Log("He encontrado a Antonio");
			if (tempFOR == 0)
				Debug.Log("No hay Antonios");
			if (tempFOR > 1)
				Debug.Log("He encontrado a los Antonios");
		*/
			//Ejercicio 12FOR
			int temp2FOR = 0;
			for (int x = 0; x < edFOR.Length; x++)
			{
				for (int y = 0; y < ed2FOR.Length; y++)
				{
					if (edFOR[x] == ed2FOR[y]) 
						temp2FOR++;
				}
			}
			Debug.Log("El numero de vecinos con el mismo nombre es: " + temp2FOR);


		//Ejercicio 14
		/*
			//Ejercicio 11
			int iC = 0;

			foreach (string nombre in edV2) 
			{
				if (nombre == "Antonio")
					iC++;
			}
			if (iC == 1)
				Debug.Log("He encontrado a Antonio");
			if (iC == 0)
				Debug.Log("No hay Antonios");
			if (iC > 1)
				Debug.Log("He encontrado a los Antonios");
		*/
			//Ejercicio 12
			int ix = 0;

			foreach (string nombre in edV2)
			{
				foreach (string nomb2 in ed2V2)
				{
					if (nombre == "Antonio")
						ix++;
				}
			}
				
			}/*
			if (ix == 1)
				Debug.Log("He encontrado a Antonio");
			if (ix == 0)
				Debug.Log("No hay Antonios");
			if (ix > 1)
				Debug.Log("He encontrado a los Antonios");*/

	// Update is called once per frame
	void Update()
	{

	}

}
