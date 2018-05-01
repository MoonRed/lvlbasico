//                                  ┌∩┐(◣_◢)┌∩┐
//																				\\
// UnidadAbstracta.cs (01/05/2018)												\\
// Autor: Antonio Mateo (.\Moon Antonio) 	antoniomt.moon@gmail.com			\\
// Descripcion:		Superclase unidad, contiene las propiedades comunes.		\\
// Fecha Mod:		01/05/2018													\\
// Ultima Mod:		Version Inicial.											\\
//******************************************************************************\\

#region Librerias
using UnityEngine;
#endregion

namespace Clases.lvlBasico
{
	/// <summary>
	/// <para>Superclase unidad, contiene las propiedades comunes.</para>
	/// </summary>
	public abstract class UnidadAbstracta
	{
		public abstract void Nacer();

		public virtual void Andar()
		{
			Debug.Log("Andando.");
		}
	}
}
