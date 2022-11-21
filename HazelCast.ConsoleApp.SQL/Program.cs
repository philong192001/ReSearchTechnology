
using Hazelcast;
using Hazelcast.Models;


    var options = new HazelcastOptionsBuilder()
        .With(args)
        .With("Logging:LogLevel:Hazelcast.Examples", "Information")
        .Build();

    // create a Hazelcast client and connect to a server running on localhost
    await using var client = await HazelcastClientFactory.StartNewClientAsync(options);

    var logger = client.Options.LoggerFactory.CreateLogger<SqlBasicQueryExample>();

    // get the distributed map from the cluster and populate it
    await using var map = await client.GetMapAsync<int, string>(nameof(SqlBasicQueryExample));
    await map.SetAllAsync(Enumerable.Range(1, 10).ToDictionary(v => v, v => $"Value #{v}"));

    //Before you can query data in a map, you need to create a mapping to one, using the map connector.
    //see details: https://docs.hazelcast.com/hazelcast/latest/sql/create-mapping
    await client.Sql.ExecuteCommandAsync(
        $"CREATE MAPPING {map.Name} TYPE IMap OPTIONS ('keyFormat'='int', 'valueFormat'='varchar')");

    // query and print all rows
    {
        await using var result = await client.Sql.ExecuteQueryAsync($"SELECT __key, this FROM {map.Name}");

        var count = 1;
    }

    // query and print all rows sorted by key descending
    {
        // index must be added to be able to sort by attribute
        await map.AddIndexAsync(IndexType.Sorted, "__key");

        await using var result = await client.Sql.ExecuteQueryAsync($"SELECT __key, this FROM {map.Name} ORDER BY __key DESC");

        var count = 1;
    }

    // query and print rows filtered via parameters
    {
        var (min, max) = (3, 7);
        await using var result = await client.Sql.ExecuteQueryAsync(
            $"SELECT __key, this FROM {map.Name} WHERE __key >= ? and __key <= ?",
            min, max
        );

        var count = 1;
    }

