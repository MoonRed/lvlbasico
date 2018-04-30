using UnityEngine;

public class MetodosFunciones : MonoBehaviour
{
	/// <summary>
	/// <para>Variables para el metodo <see cref="Metodo"/>.</para>
	/// </summary>
	protected int val = 0;

	public void Start()
	{
		val = 1;

		// Un metodo es un bloque de codigo que contiene una serie de instrucciones
		Metodo("Antonio",0);

		// Una funcion es un bloque de codigo que nos devuelve un valor
		Debug.Log(Funcion(5,4).ToString());
	}

	#region Metodos
	/// <summary>
	/// <para>Este metodo, realiza esta accion.</para>
	/// <para> El metodo es de <see cref="MetodosFunciones"/>.</para>
	/// </summary>
	public void Metodo()
	{

	}

	public void Metodo(string nombre)
	{

	}

	public void Metodo(string nombre, int valor)
	{
		Debug.Log("Llamada desde Start()");
	}
	#endregion

	#region Funciones
	public int Funcion(int x,int y)
	{
		return x + y;
	}
	#endregion
}
