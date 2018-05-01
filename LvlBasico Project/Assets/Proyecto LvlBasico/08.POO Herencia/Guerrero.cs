//                                  ┌∩┐(◣_◢)┌∩┐
//																				\\
// Guerrero.cs (01/05/2018)														\\
// Autor: Antonio Mateo (.\Moon Antonio) 	antoniomt.moon@gmail.com			\\
// Descripcion:		Unidad Guerrero.											\\
// Fecha Mod:		01/05/2018													\\
// Ultima Mod:		Version Inicial												\\
//******************************************************************************\\

#region Librerias
using UnityEngine;
#endregion

namespace Clases.lvlBasico
{
	/// <summary>
	/// <para>Unidad Guerrero.</para>
	/// </summary>
	public class Guerrero : Unidad 
	{
		#region Variables Publicas
		public int vidaActual = 10;
		public int manaActual = 10;
		#endregion

		#region Constructor
		public Guerrero()
		{
			vida = 10;
			mana = 10;
			vidaActual = 10;
			manaActual = 10;
			tipo = Tipo.Guerrero;
		}
		#endregion
	}
}
