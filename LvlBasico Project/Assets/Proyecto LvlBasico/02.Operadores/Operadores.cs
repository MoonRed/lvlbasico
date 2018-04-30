using UnityEngine;

public class Operadores : MonoBehaviour
{
	// <Operadores Aritmeticos>

	/*
		Suma		-> +
		Resta		-> -
		Multi		-> *
		Division	-> /
		Modulo		-> %
	*/

	// <Operadores Logicos>

	/*
		y					-> &&
		o					-> ||
		Negacion			-> !
		Igualdad			-> ==
		Si no es igual		-> !=
		Menor				-> <
		Mayor				-> >
		Menor igual			-> <=
		Mayor igual			-> >=
	*/

	public int x = 0;
	public int y = 0;
	public int total = 0;

	private void Start()
	{
		total = x + y;
		Debug.Log(total);

		// Logico
		if (total != x)
		{
			Debug.Log("No es igual!");
		}
	}
}
