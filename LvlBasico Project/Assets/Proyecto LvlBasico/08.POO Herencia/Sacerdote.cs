//                                  ┌∩┐(◣_◢)┌∩┐
//																				\\
// Sacerdote.cs (01/05/2018)													\\
// Autor: Antonio Mateo (.\Moon Antonio) 	antoniomt.moon@gmail.com			\\
// Descripcion:		Unidad Sacerdote.											\\
// Fecha Mod:		01/05/2018													\\
// Ultima Mod:		Version Inicial												\\
//******************************************************************************\\

#region Librerias
using UnityEngine;
#endregion

namespace Clases.lvlBasico
{
	/// <summary>
	/// <para>Unidad Sacerdote.</para>
	/// </summary>
	public class Sacerdote : Unidad 
	{
		#region Variables Publicas
		public int vidaActual = 10;
		public int manaActual = 10;
		#endregion

		#region Constructor
		public Sacerdote()
		{
			vida = 10;
			mana = 10;
			vidaActual = 10;
			manaActual = 10;
			tipo = Tipo.Sacerdote;
		}
		#endregion
	}
}
