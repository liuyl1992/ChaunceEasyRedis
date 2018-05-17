using StackExchange.Redis;
using System;
using System.Collections.Generic;
using System.Text;

namespace ChaunceEasyRedis
{
    public interface IRedisDatabaseProvider
    {
        /// <summary>
        /// Gets the database.
        /// </summary>
        /// <returns>The database.</returns>
        IDatabase GetDatabase();

        /// <summary>
        /// Gets the server list.
        /// </summary>
        /// <returns>The server list.</returns>
        IEnumerable<IServer> GetServerList();

        /// <summary>
        /// 获取连接
        /// </summary>
        /// <returns></returns>
        ConnectionMultiplexer GetConnectionMultiplexer();

        string DefaultCustomKey { get; set; }
    }
}
