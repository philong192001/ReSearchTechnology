using AutoPubMsg.Models;
using Confluent.Kafka;
using System.Net;
using System.Text.Json;

//while (Producer("accbalance", "10.26.7.58:9092") != "quit") ;

var cash = "Information.Account.Cash.Test.Long";
var securities = "FIT-BDRD-Account-Securities-Test-1";

var testJson = "FIT.BDRD.Test";
Producer(securities, "10.26.7.58:9092");



static void Producer(string topic, string server)
{
   
   
    var config = new ProducerConfig
    {
        BootstrapServers = server,
        ClientId = Dns.GetHostName()
    };

    using (var producer = new ProducerBuilder<string, string>(config).Build())
    {
        for (int i = 0; i < 100; i++)
        {
            UpdateSecuritiesCommand securitiesCommand = new UpdateSecuritiesCommand();
            //var randomInt = new Random().Next(1, 24252);
            //CashLog cashLog = new CashLog();
            //cashLog.Adhoc = randomInt;
            //cashLog.Advance = randomInt;
            //cashLog.DVSD = randomInt;
            //cashLog.SMSfee = randomInt;
            //cashLog.Desc = Guid.NewGuid().ToString();
            //cashLog.BankGuarantee = randomInt;
            //cashLog.TranDate = DateTime.Now;
            //cashLog.UpdateTime = DateTime.Now;
            //cashLog.BankSaving = randomInt;
            //cashLog.FSavingPower = randomInt;
            securitiesCommand.TopicName = topic;

            string msgSend = JsonSerializer.Serialize(securitiesCommand);
            producer.Produce(topic, new Message<string, string> { Key = securitiesCommand.ClientCode, Value = msgSend });

            //Console.WriteLine(DateTime.Now + " send " + msgSend + " to " + topic + " done ");
        }

     

        producer.Flush();
    }
}



