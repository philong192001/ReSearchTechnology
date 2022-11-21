
using MappingDataDB.Models;

namespace MappingDataDB.Factory;

public class TransactionFactory
{
    private const string ClientCodePrefix = "058C";
    private const string StockCodePrefix = "STOCK";
    public static IEnumerable<Transaction> GenerateOrder(int count, int startIndex = 0)
    {
        var now = DateTime.Now;
        var randomString = Guid.NewGuid().ToString();

        var collection = Enumerable
            .Range(startIndex, count)
            .Select(x => new Transaction()
            {
                ATRANID = x,
                AORDERID = x,
                ACLIENTCODE = ClientCodePrefix + x.ToString("D6"),
                ASTOCKCODE = StockCodePrefix + x.ToString("D3"),
                AEXCHANGE = randomString,
                ABUYSELL = randomString,
                AORDERTYPE = randomString,
                AQUANTITY = x,
                APRICE = x,
                APRICETYPE = randomString,
                ATRADINGACCOUNT = randomString,
                APLACEDBY = randomString,
                APRODUCTTYPE = randomString,
                AMARKETSEGMENT = randomString,
                ACONTRACTNO = randomString,
                ACANCELFLAG = x,
                AMODIFYFLAG  = x,
                ALASTTRADEDTIME = now,
                AORIGORDERID = x,
                ASOURCE = randomString,
                ADATETIME = now,
                AIS3RDPARTY = x,
                ALASTTRANID = x,
                APTTYPE = randomString,
                ALATESTID = x
            });
        return collection;
    }
}
