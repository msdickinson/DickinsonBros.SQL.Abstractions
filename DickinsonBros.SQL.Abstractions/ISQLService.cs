﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Threading;
using System.Threading.Tasks;

namespace DickinsonBros.SQL.Abstractions
{
    public interface ISQLService
    {
        Task ExecuteAsync(string connectionString, string sql, object param = null, CommandType? commandType = null);
        Task<T> QueryFirstAsync<T>(string connectionString, string sql, object param = null, CommandType? commandType = null);
        Task<T> QueryFirstOrDefaultAsync<T>(string connectionString, string sql, object param = null, CommandType? commandType = null);
        Task BulkCopyAsync(string connectionString, DataTable table, string tableName, int? batchSize, TimeSpan? timeout, CancellationToken? token);
        Task BulkCopyAsync<T>(string connectionString, IEnumerable<T> enumerable, string tableName, int? batchSize, TimeSpan? timeout, CancellationToken? token);
        Task<IEnumerable<T>> QueryAsync<T>(string connectionString, string sql, object param = null, CommandType? commandType = null);
    }
}
