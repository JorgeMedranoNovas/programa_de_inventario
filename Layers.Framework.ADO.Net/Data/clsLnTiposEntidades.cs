using Layers.Framework.ADO.Net.Data.Modelos;
using System.Data.SqlClient;
using System;
using System.Data;
using Layers.Framework.ADO.Net.Data;


namespace Layers.Framework.ADO.Net.Data
{
	public class clsLnTiposEntidades
	{


		public void Cargar(ref clsBeTiposEntidades oBeTiposEntidades,DataRow dr)
		{
			try
			{
				oBeTiposEntidades.IdTipoEntidad = Convert.ToInt32(dr["IdTipoEntidad"].ToString());


				oBeTiposEntidades.Descripcion = String.IsNullOrEmpty(dr["Descripcion"].ToString()) == true ? "" : dr["Descripcion"].ToString();

				oBeTiposEntidades.IdGrupoEntidad = Convert.ToInt32(dr["IdGrupoEntidad"]);
				oBeTiposEntidades.Comentario = String.IsNullOrEmpty(dr["Comentario"].ToString()) == true ? "" : dr["Comentario"].ToString();
				oBeTiposEntidades.Statues = String.IsNullOrEmpty(dr["Statues"].ToString()) == true ? "" : dr["Statues"].ToString();
				oBeTiposEntidades.NoEliminable = Convert.ToBoolean(dr["NoEliminable"]);
				oBeTiposEntidades.FechaRegistro = Convert.ToDateTime(dr["FechaRegistro"]);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		public int Insertar(ref clsBeTiposEntidades oBeTiposEntidades)
		{
			try
			{
				string sp = "SpTiposEntidadesInsertar";

				SqlConnection cnn = new SqlConnection(BasedeDatos.stringConnection);
				SqlCommand cmd = new SqlCommand(sp, cnn);
				cmd.CommandType = CommandType.StoredProcedure;
				int rowsAffected = 0;
				
				cnn.Open();

				//cmd.Parameters.Add(new SqlParameter("@IDTIPOENTIDAD", oBeTiposEntidades.IdTipoEntidad));
				//cmd.Parameters["@IDTIPOENTIDAD"].Direction = ParameterDirection.Output;
				cmd.Parameters.Add(new SqlParameter("@DESCRIPCION", oBeTiposEntidades.Descripcion));
				cmd.Parameters.Add(new SqlParameter("@IDGRUPOENTIDAD", oBeTiposEntidades.IdGrupoEntidad));
				cmd.Parameters.Add(new SqlParameter("@COMENTARIO", oBeTiposEntidades.Comentario));
				cmd.Parameters.Add(new SqlParameter("@STATUES", oBeTiposEntidades.Statues));
				cmd.Parameters.Add(new SqlParameter("@NOELIMINABLE", oBeTiposEntidades.NoEliminable));
				cmd.Parameters.Add(new SqlParameter("@FECHAREGISTRO", oBeTiposEntidades.FechaRegistro));

				cmd.ExecuteNonQuery();
				cmd.Parameters.Clear();
				cnn.Close();
				return rowsAffected;

			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		public int Actualizar(ref clsBeTiposEntidades oBeTiposEntidades)
		{
			try
			{
				string sp = "SpTiposEntidadesActualizar";

				SqlConnection cnn = new SqlConnection(BasedeDatos.stringConnection);
				SqlCommand cmd = new SqlCommand(sp, cnn);
				cmd.CommandType = CommandType.StoredProcedure;
				int rowsAffected = 0;
				cnn.Open();

				cmd.Parameters.Add(new SqlParameter("@IDTIPOENTIDAD", oBeTiposEntidades.IdTipoEntidad));
				cmd.Parameters.Add(new SqlParameter("@DESCRIPCION", oBeTiposEntidades.Descripcion));
				cmd.Parameters.Add(new SqlParameter("@IDGRUPOENTIDAD", oBeTiposEntidades.IdGrupoEntidad));
				cmd.Parameters.Add(new SqlParameter("@COMENTARIO", oBeTiposEntidades.Comentario));
				cmd.Parameters.Add(new SqlParameter("@STATUES", oBeTiposEntidades.Statues));
				cmd.Parameters.Add(new SqlParameter("@NOELIMINABLE", oBeTiposEntidades.NoEliminable));
				cmd.Parameters.Add(new SqlParameter("@FECHAREGISTRO", oBeTiposEntidades.FechaRegistro));

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

		public int Eliminar(ref clsBeTiposEntidades oBeTiposEntidades)
		{
			try
			{
				string sp = "SpTiposEntidadesEliminar";

				SqlConnection cnn = new SqlConnection(BasedeDatos.stringConnection);
				SqlCommand cmd = new SqlCommand(sp, cnn);
				cmd.CommandType = CommandType.StoredProcedure;
				int rowsAffected = 0;
				cnn.Open();

				cmd.Parameters.Add(new SqlParameter("@IDTIPOENTIDAD", oBeTiposEntidades.IdTipoEntidad));

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
				string sp = "SpTiposEntidadesListar";

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

		public bool Obtener(ref clsBeTiposEntidades oBeTiposEntidades)
		{
			try
			{
				string sp = "SpTiposEntidadesObtener";

				SqlConnection cnn = new SqlConnection(BasedeDatos.stringConnection);
				SqlCommand cmd = new SqlCommand(sp, cnn);
				cmd.CommandType = CommandType.StoredProcedure;

				SqlDataAdapter dad = new SqlDataAdapter(cmd);
				dad.SelectCommand.Parameters.Add(new SqlParameter("@IDTIPOENTIDAD", oBeTiposEntidades.IdTipoEntidad));

				DataTable dt = new DataTable();
				dad.Fill(dt);

				if ((dt.Rows.Count == 1))
				{
					Cargar( ref oBeTiposEntidades, dt.Rows[0]);
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
