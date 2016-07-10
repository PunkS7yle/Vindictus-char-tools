using System;
using System.Collections.Generic;
using System.Linq;

using Dapper;

namespace Vindictus_Tools
{
    using System.Data.SqlClient;
    using System.Windows.Forms;

    class DatabaseHandler
    {
        private readonly SqlConnection sql;
        public DatabaseHandler(string ip, string user, string pass, string db)
        {
            string cs = $"Data Source={ip};Initial Catalog={db};User id={user};Password={pass};MultipleActiveResultSets=true;";
            try
            {
                sql = new SqlConnection { ConnectionString = cs };
                sql.Open();
            }
            catch (Exception)
            {
                MessageBox.Show("Error connecting to db");
            }
        }


        public void Close()
        {
            sql.Close();
        }

        public IEnumerable<dynamic> GetCharacterData(string paramType, string paramValue)
        {
            var query = $@" SELECT name,id,Class,level,exp,ap FROM heroes..characterinfo WHERE {paramType} = {paramValue}";
            var result = sql.Query(query);
            return result.ToList();

        }

        public IEnumerable<dynamic> GetCharacterPath(long cid)
        {
            var query = $"SELECT vocationclass,vocationlevel from heroes..vocation where cid = {cid}";
            var result = sql.Query(query);           
            return result.ToList();


        }

        public IEnumerable<dynamic> GetCharacterCrafting(long cid)
        {
            var query = $"Select manufacturelid,grade,experiencepoint from heroes..manufacture where cid ={cid}";
            var result = sql.Query(query);
            return result.ToList();
             
            
        }

        public IEnumerable<dynamic> GetCharacterGuild(long cid)
        {
            var query =$"select guildid from heroes..guildinfo where guildsn = (select guildsn from heroes..guilduser where cid ={cid})";
            var result = sql.Query(query);
            return result.ToList();
            
        }

        public IEnumerable<dynamic> GetItems(long cid)
        {
            var query = $"select * from heroes..item where ownerid = {cid}";
            var result = sql.Query(query);
            return result.ToList();

        }

        public void UpdateCharData(string name, int level, long exp, int ap, int Class, int path, int pathlevel, string crafttype,int craftgrade,int craftexp,long cid)
        {
            var query =
                $@"update heroes..characterinfo set Name='{name}',level={level},exp={exp},ap={ap},class={Class} where id = {cid};
                           update heroes..vocation set vocationclass={path},vocationlevel={pathlevel} where cid = {cid};
                           update heroes..manufacture set manufacturelid='{crafttype}',grade={craftgrade},experiencepoint={craftexp} where cid ={cid}";
            sql.QueryMultiple(query);
        }
 
    }
}
