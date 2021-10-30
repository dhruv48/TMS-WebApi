using Dapper;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Dapper.SqlMapper;

namespace Tms.DB.Infrastructure
{
    public class BaseDB
    {
        private const string CONNECTION_STRING = "ConnectionString";
        protected NpgsqlConnection connection;
        //protected jsonserializersettings nullvaluesettings
        protected JsonSerializerSettings nullValueSettings;
        public BaseDB(IConfiguration configuration)
        {
            var connectionString = configuration.GetSection(CONNECTION_STRING);
            if (string.IsNullOrWhiteSpace(connectionString.Value))
            
                throw new ArgumentNullException("Connection string not found or null");

                connection = new NpgsqlConnection(connectionString.Value);
                nullValueSettings = new JsonSerializerSettings
                {
                    NullValueHandling = NullValueHandling.Ignore,
                    MissingMemberHandling = MissingMemberHandling.Ignore
                };

            //AddTypeHandler(typeof(Address), new JsonObjectTypeHandler());
            //AddTypeHandler(typeof(IList<Common.Entities.Attribuate>), new JsonObjectTypeHandler());
            AddTypeHandler(JObjectHandler.Instance);


        }
        internal class JArrayTypeHandler : SqlMapper.TypeHandler<JArray>
        {
            public override JArray Parse(object value)
            {
                string json = value.ToString();
                return JArray.Parse(json);
            }

            public override void SetValue(IDbDataParameter parameter, JArray value)
            {
                parameter.Value = value;
            }

            //public override void SetValue(IDbDataParameter parameter, JArray value)
            //{
            //    throw new NotImplementedException();
            //}
        }

        // dapper extension to implement JObject support
        class JObjectHandler : TypeHandler<JObject>
        {
            private JObjectHandler() { }
            public static JObjectHandler Instance { get; } = new JObjectHandler();
            public override JObject Parse(object value)
            {
                var json = (string)value;
                return json == null ? null : JObject.Parse(json);
            }
            public override void SetValue(IDbDataParameter parameter, JObject value)
            {
                parameter.Value = value?.ToString(Newtonsoft.Json.Formatting.None);
            }
        }

        public class JsonObjectTypeHandler : ITypeHandler
        {
            public void SetValue(IDbDataParameter parameter, object value)
            {
                parameter.Value = (value == null)
                ? (object)DBNull.Value
                : JsonConvert.SerializeObject(value);
                parameter.DbType = DbType.String;
            }

            public object Parse(Type destinationType, object value)
            {
                return JsonConvert.DeserializeObject(value.ToString(), destinationType);
            }
        }

    }

}

