/*
 * Autor:			Antonio
 * Email:				...		
 * Fecha:
 * Descripcion:
 */

#region Librerias
using UnityEngine;
#endregion

namespace Clases.lvlBasico
{
	/// <summary>
	/// <para>Clase auxiliar para generar objetos.</para>
	/// </summary>
	public class Objetos : MonoBehaviour
	{
		private void Start()
		{
			Personaje personaje = new Personaje(10f, 10f, 5f, 5f);

			personaje.VidaActual = 10f;
			personaje.Atacar();
		}
	}
}