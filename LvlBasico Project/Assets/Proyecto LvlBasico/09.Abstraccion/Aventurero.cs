//                                  ┌∩┐(◣_◢)┌∩┐
//																				\\
// Aventurero.cs (01/05/2018)													\\
// Autor: Antonio Mateo (.\Moon Antonio) 	antoniomt.moon@gmail.com			\\
// Descripcion:		Clase hija de unidad.										\\
// Fecha Mod:		01/05/2018													\\
// Ultima Mod:		Version Inicial												\\
//******************************************************************************\\

#region Librerias
using UnityEngine;
#endregion

namespace Clases.lvlBasico
{
	/// <summary>
	/// <para>Clase hija de unidad.</para>
	/// </summary>
	public class Aventurero : UnidadAbstracta 
	{
		public override void Nacer()
		{
			
		}

		public override void Andar()
		{
			base.Andar();

			Debug.Log("Andando.");
		}
	}
}
