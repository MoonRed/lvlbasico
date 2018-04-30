using UnityEngine;
using System.Collections.Generic;

public class Colecciones : MonoBehaviour
{
	#region Arrays
	// <Array>
	public int[] array = new int[100];
	#endregion
	#region Listas
	// <Lista>
	public List<int> lista = new List<int>();
	#endregion

	/* Metodos Listas
		Add
		Remove
		Clear
		Count
		...
	*/

	private void Start()
	{
		array[0] = 12;
		lista.Add(0);
	}

}
