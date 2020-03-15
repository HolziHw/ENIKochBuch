using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Web;

namespace ENIKochbuch.Models.DB
{
    public class RepEntryDB : IRepoEntry
    {
        private string _connectionString = "Server=localhost;Database=Eni_Kochbuch;Uid=root;Pwd=Sammiegsg9;";
        private MySqlConnection _connection = null;
        public void Open()
        {
            if(this._connection == null)
            {
                this._connection = new MySqlConnection(this._connectionString);
            }
            if(this._connection.State != ConnectionState.Open)
            {
                this._connection.Open();
            }
        }

        public void Close()
        {
            if((this._connection != null)&&(this._connection.State != ConnectionState.Closed))
            {
                this._connection.Close();
            }
        }

        public List<Entry> allrecipes()
        {
            throw new NotImplementedException();
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public bool Insert(Entry entry)
        {
            if(entry == null)
            {
                return false;
            }

            DbCommand cmdInsert = this._connection.CreateCommand();

            cmdInsert.CommandText = "INSERT into rezepte values (null , @rezeptName, @Beschreibung, @Klassifikation, @portionen, @Schwierigkeit, @saison, @Gang)";


            DbParameter paramName = cmdInsert.CreateParameter();
            paramName.ParameterName = "rezeptName";
            paramName.Value = entry.Name;
            paramName.DbType = DbType.String;

            DbParameter paramBesch = cmdInsert.CreateParameter();
            paramBesch.ParameterName = "Beschreibung";
            paramBesch.Value = entry.Beschreibung;
            paramBesch.DbType = DbType.String;

            DbParameter paramKlass = cmdInsert.CreateParameter();
            paramKlass.ParameterName = "Klassifikation";
            paramKlass.Value = entry.Klassifikation;
            paramKlass.DbType = DbType.Int32;

            DbParameter paramPor = cmdInsert.CreateParameter();
            paramPor.ParameterName = "portionen";
            paramPor.Value = entry.Portionen;
            paramPor.DbType = DbType.Int32;

            DbParameter paramSchwier = cmdInsert.CreateParameter();
            paramSchwier.ParameterName = "Schwierigkeit";
            paramSchwier.Value = entry.Schwierigkeit;
            paramSchwier.DbType = DbType.Int32;

            DbParameter paramSaison = cmdInsert.CreateParameter();
            paramSaison.ParameterName = "saison";
            paramSaison.Value = entry.Saison;
            paramSaison.DbType = DbType.Int32;

            DbParameter paramGang = cmdInsert.CreateParameter();
            paramGang.ParameterName = "Gang";
            paramGang.Value = entry.Gang;
            paramGang.DbType = DbType.Int32;

            cmdInsert.Parameters.Add(paramName);
            cmdInsert.Parameters.Add(paramBesch);
            cmdInsert.Parameters.Add(paramKlass);
            cmdInsert.Parameters.Add(paramPor);
            cmdInsert.Parameters.Add(paramSchwier);
            cmdInsert.Parameters.Add(paramSaison);
            cmdInsert.Parameters.Add(paramGang);

            return cmdInsert.ExecuteNonQuery() == 1;
        }

        public Entry onerecipe(int id)
        {
            throw new NotImplementedException();
        }

        public bool UpdateEntry(int id, Entry updateEntry)
        {
            throw new NotImplementedException();
        }
    }
}