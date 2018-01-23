using UnityEngine;

public class EjerOperadores : MonoBehaviour
{
	public int num1 = 0;
	public int num2 = 0;
	private int total = 0;

	/* Ejercicio Operadores
	 * Suma num1 a num2 y comprueba si el total es mayor a 100,
	 si lo es, muestra por consola que lo es.*/

	void Start ()
	{
		total = num1 + num2;

		if (total > 100) Debug.Log("Es mayor.");
	}

}
