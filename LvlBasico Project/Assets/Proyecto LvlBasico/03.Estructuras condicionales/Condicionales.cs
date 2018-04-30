using UnityEngine;

public class Condicionales : MonoBehaviour
{
	// <Estructuras Condicionales>

	/*
		Si						-> if
		Si/Sino					-> if/else
		Condiciones Multiples	-> switch
	 */

	/*
		if(condicion)
		{
			// Ejecutar codigo	
		}
	 
	 */

	public string texto1 = string.Empty;
	public string texto2 = string.Empty;

	private void Start()
	{
		if (texto1 == texto2)
		{
			Debug.Log("La condicion se cumple.");
		}
		else
		{
			Debug.Log("La condicion no se cumple.");
		}

		switch (texto1)
		{
			case "Texto1":
				Debug.Log("Texto1");
				break;

			case "Texto2":
				Debug.Log("Texto2");
				break;

			default:
				Debug.Log("Texto desconocido.");
				break;
		}
	}

	/* Operador ternario
		nombreVariables = condicion ? valor1 : valor2;
	 */
}
