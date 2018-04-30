using UnityEngine;
using System.Collections.Generic;

public class Bucles : MonoBehaviour
{
	public int experiencia = 0;
	public bool auxiliar = true;
	public List<int> coleccion = new List<int>();

	private void Start()
	{
		// for
		for (int n = 0; n < 10; n++)
		{
			experiencia = experiencia + 1;
		}

		// while
		while (auxiliar)
		{
			experiencia++;

			if (experiencia >= 30)
			{
				auxiliar = false;
			}
		}

		// foreach
		foreach (int valor in coleccion)
		{

		}
	}
}
