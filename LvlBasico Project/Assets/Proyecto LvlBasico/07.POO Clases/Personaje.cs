#region Librerias
using UnityEngine;
using Clases.lvlBasico;
#endregion

/// <summary>
/// <para>Clase principal del personaje.</para>
/// </summary>
public class Personaje : MonoBehaviour
{
	#region Variables
	/// <summary>
	/// <para>Vida actual del personaje.</para>
	/// </summary>
	private float vidaActual = 10.0f;							// Vida actual del personaje
	/// <summary>
	/// <para>Vida maxima del personaje.</para>
	/// </summary>
	private float vidaMax = 10.0f;								// Vida maxima del personaje
	/// <summary>
	/// <para>Mana actual del personaje.</para>
	/// </summary>
	private float manaActual = 5.0f;							// Mana actual del personaje
	/// <summary>
	/// <para>Mana maximo del personaje.</para>
	/// </summary>
	private float manaMax = 5.0f;                               // Mana maximo del personaje
	#endregion

	#region Propiedades
	public float VidaActual
	{
		get { return vidaActual; }
		set { vidaActual = value; }
	}
	#endregion

	#region Constructor
	public Personaje(float vidActual, float vidMax, float manActual, float manMax)
	{
		VidaActual = vidActual;
	}
	#endregion

	#region Metodos
	private void Start()
	{
		Debug.Log("Vida Actual " + VidaActual);
	}

	public void Atacar()
	{ }
	#endregion
}
