using System.Data.SqlClient;
using System.Data;
using System;
using Entidades.Capas.Data;
using Entidades.Capas.Data.Model;

public class clsLnEntidades
{



	public void Cargar(ref clsBeEntidades oBeEntidades, DataRow dr)
	{
		try
		{
			//oBeEntidades.IdEntidad = Convert.ToInt32(dr["IdEntidad"].ToString());
			//oBeEntidades.Descripcion = String.IsNullOrEmpty(dr["Descripcion"].ToString()) == true ? "" : dr["Descripcion"].ToString();
			//oBeEntidades.Direccion = String.IsNullOrEmpty(dr["Direccion"].ToString()) == true ? "" : dr["Direccion"].ToString();
			//oBeEntidades.Localidad = String.IsNullOrEmpty(dr["Localidad"].ToString()) == true ? "" : dr["Localidad"].ToString();
			//oBeEntidades.TipoEntidad = String.IsNullOrEmpty(dr["TipoEntidad"].ToString()) == true ? "" : dr["TipoEntidad"].ToString();
			//oBeEntidades.TipoDocumento = String.IsNullOrEmpty(dr["TipoDocumento"].ToString()) == true ? "" : dr["TipoDocumento"].ToString();
			//oBeEntidades.NumeroDocumento = Convert.ToInt32(dr["NumeroDocumento"]);
			//oBeEntidades.Telefonos = String.IsNullOrEmpty(dr["Telefonos"].ToString()) == true ? "" : dr["Telefonos"].ToString();
			//oBeEntidades.URLPaginaWeb = String.IsNullOrEmpty(dr["URLPaginaWeb"].ToString()) == true ? "" : dr["URLPaginaWeb"].ToString();
			//oBeEntidades.URLFacebook = String.IsNullOrEmpty(dr["URLFacebook"].ToString()) == true ? "" : dr["URLFacebook"].ToString();
			//oBeEntidades.URLInstagram = String.IsNullOrEmpty(dr["URLInstagram"].ToString()) == true ? "" : dr["URLInstagram"].ToString();
			//oBeEntidades.URLTwitter = String.IsNullOrEmpty(dr["URLTwitter"].ToString()) == true ? "" : dr["URLTwitter"].ToString();
			//oBeEntidades.URLTikTok = String.IsNullOrEmpty(dr["URLTikTok"].ToString()) == true ? "" : dr["URLTikTok"].ToString();
			//oBeEntidades.CodigoPostal = String.IsNullOrEmpty(dr["CodigoPostal"].ToString()) == true ? "" : dr["CodigoPostal"].ToString();
			//oBeEntidades.CoordenadasGPS = String.IsNullOrEmpty(dr["CoordenadasGPS"].ToString()) == true ? "" : dr["CoordenadasGPS"].ToString();
			//oBeEntidades.LimiteCredito = Convert.ToInt32(dr["LimiteCredito"]);
			oBeEntidades.UserNameEntidad = String.IsNullOrEmpty(dr["UserNameEntidad"].ToString()) == true ? "" : dr["UserNameEntidad"].ToString();
			oBeEntidades.PasswordEntidad = String.IsNullOrEmpty(dr["PasswordEntidad"].ToString()) == true ? "" : dr["PasswordEntidad"].ToString();
			//oBeEntidades.RolUserEntidad = String.IsNullOrEmpty(dr["RolUserEntidad"].ToString()) == true ? "" : dr["RolUserEntidad"].ToString();
			//oBeEntidades.Comentario = String.IsNullOrEmpty(dr["Comentario"].ToString()) == true ? "" : dr["Comentario"].ToString();
			//oBeEntidades.Staatus = String.IsNullOrEmpty(dr["Staatus"].ToString()) == true ? "" : dr["Staatus"].ToString();
			//oBeEntidades.NoEliminable = Convert.ToBoolean(dr["NoEliminable"]);
			//oBeEntidades.FechaRegistro = Convert.ToDateTime(dr["FechaRegistro"]);

		}
		catch (Exception ex)
		{
			throw ex;
		}
	}

	public int Insertar(ref clsBeEntidades oBeEntidades)
	{
		try
		{
			string sp = "SpEntidadesInsertar";

			SqlConnection cnn = new SqlConnection(ConexDB.sConnection);
			SqlCommand cmd = new SqlCommand(sp, cnn);
			cmd.CommandType = CommandType.StoredProcedure;

			int rowsAffected = 0;
			cnn.Open();


			cmd.Parameters.Add(new SqlParameter("@DESCRIPCION", oBeEntidades.Descripcion));
			cmd.Parameters.Add(new SqlParameter("@DIRECCION", oBeEntidades.Direccion));
			cmd.Parameters.Add(new SqlParameter("@LOCALIDAD", oBeEntidades.Localidad));
			cmd.Parameters.Add(new SqlParameter("@TIPOENTIDAD", oBeEntidades.TipoEntidad));
			cmd.Parameters.Add(new SqlParameter("@TIPODOCUMENTO", oBeEntidades.TipoDocumento));
			cmd.Parameters.Add(new SqlParameter("@NUMERODOCUMENTO", oBeEntidades.NumeroDocumento));
			cmd.Parameters.Add(new SqlParameter("@TELEFONOS", oBeEntidades.Telefonos));
			cmd.Parameters.Add(new SqlParameter("@URLPAGINAWEB", oBeEntidades.URLPaginaWeb));
			cmd.Parameters.Add(new SqlParameter("@URLFACEBOOK", oBeEntidades.URLFacebook));
			cmd.Parameters.Add(new SqlParameter("@URLINSTAGRAM", oBeEntidades.URLInstagram));
			cmd.Parameters.Add(new SqlParameter("@URLTWITTER", oBeEntidades.URLTwitter));
			cmd.Parameters.Add(new SqlParameter("@URLTIKTOK", oBeEntidades.URLTikTok));
			cmd.Parameters.Add(new SqlParameter("@CODIGOPOSTAL", oBeEntidades.CodigoPostal));
			cmd.Parameters.Add(new SqlParameter("@COORDENADASGPS", oBeEntidades.CoordenadasGPS));
			cmd.Parameters.Add(new SqlParameter("@LIMITECREDITO", oBeEntidades.LimiteCredito));
			cmd.Parameters.Add(new SqlParameter("@USERNAMEENTIDAD", oBeEntidades.UserNameEntidad));
			cmd.Parameters.Add(new SqlParameter("@PasswordEntidad", oBeEntidades.PasswordEntidad));
			cmd.Parameters.Add(new SqlParameter("@ROLUSERENTIDAD", oBeEntidades.RolUserEntidad));
			cmd.Parameters.Add(new SqlParameter("@COMENTARIO", oBeEntidades.Comentario));
			cmd.Parameters.Add(new SqlParameter("@STAATUS", oBeEntidades.Staatus));
			cmd.Parameters.Add(new SqlParameter("@NOELIMINABLE", oBeEntidades.NoEliminable));
			cmd.Parameters.Add(new SqlParameter("@FECHAREGISTRO", oBeEntidades.FechaRegistro));

			rowsAffected = cmd.ExecuteNonQuery();

			return rowsAffected;

		}
		catch (Exception ex)
		{
			throw ex;
		}
	}

	public int Actualizar(ref clsBeEntidades oBeEntidades)
	{
		try
		{
			string sp = "SpEntidadesActualizar";

			SqlConnection cnn = new SqlConnection(ConexDB.sConnection);
			SqlCommand cmd = new SqlCommand(sp, cnn);
			cmd.CommandType = CommandType.StoredProcedure;


			int rowsAffected = 0;
			cnn.Open();

			cmd.Parameters.Add(new SqlParameter("@IDENTIDAD", oBeEntidades.IdEntidad));
			cmd.Parameters.Add(new SqlParameter("@DESCRIPCION", oBeEntidades.Descripcion));
			cmd.Parameters.Add(new SqlParameter("@DIRECCION", oBeEntidades.Direccion));
			cmd.Parameters.Add(new SqlParameter("@LOCALIDAD", oBeEntidades.Localidad));
			cmd.Parameters.Add(new SqlParameter("@TIPOENTIDAD", oBeEntidades.TipoEntidad));
			cmd.Parameters.Add(new SqlParameter("@TIPODOCUMENTO", oBeEntidades.TipoDocumento));
			cmd.Parameters.Add(new SqlParameter("@NUMERODOCUMENTO", oBeEntidades.NumeroDocumento));
			cmd.Parameters.Add(new SqlParameter("@TELEFONOS", oBeEntidades.Telefonos));
			cmd.Parameters.Add(new SqlParameter("@URLPAGINAWEB", oBeEntidades.URLPaginaWeb));
			cmd.Parameters.Add(new SqlParameter("@URLFACEBOOK", oBeEntidades.URLFacebook));
			cmd.Parameters.Add(new SqlParameter("@URLINSTAGRAM", oBeEntidades.URLInstagram));
			cmd.Parameters.Add(new SqlParameter("@URLTWITTER", oBeEntidades.URLTwitter));
			cmd.Parameters.Add(new SqlParameter("@URLTIKTOK", oBeEntidades.URLTikTok));
			cmd.Parameters.Add(new SqlParameter("@CODIGOPOSTAL", oBeEntidades.CodigoPostal));
			cmd.Parameters.Add(new SqlParameter("@COORDENADASGPS", oBeEntidades.CoordenadasGPS));
			cmd.Parameters.Add(new SqlParameter("@LIMITECREDITO", oBeEntidades.LimiteCredito));
			cmd.Parameters.Add(new SqlParameter("@USERNAMEENTIDAD", oBeEntidades.UserNameEntidad));
			cmd.Parameters.Add(new SqlParameter("@PASSWORDENTIDAD", oBeEntidades.PasswordEntidad));
			cmd.Parameters.Add(new SqlParameter("@ROLUSERENTIDAD", oBeEntidades.RolUserEntidad));
			cmd.Parameters.Add(new SqlParameter("@COMENTARIO", oBeEntidades.Comentario));
			cmd.Parameters.Add(new SqlParameter("@STAATUS", oBeEntidades.Staatus));
			cmd.Parameters.Add(new SqlParameter("@NOELIMINABLE", oBeEntidades.NoEliminable));
			cmd.Parameters.Add(new SqlParameter("@FECHAREGISTRO", oBeEntidades.FechaRegistro));

			rowsAffected = cmd.ExecuteNonQuery();

			return rowsAffected;

		}
		catch (Exception ex)
		{
			throw ex;
		}
	}

	public int Eliminar(ref clsBeEntidades oBeEntidades)
	{
		try
		{
			string sp = "SpEntidadesEliminar";

			SqlConnection cnn = new SqlConnection(ConexDB.sConnection);
			SqlCommand cmd = new SqlCommand(sp, cnn);
			cmd.CommandType = CommandType.StoredProcedure;


			int rowsAffected = 0;
			cnn.Open();

			cmd.Parameters.Add(new SqlParameter("@IDENTIDAD", oBeEntidades.IdEntidad));

			rowsAffected = cmd.ExecuteNonQuery();

			return rowsAffected;

		}
		catch (Exception ex)
		{
			throw ex;
		}
	}

	public DataTable Listar()
	{
		try
		{
			string sp = "SpEntidadesListar";

			SqlConnection cnn = new SqlConnection(ConexDB.sConnection);
			SqlCommand cmd = new SqlCommand(sp, cnn);
			cmd.CommandType = CommandType.StoredProcedure;

			SqlDataAdapter dad = new SqlDataAdapter(cmd);

			DataTable dt = new DataTable();
			dad.Fill(dt);

			return dt;

		}
		catch (Exception ex)
		{
			throw ex;
		}
	}

	public bool Obtener(ref clsBeEntidades oBeEntidades)
	{
		try
		{
			string sp = "spLoginEntidades";

			SqlConnection cnn = new SqlConnection(ConexDB.sConnection);
			SqlCommand cmd = new SqlCommand(sp, cnn);
			cmd.CommandType = CommandType.StoredProcedure;

			SqlDataAdapter dad = new SqlDataAdapter(cmd);
			dad.SelectCommand.Parameters.Add(new SqlParameter("@UserNameEntidad", oBeEntidades.UserNameEntidad));
			dad.SelectCommand.Parameters.Add(new SqlParameter("@PasswordEntidad", oBeEntidades.PasswordEntidad));

			DataTable dt = new DataTable();
			dad.Fill(dt);

			if ((dt.Rows.Count == 1))
			{
				Cargar(ref oBeEntidades, dt.Rows[0]);
			}
			else
			{
				throw new Exception("No se pudo obtener el registro");
			}

			return true;

		}
		catch (Exception ex)
		{
			throw ex;
		}
	}


	public DataTable ObtenerEntidad(ref clsBeEntidades oBEntidades)
	{
		try
		{
			string sp = "SpEntidadesObtener";

			SqlConnection cnn = new SqlConnection(ConexDB.sConnection);
			SqlCommand cmd = new SqlCommand(sp, cnn);
			cmd.CommandType = CommandType.StoredProcedure;

			SqlDataAdapter dad = new SqlDataAdapter(cmd);
			dad.SelectCommand.Parameters.Add(new SqlParameter("@IDENTIDAD", oBEntidades.IdEntidad));

			DataTable dt = new DataTable();
			dad.Fill(dt);

			return dt;

		}
		catch (Exception ex)
		{
			throw ex;
		}
	}


	



}
