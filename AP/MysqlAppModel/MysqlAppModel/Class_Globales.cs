using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Forms;

using MySql.Data.MySqlClient;
using System.Data.OleDb;

using System.IO;

namespace MysqlAppModel
{

    public static class GestMysql
    {

        public static string Cnx_Server       = string.Empty;
        public static string Cnx_UserId       = string.Empty;
        public static string Cnx_PassWord     = string.Empty;
        public static string Cnx_Database     = string.Empty;
        public static string Cnx_MysqlPort    = string.Empty;

        public static MySqlConnection Cnx_Mysql;

        private static string Cnx_String = string.Empty;

        public static bool verbose = false;
        public static Exception ErreurExc = null;

        private static bool cnx_isconnected = false;

        public static bool Cnx_IsConnected
        {
            get { return cnx_isconnected; }
        }

        public static bool Connecter()
        {
            ErreurExc = null;

            if (!GestParam.Load_Setting2Param()) { cnx_isconnected = false; return false; }

            Cnx_Server       = GestParam.Param_Server;
            Cnx_UserId       = GestParam.Param_UserId;
            Cnx_PassWord     = GestParam.Param_PassWord;
            Cnx_Database     = GestParam.Param_MainDatabase;
            Cnx_MysqlPort    = GestParam.Param_MysqlPort;


            try
            {

                Cnx_String = "server=" + Cnx_Server + ";userid=" + Cnx_UserId + ";port=" + Cnx_MysqlPort + ";password=" + Cnx_PassWord + ";database=" + Cnx_Database;
                Cnx_Mysql = new MySqlConnection(Cnx_String);
                Cnx_Mysql.Open();

                if (Cnx_Mysql.State.ToString() == "Open")
                {
                    cnx_isconnected = true;
                    return true;
                }

                Cnx_Mysql = null;
                cnx_isconnected = false;
                return false;

            }
            catch (Exception ex)
            {
                Cnx_String = string.Empty;
                Cnx_Mysql = null;
                GoProcErreur(ex);
                cnx_isconnected = false;
                return false;

            }

        }

        public static bool Deconnecter()
        {
            ErreurExc = null;

            try
            {
                if (Cnx_Mysql != null) { Cnx_Mysql.Close(); };

                Cnx_Server = null;
                Cnx_Database = null;
                Cnx_UserId = null;
                Cnx_PassWord = null;

                cnx_isconnected = false;
                return true;
            }
            catch (Exception ex)
            {
                Cnx_String = string.Empty;
                Cnx_Mysql = null;
                cnx_isconnected = false;
                GoProcErreur(ex);
                return false;

            }

        }

        private static bool GoProcErreur(Exception ex)
        {

            ErreurExc = ex;

            if (verbose == false) { return false; };
            MessageBox.Show(ex.Message);
            return true;
        }

    }

    public static class GestParam
    {

        public static string Param_Server;
        public static string Param_UserId;
        public static string Param_PassWord;
        public static string Param_MainDatabase;
        public static string Param_MysqlPort;

        public static bool      verbose   = false ;
        public static Exception ErreurExc = null  ;

        public static bool Load_Setting2Param()
        {
            ErreurExc = null;

            try
            {

                Param_Server       = Properties.Settings.Default.Param_Server   ;
                Param_UserId       = Properties.Settings.Default.Param_UserId   ;
                Param_PassWord     = Properties.Settings.Default.Param_PassWord ;
                Param_MainDatabase = Properties.Settings.Default.Param_MainDatabase ;
                Param_MysqlPort    = Properties.Settings.Default.Param_MysqlPort    ;

                return true;

            }

            catch (Exception)
            {
                return false;
            }

        }
        public static bool Save_Param2Setting()
        {
            ErreurExc = null;

            try
            {

                Properties.Settings.Default.Param_Server       = Param_Server   ;
                Properties.Settings.Default.Param_UserId       = Param_UserId   ;
                Properties.Settings.Default.Param_PassWord     = Param_PassWord ;
                Properties.Settings.Default.Param_MainDatabase = Param_MainDatabase ;
                Properties.Settings.Default.Param_MysqlPort    = Param_MysqlPort    ;

                Properties.Settings.Default.Save();

                return true;

            }
            catch (Exception ex)
            {
                GoProcErreur(ex);
                return false;
            }

        }

        private static bool GoProcErreur(Exception ex)
        {
            ErreurExc = ex;
            if (verbose == false) { return false; };
            MessageBox.Show(ex.Message);
            return true;
        }

    }

}
