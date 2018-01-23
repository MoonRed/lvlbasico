using UnityEngine;

public class Condicionales : MonoBehaviour
{
	public string texto1 = string.Empty;
	public string texto2 = string.Empty;


	// Estructuras Condicionales
	/*
	 if -> Si
	 if/else -> Si/Sino
	 switch -> Condiciones
	*/

	void Start ()
	{
		if (texto1 == texto2)
		{
			Debug.Log("Que es igual!");
		}
		else {
			Debug.Log("No es igual!");
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
				Debug.Log("Default");
				break;
		}
	}
}
