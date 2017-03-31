//                                  ┌∩┐(◣_◢)┌∩┐
//																				\\
// ControlGraph.cs (31/03/2017)													\\
// Autor: Antonio Mateo (Moon Antonio) 									        \\
// Descripcion:		Control del graph											\\
// Fecha Mod:		31/03/2017													\\
// Ultima Mod:		Version Inicial												\\
//******************************************************************************\\

#region Librerias
using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;
#endregion

namespace MoonAntonio
{
	/// <summary>
	/// <para>Control del graph</para>
	/// </summary>
	public class ControlGraph : MonoBehaviour 
	{
		#region Variables Publicas
		/// <summary>
		/// <para>Valores del graph.</para>
		/// </summary>
		public List<float> valores = new List<float>();			// Valores del graph
		/// <summary>
		/// <para>Colores del graph.</para>
		/// </summary>
		public List<Color> colores = new List<Color>();			// Colores del graph
		/// <summary>
		/// <para>Prefab de la pieza del graph.</para>
		/// </summary>
		public Image prefab;                                    // Prefab de la pieza del graph
		#endregion

		#region Init
		/// <summary>
		/// <para>Init de ControlGraph.</para>
		/// </summary>
		private void Start()// Init de ControlGraph
		{
			// Inicializar Graph
			CrearGraph();
		}
		#endregion

		#region API
		/// <summary>
		/// <para>Agrega una nueva pieza al graph.</para>
		/// </summary>
		public void AddPieza()// Agrega una nueva pieza al graph
		{

		}
		#endregion

		#region Metodos
		/// <summary>
		/// <para>Crea un graph.</para>
		/// </summary>
		private void CrearGraph()// Crea un graph
		{

		}
		#endregion
	}
}
