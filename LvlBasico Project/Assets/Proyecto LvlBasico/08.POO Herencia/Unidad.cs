//                                  ┌∩┐(◣_◢)┌∩┐
//																				\\
// Unidad.cs (01/05/2018)														\\
// Autor: Antonio Mateo (.\Moon Antonio) 	antoniomt.moon@gmail.com			\\
// Descripcion:		Clase base de la unidad.									\\
// Fecha Mod:		01/05/2018													\\
// Ultima Mod:		Version Inicial												\\
//******************************************************************************\\

#region Librerias
using UnityEngine;
#endregion

namespace Clases.lvlBasico
{
	/// <summary>
	/// <para>Clase base de la unidad.</para>
	/// </summary>
	public class Unidad
	{
		protected int vida;
		protected int mana;
		public Tipo tipo;
	}

	public enum Tipo
	{
		Sacerdote,
		Guerrero
	}
}
