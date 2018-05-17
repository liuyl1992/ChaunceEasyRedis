using System;
using System.Collections.Generic;
using System.Text;

namespace ChaunceEasyRedis
{
    /// <summary>
    /// Redis配置
    /// </summary>
    public class RedisCacheOptions : BaseRedisOptions
    {
        /// <summary>
        /// 获取Database
        /// </summary>
        /// <value>
        /// The database.
        /// </value>
        public int Database { get; set; } = 0;

        /// <summary>
        /// 默认Key前缀
        /// 规范     以:结尾
        /// :结尾可自动分组
        /// </summary>
        public string DefaultCustomKey { get; set; }
    }
}
