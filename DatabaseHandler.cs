using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;
using Dapper;

namespace Vindictus_Tools
{
    
    public class DatabaseHandler
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

        public bool IsOpen()
        {
            return sql.State == ConnectionState.Open;
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

        public IEnumerable<dynamic> GetAttributes(long itemId)
        {
            var query = $"select * from heroes..itemattribute where itemID={itemId}";
            var result = sql.Query(query);
            return result.ToList();
        }

        public void DeleteItem(long itemId)
        {
            var query = $@"delete from heroes..item where ID = {itemId}
                           delete from heroes..itemattribute where itemID={itemId}
                           delete from heroes..equippable where ID ={itemId}";
            sql.QueryMultiple(query);
        }

        public IEnumerable<dynamic> GetItemColor(long itemId)
        {
            var query = $"select * from heroes..equippable where id={itemId}";
            var result = sql.Query(query);
            return result.ToList();
        }

        public void UpdateItemAttributes( // TODO : Pass an object instead of this stupid list
            long itemId,
            string enhance,
            int quality,
            string prefix,
            string suffix,
            string craftedBy,
            string Class,
            int color1,
            int color2,
            int color3,
            int extraDura,
            int minusDura,
            string combiParts,
            string part1,
            string part2,
            string part3,
            string part4,
            string part5,
            int skillId
            )
        {
            var query =
                $@"delete from heroes..itemattribute where itemId={itemId};
                           update heroes..equippable set Color1 = {color1},Color2={color2},Color3={color3},ReducedDurability={minusDura},MaxDurabilityBonus={extraDura} where id = {itemId};
                           update heroes..item set ItemClass = '{Class}' where ID = {itemId};
                           insert into heroes..itemattribute (itemid,attribute,value,arg,arg2) values ({itemId},'ENHANCE','{enhance}',0,0);
                           insert into heroes..itemattribute (itemid,attribute,value,arg,arg2) values ({itemId},'QUALITY','{craftedBy}',{quality},0);
                           insert into heroes..itemattribute (itemid,attribute,value,arg,arg2) values ({itemId},'PREFIX','{prefix}',0,0);
                           insert into heroes..itemattribute (itemid,attribute,value,arg,arg2) values ({itemId},'SUFFIX','{suffix}',0,0);
                        ";
            sql.QueryMultiple(query);
            if (string.IsNullOrWhiteSpace(combiParts)) return;
            var query2 = $@"insert into heroes..itemattribute (itemid,attribute,value,arg,arg2) values ({itemId},'COMBINATION','{combiParts}',0,0);
                                insert into heroes..itemattribute (itemid,attribute,value,arg,arg2) values ({itemId},'PS_0','{part1}',{combiParts.Substring(2, 1)},{skillId});
                                insert into heroes..itemattribute (itemid,attribute,value,arg,arg2) values ({itemId},'PS_1','{part2}',{combiParts.Substring(6, 1)},0);
                                insert into heroes..itemattribute (itemid,attribute,value,arg,arg2) values ({itemId},'PS_2','{part3}',{combiParts.Substring(10, 1)},0);
                                insert into heroes..itemattribute (itemid,attribute,value,arg,arg2) values ({itemId},'PS_3','{part4}',{combiParts.Substring(14, 1)},0);
                                insert into heroes..itemattribute (itemid,attribute,value,arg,arg2) values ({itemId},'PS_4','{part5}',{combiParts.Substring(18, 1)},0);
                                ";
            sql.QueryMultiple(query2);
        }
 
    }
}
