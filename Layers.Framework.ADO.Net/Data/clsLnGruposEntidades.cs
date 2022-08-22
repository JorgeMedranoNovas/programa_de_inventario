using Layers.Framework.ADO.Net.Data.Modelos;
using System.Data.SqlClient;
using System;
using System.Data;
using Layers.Framework.ADO.Net.Data;


namespace Layers.Framework.ADO.Net.Data
{
	public class clsLnGruposEntidades
	{


		public void Cargar(ref clsBeGruposEntidades oBeGruposEntidades, DataRow dr)
		{
			try
			{
				oBeGruposEntidades.IdGrupoEntidad = Convert.ToInt32(dr["IdGrupoEntidad"].ToString());
				oBeGruposEntidades.Descripcion = String.IsNullOrEmpty(dr["Descripcion"].ToString()) == true ? "" : dr["Descripcion"].ToString();
				oBeGruposEntidades.Comentario = String.IsNullOrEmpty(dr["Comentario"].ToString()) == true ? "" : dr["Comentario"].ToString();
				oBeGruposEntidades.Statues = String.IsNullOrEmpty(dr["Statues"].ToString()) == true ? "" : dr["Statues"].ToString();
				oBeGruposEntidades.NoEliminable = Convert.ToBoolean(dr["NoEliminable"]);
				oBeGruposEntidades.FechaRegistro = Convert.ToDateTime(dr["FechaRegistro"]);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		public int Insertar(ref clsBeGruposEntidades oBeGruposEntidades)
		{
			try
			{
				string sp = "SpGruposEntidadesInsertar";

				SqlConnection cnn = new SqlConnection(BasedeDatos.stringConnection);
				SqlCommand cmd = new SqlCommand(sp, cnn);
				cmd.CommandType = CommandType.StoredProcedure;
				int rowsAffected = 0;
				cnn.Open();

			    //cmd.Parameters.Add(new SqlParameter("@IDGRUPOENTIDAD", oBeGruposEntidades.IdGrupoEntidad));
			    //cmd.Parameters["@IDGRUPOENTIDAD"].Direction = ParameterDirection.Output;
				cmd.Parameters.Add(new SqlParameter("@DESCRIPCION", oBeGruposEntidades.Descripcion));
				cmd.Parameters.Add(new SqlParameter("@COMENTARIO", oBeGruposEntidades.Comentario));
				cmd.Parameters.Add(new SqlParameter("@STATUES", oBeGruposEntidades.Statues));
				cmd.Parameters.Add(new SqlParameter("@NOELIMINABLE", oBeGruposEntidades.NoEliminable));
				cmd.Parameters.Add(new SqlParameter("@FECHAREGISTRO", oBeGruposEntidades.FechaRegistro));

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

		public int Actualizar(ref clsBeGruposEntidades oBeGruposEntidades)
		{
			try
			{
				string sp = "SpGruposEntidadesActualizar";

				SqlConnection cnn = new SqlConnection(BasedeDatos.stringConnection);
				SqlCommand cmd = new SqlCommand(sp, cnn);
				cmd.CommandType = CommandType.StoredProcedure;
				int rowsAffected = 0;
				cnn.Open();

				cmd.Parameters.Add(new SqlParameter("@IDGRUPOENTIDAD", oBeGruposEntidades.IdGrupoEntidad));
				cmd.Parameters.Add(new SqlParameter("@DESCRIPCION", oBeGruposEntidades.Descripcion));
				cmd.Parameters.Add(new SqlParameter("@COMENTARIO", oBeGruposEntidades.Comentario));
				cmd.Parameters.Add(new SqlParameter("@STATUES", oBeGruposEntidades.Statues));
				cmd.Parameters.Add(new SqlParameter("@NOELIMINABLE", oBeGruposEntidades.NoEliminable));
				cmd.Parameters.Add(new SqlParameter("@FECHAREGISTRO", oBeGruposEntidades.FechaRegistro));

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

		public int Eliminar(ref clsBeGruposEntidades oBeGruposEntidades)
		{
			try
			{
				string sp = "SpGruposEntidadesEliminar";

				SqlConnection cnn = new SqlConnection(BasedeDatos.stringConnection);
				SqlCommand cmd = new SqlCommand(sp, cnn);
				cmd.CommandType = CommandType.StoredProcedure;
				int rowsAffected = 0;
				cnn.Open();

				cmd.Parameters.Add(new SqlParameter("@IDGRUPOENTIDAD", oBeGruposEntidades.IdGrupoEntidad));

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

		public DataTable Listar()
		{
			try
			{
				string sp = "SpGruposEntidadesListar";

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

		public bool Obtener(ref clsBeGruposEntidades oBeGruposEntidades)
		{
			try
			{
				string sp = "SpGruposEntidadesObtener";

				SqlConnection cnn = new SqlConnection(BasedeDatos.stringConnection);
				SqlCommand cmd = new SqlCommand(sp, cnn);
				cmd.CommandType = CommandType.StoredProcedure;

				SqlDataAdapter dad = new SqlDataAdapter(cmd);
				dad.SelectCommand.Parameters.Add(new SqlParameter("@IDGRUPOENTIDAD", oBeGruposEntidades.IdGrupoEntidad));

				DataTable dt = new DataTable();
				dad.Fill(dt);

				if ((dt.Rows.Count == 1))
				{
					Cargar(ref oBeGruposEntidades, dt.Rows[0]);
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

		public bool Primero(ref clsBeGruposEntidades oBeGruposEntidades)
		{
			try
			{
				string sp = "SpGruposEntidadesPrimero";

				SqlConnection cnn = new SqlConnection(BasedeDatos.stringConnection);
				SqlCommand cmd = new SqlCommand(sp, cnn);
				cmd.CommandType = CommandType.StoredProcedure;

				SqlDataAdapter dad = new SqlDataAdapter(cmd);

				DataTable dt = new DataTable();
				dad.Fill(dt);

				if ((dt.Rows.Count == 1))
				{
					Cargar(ref oBeGruposEntidades, dt.Rows[0]);
				}
				else
				{
					throw new Exception("No se pudo obtener el primer registro");
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
