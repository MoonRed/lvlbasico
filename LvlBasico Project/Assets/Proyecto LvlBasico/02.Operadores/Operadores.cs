using UnityEngine;

public class Operadores : MonoBehaviour
{
	public int x = 5;
	public int y = 2;
	int total = 0;

	void Start ()
	{
		/* Aritmeticos

		Suma			-> +
		Resta			-> -
		Multiplicacion	-> * 
		Division		-> /
		*/

		total = x * y;
		Debug.Log(total);


		/* Logicos
		y						-> &&
		o						-> ||
		Negacion				-> !
		Igualdad				-> ==
		Si no es igual			-> !=
		Menor					-> <
		Mayor					-> >
		Menor igual				-> <=
		Mayor igual				-> >=
		 */

		if (x == y) Debug.Log("Es igual!");
	}
}
