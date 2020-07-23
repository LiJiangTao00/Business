using StackExchange.Redis;
using System;
using System.Collections.Generic;
using System.Text;

namespace Common
{
    public class RedisHelper
    {
        private ConnectionMultiplexer Redis { get; set; }
        private IDatabase DB { get; set; }
        public RedisHelper(string connection)
        {
            Redis = ConnectionMultiplexer.Connect(connection);
            DB = Redis.GetDatabase();
        }

        /// <summary>
        /// 增加/修改
        /// </summary>
        /// <param name="key"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        public bool SetValue(string key, string value)
        {
            return DB.StringSet(key, value);
        }

        /// <summary>
        /// 查询
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        public string GetValue(string key)
        {
            return DB.StringGet(key);
        }

        /// <summary>
        /// 删除
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        public bool DeleteKey(string key)
        {
            return DB.KeyDelete(key);
        }
    }
}
