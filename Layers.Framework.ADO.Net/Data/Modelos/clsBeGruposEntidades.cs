using System.Data.SqlClient;
using System.Windows;
using System;

namespace Layers.Framework.ADO.Net.Data.Modelos
{
	public class clsBeGruposEntidades : ICloneable
	{

		private int mIdGrupoEntidad = 0;
		private string mDescripcion = "";
		private string mComentario = "";
		private string mStatues = "";
		private bool mNoEliminable = false;
		private DateTime mFechaRegistro = DateTime.Now;

		public int IdGrupoEntidad
		{
			get
			{
				return mIdGrupoEntidad;
			}
			set
			{
				mIdGrupoEntidad = value;
			}
		}

		public string Descripcion
		{
			get
			{
				return mDescripcion;
			}
			set
			{
				mDescripcion = value;
			}
		}

		public string Comentario
		{
			get
			{
				return mComentario;
			}
			set
			{
				mComentario = value;
			}
		}

		public string Statues
		{
			get
			{
				return mStatues;
			}
			set
			{
				mStatues = value;
			}
		}

		public Boolean NoEliminable
		{
			get
			{
				return mNoEliminable;
			}
			set
			{
				mNoEliminable = value;
			}
		}

		public DateTime FechaRegistro
		{
			get
			{
				return mFechaRegistro;
			}
			set
			{
				mFechaRegistro = value;
			}
		}

		public clsBeGruposEntidades()
		{
		}

		public clsBeGruposEntidades(ref int IdGrupoEntidad, string Descripcion, string Comentario, string Statues, bool NoEliminable, DateTime FechaRegistro)
		{ 
			mIdGrupoEntidad = IdGrupoEntidad;
			mDescripcion = Descripcion;
			mComentario = Comentario;
			mStatues = Statues;
			mNoEliminable = NoEliminable;
			mFechaRegistro = FechaRegistro;
		}

		public object Clone()
		{
			return base.MemberwiseClone();
		}

	}

}
