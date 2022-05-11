using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

using MySql.Data.MySqlClient;
using System.Data.SqlClient;


using System.IO;
using System.Data;
using System.Windows.Forms;

namespace MysqlAppModel
{
	class GestClient
	{
		public string codeclient;
		public string nomclient;
		public string adresse;
		public string codepostal;
		public string ville;
		public string tel;
		public string email;
		public DateTime datenaissance;
		public float  notemoy;

		public Boolean verbose = false;



		public bool Lire()
		{
			try
			{


				string Query = "SELECT * FROM client WHERE codeclient = @Param_CodeClient  ;";

				MySqlCommand MyCommand = new MySqlCommand(Query, GestMysql.Cnx_Mysql);
				MyCommand.Prepare();

				MySqlParameter Param_CodeClient = new MySqlParameter("@Param_CodeClient", MySqlDbType.VarChar);

				Param_CodeClient.Value = this.codeclient;
				Param_CodeClient.Direction = ParameterDirection.Output;
				MyCommand.Parameters.Add(Param_CodeClient);
				MySqlDataReader Curseur = MyCommand.ExecuteReader();

				while (Curseur.Read())
				{
					if (Curseur["codeclient"] is System.DBNull)		{ this.codeclient    = String.Empty; } else	{ this.codeclient    = Convert.ToString(Curseur["codeclient"]); };
					if (Curseur["nomclient"] is System.DBNull)		{ this.nomclient     = String.Empty; } else	{ this.nomclient     = Convert.ToString(Curseur["nomclient"]); };
					if (Curseur["adresse"] is System.DBNull)		{ this.adresse       = String.Empty; } else	{ this.adresse       = Convert.ToString(Curseur["adresse"]); };
					if (Curseur["codepostal"] is System.DBNull)		{ this.codepostal    = String.Empty; } else	{ this.codepostal    = Convert.ToString(Curseur["codepostal"]); };
					if (Curseur["ville"] is System.DBNull)			{ this.ville         = String.Empty; } else	{ this.ville         = Convert.ToString(Curseur["ville"]); };
					if (Curseur["tel"] is System.DBNull)			{ this.tel           = String.Empty; } else	{ this.tel           = Convert.ToString(Curseur["tel"]); };
					if (Curseur["email"] is System.DBNull)			{ this.email         = String.Empty; } else	{ this.email         = Convert.ToString(Curseur["email"]); };
					if (Curseur["datenaissance"] is System.DBNull)	{ this.datenaissance = DateTime.MinValue; } else	{ this.datenaissance = Convert.ToDateTime(Curseur["datenaissance"]); };
					if (Curseur["notemoy"] is System.DBNull)        { this.notemoy		= 0; }			   else	{ this.notemoy       = Convert.ToInt32(Curseur["notemoy"]); };
					 
				}

				Curseur.Close();

	

				return true;

			}

			catch (Exception ex)
			{
				 MessageBox.Show(ex.Message);
				
					return false;
			}

		}
		public bool Ajouter()
		{
			try {

					
			//	string Query = "insert into client(codeclient,nomclient) values( @Param_CodeClient, @Param_NomClient  );";
				string Query =		"  insert into client(codeclient,nomclient,adresse,codepostal,ville,tel,email,datenaissance,notemoy) values (  "
									+ " @Param_CodeClient		, "
									+ " @Param_NomClient		, "
									+ " @Param_Adresse			, "
									+ " @Param_Codepostal		, "
									+ " @Param_Ville			, "
									+ " @Param_Tel				, "
									+ " @Param_Email			, "
									+ " @Param_Datenaissance	, "
									+ " @Param_Notemoy			  "
									+ " )  ";


				MySqlCommand MyCommand = new MySqlCommand(Query, GestMysql.Cnx_Mysql);
				MyCommand.Prepare();

				MySqlParameter Param_CodeClient = new MySqlParameter("@Param_CodeClient", MySqlDbType.VarChar);
				MySqlParameter Param_NomClient = new MySqlParameter("@Param_NomClient", MySqlDbType.VarChar);
				MySqlParameter Param_Adresse = new MySqlParameter("@Param_Adresse", MySqlDbType.VarChar);
				MySqlParameter Param_Codepostal = new MySqlParameter("@Param_Codepostal", MySqlDbType.VarChar);
				MySqlParameter Param_Ville = new MySqlParameter("@Param_Ville", MySqlDbType.VarChar);
				MySqlParameter Param_Tel = new MySqlParameter("@Param_Tel", MySqlDbType.VarChar);
				MySqlParameter Param_Email = new MySqlParameter("@Param_Email", MySqlDbType.VarChar);
				MySqlParameter Param_Datenaissance = new MySqlParameter("@Param_Datenaissance", MySqlDbType.Date);
				MySqlParameter Param_Notemoy = new MySqlParameter("@Param_Notemoy", MySqlDbType.Int32);


				Param_CodeClient.Value = this.codeclient;
				Param_NomClient.Value = this.nomclient;
				Param_Adresse.Value = this.adresse;
				Param_Codepostal.Value = this.codepostal;
				Param_Ville.Value = this.ville;
				Param_Tel.Value = this.tel;
				Param_Email.Value = this.email;
				Param_Datenaissance.Value = this.datenaissance.ToString("yyyy-MM-dd");
				Param_Notemoy.Value = this.notemoy;


				Param_CodeClient.Direction = ParameterDirection.Input;
				Param_NomClient.Direction = ParameterDirection.Input;
				Param_Adresse.Direction = ParameterDirection.Input;
				Param_Codepostal.Direction = ParameterDirection.Input;
				Param_Ville.Direction = ParameterDirection.Input;
				Param_Tel.Direction = ParameterDirection.Input;
				Param_Email.Direction = ParameterDirection.Input;
				Param_Datenaissance.Direction = ParameterDirection.Input;
				Param_Notemoy.Direction = ParameterDirection.Input;


				MyCommand.Parameters.Add(Param_CodeClient);
				MyCommand.Parameters.Add(Param_NomClient);
				MyCommand.Parameters.Add(Param_Adresse);
				MyCommand.Parameters.Add(Param_Codepostal);
				MyCommand.Parameters.Add(Param_Ville);
				MyCommand.Parameters.Add(Param_Tel);
				MyCommand.Parameters.Add(Param_Email);
				MyCommand.Parameters.Add(Param_Datenaissance);
				MyCommand.Parameters.Add(Param_Notemoy);

				MyCommand.ExecuteNonQuery();

				return true;

			}

		catch (Exception ex)
			{
				return false;
			}

		}
		public bool Modifier()
		{
			try
			{


				string Query = "  UPDATE client SET                       "
							  + " nomclient		= @Param_NomClient		, "
							  + " adresse		= @Param_Adresse		, "
							  + " codepostal	= @Param_Codepostal		, "
							  + " ville			= @Param_Ville			, "
							  + " tel			= @Param_Tel			, "
							  + " email			= @Param_Email			, "
							  + " datenaissance	= @Param_Datenaissance	, "
							  + " notemoy		= @Param_Notemoy		  "
							  +"  WHERE codeclient = @Param_CodeClient	  ";

				MySqlCommand MyCommand = new MySqlCommand(Query, GestMysql.Cnx_Mysql);
				MyCommand.Prepare();

				MySqlParameter	Param_CodeClient	 = new MySqlParameter("@Param_CodeClient", MySqlDbType.VarChar);
				MySqlParameter  Param_NomClient      = new MySqlParameter("@Param_NomClient", MySqlDbType.VarChar);
				MySqlParameter  Param_Adresse		 = new MySqlParameter("@Param_Adresse", MySqlDbType.VarChar);
				MySqlParameter  Param_Codepostal	 = new MySqlParameter("@Param_Codepostal", MySqlDbType.VarChar);
				MySqlParameter  Param_Ville			 = new MySqlParameter("@Param_Ville", MySqlDbType.VarChar);
				MySqlParameter  Param_Tel			 = new MySqlParameter("@Param_Tel", MySqlDbType.VarChar);
				MySqlParameter  Param_Email			 = new MySqlParameter("@Param_Email", MySqlDbType.VarChar);
				MySqlParameter  Param_Datenaissance	 = new MySqlParameter("@Param_Datenaissance", MySqlDbType.Date);
				MySqlParameter  Param_Notemoy		 = new MySqlParameter("@Param_Notemoy", MySqlDbType.Int32);


				Param_CodeClient.Value		= this.codeclient       ;
				Param_NomClient.Value		= this.nomclient		;
				Param_Adresse.Value			= this.adresse			;
				Param_Codepostal.Value		= this.codepostal		;
				Param_Ville.Value			= this.ville			;
				Param_Tel.Value				= this.tel				;
				Param_Email.Value			= this.email			;
				Param_Datenaissance.Value   = this.datenaissance.ToString("yyyy-MM-dd");
				Param_Notemoy.Value			= this.notemoy          ;


				Param_CodeClient.Direction	= ParameterDirection.Input;
				Param_NomClient.Direction	= ParameterDirection.Input;
				Param_Adresse.Direction		= ParameterDirection.Input;
				Param_Codepostal.Direction	= ParameterDirection.Input;
				Param_Ville.Direction		= ParameterDirection.Input;
				Param_Tel.Direction			= ParameterDirection.Input;
				Param_Email.Direction		= ParameterDirection.Input;
				Param_Datenaissance.Direction	= ParameterDirection.Input;
				Param_Notemoy.Direction			= ParameterDirection.Input;


				MyCommand.Parameters.Add(Param_CodeClient);
				MyCommand.Parameters.Add(Param_NomClient);
				MyCommand.Parameters.Add(Param_Adresse);
				MyCommand.Parameters.Add(Param_Codepostal);
				MyCommand.Parameters.Add(Param_Ville);
				MyCommand.Parameters.Add(Param_Tel);
				MyCommand.Parameters.Add(Param_Email);
				MyCommand.Parameters.Add(Param_Datenaissance);
				MyCommand.Parameters.Add(Param_Notemoy);


				MyCommand.ExecuteNonQuery();

				return true;

			}

			catch (Exception ex)
			{
				return false;
			}


		}
		public bool Supprimer()
		{
			try
			{


				string Query = "DELETE FROM client WHERE codeclient= @Param_CodeClient  ;";

				MySqlCommand MyCommand = new MySqlCommand(Query, GestMysql.Cnx_Mysql);
				MyCommand.Prepare();

				MySqlParameter Param_CodeClient = new MySqlParameter("@Param_CodeClient", MySqlDbType.VarChar);

				Param_CodeClient.Value = this.codeclient;
				Param_CodeClient.Direction = ParameterDirection.Input;
				MyCommand.Parameters.Add(Param_CodeClient);
				MyCommand.ExecuteNonQuery();

				return true;

			}

			catch (Exception ex)
			{
				return false;
			}


		}

		public void RAZ_Prop()
		{
			codeclient		=	String.Empty;
			nomclient		=	String.Empty;
			adresse			=	String.Empty;
			codepostal		=	String.Empty;
			ville			=	String.Empty;
			tel				=	String.Empty;
			email			=	String.Empty;
			datenaissance	= DateTime.MinValue;
			notemoy			=	0;

			
		}


	}
}

