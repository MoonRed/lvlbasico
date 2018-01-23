using UnityEngine;

public class EjerCondicionales : MonoBehaviour
{
	/* Ejercicio Estructuras Condicionales

	Con las siguientes variables, comprueba si n1 es mayor que n2 y
	muestralo por consola.

	Comprueba los siguientes 3 casos posibles.

	caso 1 -> n1 es 0
	caso 2 -> n1 es 1
	caso 3 -> n1 no es ninguna de las otras opciones
	*/

	public int n1 = 3;
	public int n2 = 5;


	void Start()
	{
		if (n1 > n2) Debug.Log("n1 es mayor!");

		switch (n1)
		{
			case 0:
				Debug.Log("0");
				break;

			case 1:
				Debug.Log("1");
				break;

			default:
				Debug.Log("Ninguno.");
				break;
		}
	}
}
