using System.Data.SqlClient;
using System.Windows;
using System;

namespace Entidades.Capas.Data.Model

{
	public class clsBeEntidades : ICloneable
	{

		private int mIdEntidad = 0;
		private string mDescripcion = "";
		private string mDireccion = "";
		private string mLocalidad = "";
		private string mTipoEntidad = "";
		private string mTipoDocumento = "";
		private int mNumeroDocumento = 0;
		private string mTelefonos = "";
		private string mURLPaginaWeb = "";
		private string mURLFacebook = "";
		private string mURLInstagram = "";
		private string mURLTwitter = "";
		private string mURLTikTok = "";
		private string mCodigoPostal = "";
		private string mCoordenadasGPS = "";
		private double mLimiteCredito = 0.0;
		private string mUserNameEntidad = "";
		private string mPasswordEntidad = "";
		private string mRolUserEntidad = "";
		private string mComentario = "";
		private string mStaatus = "";
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

		public string Direccion
		{
			get
			{
				return mDireccion;
			}
			set
			{
				mDireccion = value;
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

		public int NumeroDocumento
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

		public string URLPaginaWeb
		{
			get
			{
				return mURLPaginaWeb;
			}
			set
			{
				mURLPaginaWeb = value;
			}
		}

		public string URLFacebook
		{
			get
			{
				return mURLFacebook;
			}
			set
			{
				mURLFacebook = value;
			}
		}

		public string URLInstagram
		{
			get
			{
				return mURLInstagram;
			}
			set
			{
				mURLInstagram = value;
			}
		}

		public string URLTwitter
		{
			get
			{
				return mURLTwitter;
			}
			set
			{
				mURLTwitter = value;
			}
		}

		public string URLTikTok
		{
			get
			{
				return mURLTikTok;
			}
			set
			{
				mURLTikTok = value;
			}
		}

		public string CodigoPostal
		{
			get
			{
				return mCodigoPostal;
			}
			set
			{
				mCodigoPostal = value;
			}
		}

		public string CoordenadasGPS
		{
			get
			{
				return mCoordenadasGPS;
			}
			set
			{
				mCoordenadasGPS = value;
			}
		}

		public Double LimiteCredito
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

		public string PasswordEntidad
		{
			get
			{
				return mPasswordEntidad;
			}
			set
			{
				mPasswordEntidad = value;
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

		public string Staatus
		{
			get
			{
				return mStaatus;
			}
			set
			{
				mStaatus = value;
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

		public clsBeEntidades()
		{
		}

		public clsBeEntidades(ref int IdEntidad, string Descripcion, string Direccion, string Localidad, string TipoEntidad, string TipoDocumento, int NumeroDocumento, string Telefonos, string URLPaginaWeb, string URLFacebook, string URLInstagram, string URLTwitter, string URLTikTok, string CodigoPostal, string CoordenadasGPS, double LimiteCredito, string UserNameEntidad, string PasswordEntidad, string RolUserEntidad, string Comentario, string Staatus, bool NoEliminable, DateTime FechaRegistro)

		{
			mIdEntidad = IdEntidad;
			mDescripcion = Descripcion;
			mDireccion = Direccion;
			mLocalidad = Localidad;
			mTipoEntidad = TipoEntidad;
			mTipoDocumento = TipoDocumento;
			mNumeroDocumento = NumeroDocumento;
			mTelefonos = Telefonos;
			mURLPaginaWeb = URLPaginaWeb;
			mURLFacebook = URLFacebook;
			mURLInstagram = URLInstagram;
			mURLTwitter = URLTwitter;
			mURLTikTok = URLTikTok;
			mCodigoPostal = CodigoPostal;
			mCoordenadasGPS = CoordenadasGPS;
			mLimiteCredito = LimiteCredito;
			mUserNameEntidad = UserNameEntidad;
			mPasswordEntidad = PasswordEntidad;
			mRolUserEntidad = RolUserEntidad;
			mComentario = Comentario;
			mStaatus = Staatus;
			mNoEliminable = NoEliminable;
			mFechaRegistro = FechaRegistro;
		}

		public object Clone()
		{
			return base.MemberwiseClone();
		}

	}



}
