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

		#region Variables Privadas
		/// <summary>
		/// <para>Total de los valores del graph.</para>
		/// </summary>
		private float total = 0.0f;								// Total de los valores del graph
		/// <summary>
		/// <para>Rotacion en Z</para>
		/// </summary>
		private float rotZ = 0.0f;								// Rotacion en Z
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
		/// <para>Agrega una nueva pieza al graph</para>
		/// </summary>
		/// <param name="id">Id de la posicion en al lista.</param>
		/// <param name="valorTotal">Valor de los totales.</param>
		/// <param name="rotacionZ">Rotacion en Z</param>
		public void AddPieza(int id, float valorTotal, float rotacionZ)// Agrega una nueva pieza al graph
		{
			Image nuevaPieza = Instantiate(prefab) as Image;

			nuevaPieza.transform.SetParent(transform, false);
			nuevaPieza.color = colores[id];
			nuevaPieza.fillAmount = valores[id] / valorTotal;
			nuevaPieza.transform.rotation = Quaternion.Euler(new Vector3(0f, 0f, rotacionZ));
			rotZ -= nuevaPieza.fillAmount * 360f;
		}
		#endregion

		#region Metodos
		/// <summary>
		/// <para>Crea un graph.</para>
		/// </summary>
		private void CrearGraph()// Crea un graph
		{
			// Agregar los valores al total
			for (int n = 0; n < valores.Count; n++)
			{
				total += valores[n];
			}

			// Agregar las piezas
			for (int i = 0; i < valores.Count; i++)
			{
				AddPieza(i, total, rotZ);
			}
		}
		#endregion
	}
}
