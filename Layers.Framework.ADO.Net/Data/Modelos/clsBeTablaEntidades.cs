using System.Data.SqlClient;
using System.Windows;
using System;

namespace Layers.Framework.ADO.Net.Data.Modelos
{
	public class clsBeTablaEntidades : ICloneable
	{

		private int mIdEntidad = 0;
		private string mDescripcion = "";
		private string mDIRECCION = "";
		private string mLocalidad = "";
		private string mTipoEntidad = "";
		private string mTipoDocumento = "";
		private double mNumeroDocumento = 0.0;
		private string mTelefonos = "";
		private string mURLPAaginaWeb = "";
		private string mURLFACEBOOK = "";
		private string mURLINSTAGRAM = "";
		private string mURLTWITTER = "";
		private string mURLTIKTOK = "";
		private int mIdGrupoEntidad = 0;
		private int mIdTipoEntidad = 0;
		private double mLimiteCredito = 0.0;
		private string mUserNameEntidad = "";
		private string mPassworEntidad = "";
		private string mRolUserEntidad = "";
		private string mComentario = "";
		private string mStatues = "";
		private bool mNoEliminable = false;
		private DateTime mFechaRegistro = DateTime.Now;

		public int IdEntidad
		{
			get
			{
				return mIdEntidad;
			}
			set
			{
				mIdEntidad = value;
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

		public string DIRECCION
		{
			get
			{
				return mDIRECCION;
			}
			set
			{
				mDIRECCION = value;
			}
		}

		public string Localidad
		{
			get
			{
				return mLocalidad;
			}
			set
			{
				mLocalidad = value;
			}
		}

		public string TipoEntidad
		{
			get
			{
				return mTipoEntidad;
			}
			set
			{
				mTipoEntidad = value;
			}
		}

		public string TipoDocumento
		{
			get
			{
				return mTipoDocumento;
			}
			set
			{
				mTipoDocumento = value;
			}
		}

		public double NumeroDocumento
		{
			get
			{
				return mNumeroDocumento;
			}
			set
			{
				mNumeroDocumento = value;
			}
		}

		public string Telefonos
		{
			get
			{
				return mTelefonos;
			}
			set
			{
				mTelefonos = value;
			}
		}

		public string URLPAaginaWeb
		{
			get
			{
				return mURLPAaginaWeb;
			}
			set
			{
				mURLPAaginaWeb = value;
			}
		}

		public string URLFACEBOOK
		{
			get
			{
				return mURLFACEBOOK;
			}
			set
			{
				mURLFACEBOOK = value;
			}
		}

		public string URLINSTAGRAM
		{
			get
			{
				return mURLINSTAGRAM;
			}
			set
			{
				mURLINSTAGRAM = value;
			}
		}

		public string URLTWITTER
		{
			get
			{
				return mURLTWITTER;
			}
			set
			{
				mURLTWITTER = value;
			}
		}

		public string URLTIKTOK
		{
			get
			{
				return mURLTIKTOK;
			}
			set
			{
				mURLTIKTOK = value;
			}
		}

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

		public int IdTipoEntidad
		{
			get
			{
				return mIdTipoEntidad;
			}
			set
			{
				mIdTipoEntidad = value;
			}
		}

		public double LimiteCredito
		{
			get
			{
				return mLimiteCredito;
			}
			set
			{
				mLimiteCredito = value;
			}
		}

		public string UserNameEntidad
		{
			get
			{
				return mUserNameEntidad;
			}
			set
			{
				mUserNameEntidad = value;
			}
		}

		public string PassworEntidad
		{
			get
			{
				return mPassworEntidad;
			}
			set
			{
				mPassworEntidad = value;
			}
		}

		public string RolUserEntidad
		{
			get
			{
				return mRolUserEntidad;
			}
			set
			{
				mRolUserEntidad = value;
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

		public clsBeTablaEntidades()
		{
		}

		public clsBeTablaEntidades(ref int IdEntidad, string Descripcion, string DIRECCION, string Localidad, string TipoEntidad, string TipoDocumento, double NumeroDocumento, string Telefonos, string URLPAaginaWeb, string URLFACEBOOK, string URLINSTAGRAM, string URLTWITTER, string URLTIKTOK, int IdGrupoEntidad, int IdTipoEntidad, double LimiteCredito, string UserNameEntidad, string PassworEntidad, string RolUserEntidad, string Comentario, string Statues, bool NoEliminable, DateTime FechaRegistro)
		{
			mIdEntidad = IdEntidad;
			mDescripcion = Descripcion;
			mDIRECCION = DIRECCION;
			mLocalidad = Localidad;
			mTipoEntidad = TipoEntidad;
			mTipoDocumento = TipoDocumento;
			mNumeroDocumento = NumeroDocumento;
			mTelefonos = Telefonos;
			mURLPAaginaWeb = URLPAaginaWeb;
			mURLFACEBOOK = URLFACEBOOK;
			mURLINSTAGRAM = URLINSTAGRAM;
			mURLTWITTER = URLTWITTER;
			mURLTIKTOK = URLTIKTOK;
			mIdGrupoEntidad = IdGrupoEntidad;
			mIdTipoEntidad = IdTipoEntidad;
			mLimiteCredito = LimiteCredito;
			mUserNameEntidad = UserNameEntidad;
			mPassworEntidad = PassworEntidad;
			mRolUserEntidad = RolUserEntidad;
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
