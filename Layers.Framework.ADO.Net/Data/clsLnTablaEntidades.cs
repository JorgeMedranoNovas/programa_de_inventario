using Layers.Framework.ADO.Net.Data.Modelos;
using System.Data.SqlClient;
using System;
using System.Data;
using Layers.Framework.ADO.Net.Data;

namespace Layers.Framework.ADO.Net.Data
{
	public class clsLnTablaEntidades
	{

		

		public void Cargar(ref clsBeTablaEntidades oBeTablaEntidades, DataRow dr)
		{
			try
			{
			
				oBeTablaEntidades.UserNameEntidad = String.IsNullOrEmpty(dr["UserNameEntidad"].ToString()) == true ? "" : dr["UserNameEntidad"].ToString();
				oBeTablaEntidades.PassworEntidad = String.IsNullOrEmpty(dr["PassworEntidad"].ToString()) == true ? "" : dr["PassworEntidad"].ToString();

			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		public bool Insertar(ref clsBeTablaEntidades oBeTablaEntidades)
		{
			try
			{
				string sp = "SpTablaEntidadesInsertar";
				SqlConnection cnn = new SqlConnection(BasedeDatos.stringConnection);
				SqlCommand cmd = new SqlCommand(sp, cnn);
				cmd.CommandType = CommandType.StoredProcedure;
				//int rowsAffected = 0;
				cnn.Open();

				cmd.Parameters.Add(new SqlParameter("@Descripcion", oBeTablaEntidades.Descripcion));
				cmd.Parameters.Add(new SqlParameter("@DIRECCION", oBeTablaEntidades.DIRECCION));
				cmd.Parameters.Add(new SqlParameter("@Localidad", oBeTablaEntidades.Localidad));
				cmd.Parameters.Add(new SqlParameter("@TipoEntidad", oBeTablaEntidades.TipoEntidad));
				cmd.Parameters.Add(new SqlParameter("@TipoDocumento", oBeTablaEntidades.TipoDocumento));
				cmd.Parameters.Add(new SqlParameter("@NumeroDocumento", oBeTablaEntidades.NumeroDocumento));
				cmd.Parameters.Add(new SqlParameter("@Telefonos", oBeTablaEntidades.Telefonos));
				//cmd.Parameters.Add(new SqlParameter("@URLPAaginaWeb", oBeTablaEntidades.URLPAaginaWeb));
				cmd.Parameters.Add(new SqlParameter("@URLFACEBOOK", oBeTablaEntidades.URLFACEBOOK));
				/*cmd.Parameters.Add(new SqlParameter("@URLINSTAGRAM", oBeTablaEntidades.URLINSTAGRAM));
				cmd.Parameters.Add(new SqlParameter("@URLTWITTER", oBeTablaEntidades.URLTWITTER));
				cmd.Parameters.Add(new SqlParameter("@URLTIKTOK", oBeTablaEntidades.URLTIKTOK));
				cmd.Parameters.Add(new SqlParameter("@IdGrupoEntidad", oBeTablaEntidades.IdGrupoEntidad));
				cmd.Parameters.Add(new SqlParameter("@IdTipoEntidad", oBeTablaEntidades.IdTipoEntidad));*/

				cmd.Parameters.Add(new SqlParameter("@UserNameEntidad", oBeTablaEntidades.UserNameEntidad));
				cmd.Parameters.Add(new SqlParameter("@PassworEntidad", oBeTablaEntidades.PassworEntidad));
				cmd.Parameters.Add(new SqlParameter("@RolUserEntidad", oBeTablaEntidades.RolUserEntidad));
				//cmd.Parameters.Add(new SqlParameter("@Comentario", oBeTablaEntidades.Comentario));
				cmd.Parameters.Add(new SqlParameter("@Statues", oBeTablaEntidades.Statues));
				/*cmd.Parameters.Add(new SqlParameter("@NoEliminable", oBeTablaEntidades.NoEliminable));
				cmd.Parameters.Add(new SqlParameter("@FechaRegistro", oBeTablaEntidades.FechaRegistro));*/

				cmd.ExecuteNonQuery();
				cmd.Parameters.Clear();
				cnn.Close();
				
				return true;

			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		public int Actualizar(ref clsBeTablaEntidades oBeTablaEntidades)
		{
			try
			{
				string sp = "SpTablaEntidadesActualizar";

				SqlConnection cnn = new SqlConnection(BasedeDatos.stringConnection);
			
				SqlCommand cmd = new SqlCommand(sp, cnn);
				cmd.CommandType = CommandType.StoredProcedure;
				int rowsAffected = 0;
				cnn.Open();

				cmd.Parameters.Add(new SqlParameter("@IDENTIDAD", oBeTablaEntidades.IdEntidad));
				cmd.Parameters.Add(new SqlParameter("@DESCRIPCION", oBeTablaEntidades.Descripcion));
				cmd.Parameters.Add(new SqlParameter("@DIRECCION", oBeTablaEntidades.DIRECCION));
				cmd.Parameters.Add(new SqlParameter("@LOCALIDAD", oBeTablaEntidades.Localidad));
				cmd.Parameters.Add(new SqlParameter("@TIPOENTIDAD", oBeTablaEntidades.TipoEntidad));
				cmd.Parameters.Add(new SqlParameter("@TIPODOCUMENTO", oBeTablaEntidades.TipoDocumento));
				cmd.Parameters.Add(new SqlParameter("@NUMERODOCUMENTO", oBeTablaEntidades.NumeroDocumento));
				cmd.Parameters.Add(new SqlParameter("@TELEFONOS", oBeTablaEntidades.Telefonos));
				cmd.Parameters.Add(new SqlParameter("@URLPAAGINAWEB", oBeTablaEntidades.URLPAaginaWeb));
				cmd.Parameters.Add(new SqlParameter("@URLFACEBOOK", oBeTablaEntidades.URLFACEBOOK));
				cmd.Parameters.Add(new SqlParameter("@URLINSTAGRAM", oBeTablaEntidades.URLINSTAGRAM));
				cmd.Parameters.Add(new SqlParameter("@URLTWITTER", oBeTablaEntidades.URLTWITTER));
				cmd.Parameters.Add(new SqlParameter("@URLTIKTOK", oBeTablaEntidades.URLTIKTOK));
				cmd.Parameters.Add(new SqlParameter("@IDGRUPOENTIDAD", oBeTablaEntidades.IdGrupoEntidad));
				cmd.Parameters.Add(new SqlParameter("@IDTIPOENTIDAD", oBeTablaEntidades.IdTipoEntidad));
				cmd.Parameters.Add(new SqlParameter("@LIMITECREDITO", oBeTablaEntidades.LimiteCredito));
				cmd.Parameters.Add(new SqlParameter("@USERNAMEENTIDAD", oBeTablaEntidades.UserNameEntidad));
				cmd.Parameters.Add(new SqlParameter("@PASSWORENTIDAD", oBeTablaEntidades.PassworEntidad));
				cmd.Parameters.Add(new SqlParameter("@ROLUSERENTIDAD", oBeTablaEntidades.RolUserEntidad));
				cmd.Parameters.Add(new SqlParameter("@COMENTARIO", oBeTablaEntidades.Comentario));
				cmd.Parameters.Add(new SqlParameter("@STATUES", oBeTablaEntidades.Statues));
				cmd.Parameters.Add(new SqlParameter("@NOELIMINABLE", oBeTablaEntidades.NoEliminable));
				cmd.Parameters.Add(new SqlParameter("@FECHAREGISTRO", oBeTablaEntidades.FechaRegistro));

				rowsAffected = cmd.ExecuteNonQuery();
				cmd.Parameters.Clear();
				cnn.Close();
				return rowsAffected;

			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		public int Eliminar(ref clsBeTablaEntidades oBeTablaEntidades)
		{
			try
			{
				string sp = "SpTablaEntidadesEliminar";

				SqlConnection cnn = new SqlConnection(BasedeDatos.stringConnection);
				SqlCommand cmd = new SqlCommand(sp, cnn);
				cmd.CommandType = CommandType.StoredProcedure;

				int rowsAffected = 0;
				cnn.Open();

				cmd.Parameters.Add(new SqlParameter("@IDENTIDAD", oBeTablaEntidades.IdEntidad));

				rowsAffected = cmd.ExecuteNonQuery();
				cmd.Parameters.Clear();
				cnn.Close();
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
				string sp = "SpTablaEntidadesListar";

				SqlConnection cnn = new SqlConnection(BasedeDatos.stringConnection);
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

		public bool Obtener(ref clsBeTablaEntidades oBeTablaEntidades)
		{
			try
			{
				string sp = "SpTablaEntidadesObtener";


				SqlConnection cnn = new SqlConnection(BasedeDatos.stringConnection);
				SqlCommand cmd = new SqlCommand(sp, cnn);
				cmd.CommandType = CommandType.StoredProcedure;

				SqlDataAdapter dad = new SqlDataAdapter(cmd);
				dad.SelectCommand.Parameters.Add(new SqlParameter("@IDENTIDAD", oBeTablaEntidades.IdEntidad));

				DataTable dt = new DataTable();
				dad.Fill(dt);

				if ((dt.Rows.Count == 1))
				{
					Cargar(ref oBeTablaEntidades, dt.Rows[0]);
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
		public bool Obtenerusario (ref clsBeTablaEntidades oBeTablaEntidades)
		{
			try
			{
				string sp = "SpLoginEntidades";

				SqlConnection cnn = new SqlConnection(BasedeDatos.stringConnection);
				SqlCommand cmd = new SqlCommand(sp, cnn);
				cmd.CommandType = CommandType.StoredProcedure;

				SqlDataAdapter dad = new SqlDataAdapter(cmd);
				dad.SelectCommand.Parameters.Add(new SqlParameter("@UserNameEntidad", oBeTablaEntidades.UserNameEntidad));
				dad.SelectCommand.Parameters.Add(new SqlParameter("@PassworEntidad", oBeTablaEntidades.PassworEntidad));

				DataTable dt = new DataTable();
				dad.Fill(dt);

				if ((dt.Rows.Count == 1))
				{
					Cargar(ref oBeTablaEntidades, dt.Rows[0]);
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


	}


}
