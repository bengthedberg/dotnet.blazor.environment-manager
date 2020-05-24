using EnvironmentManager.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using Dapper;
using System.Data.SqlClient;
using System.Data;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;

namespace EnvironmentManager.Data
{
    public class EnvironmentRepository : IEnvironmentRepository
    {
        private readonly string _connectionString;
        private IDbConnection _connection { get { return new SqlConnection(_connectionString); } }

        public EnvironmentRepository(IConfiguration configuration)
        {
            _connectionString = configuration.GetConnectionString("EnvironmentManagerDatabase");
        }

        public async Task<IEnumerable<Core.Environment>> GetAllEnvironmentsAsync()
        {
            using (IDbConnection dbConnection = _connection)
            {
                string query = @"SELECT [Id] ,[CategoryId]
                                ,[Name]
                                ,[Description]
                                ,[Price]
                                ,[CreatedDate]
                                FROM [dbo].[Products]";

                var result = await dbConnection.QueryAsync<Core.Environment>(query);

                return result;
            }
        }

        public async Task<Core.Environment> GetEnvironmentByIdAsync(int environmentId)
        {
            using (IDbConnection dbConnection = _connection)
            {
                string query = @"SELECT [Id] ,[CategoryId]
                                ,[Name]
                                ,[Description]
                                ,[Price]
                                ,[CreatedDate]
                                FROM [dbo].[Products]
                                WHERE [Id] = @Id";

                var result = await dbConnection.QueryFirstOrDefaultAsync<Core.Environment>(query, new { @Id = environmentId });

                return result;
            }
        }
    }
}
