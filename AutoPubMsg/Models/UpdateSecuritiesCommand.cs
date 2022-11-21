using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoPubMsg.Models
{
    public class UpdateSecuritiesCommand : BaseAccountCommand
    {
        public DateTime? TranDate { get; set; }
        public string? SubId { get; set; }
        public byte? Status { get; set; }
        public byte? UpdateType { get; set; }
        public string StockCode { get; set; }
        public long? TradingAvail { get; set; }
        public long? TradingAvail_Mar { get; set; }
        public long? PendingBuy { get; set; }
        public long? PendingSell { get; set; }
        public long? PendingSell_Mar { get; set; }
        public long? MatchedBuyIntraday { get; set; }
        public long? MatchedSellIntraday { get; set; }
        public long? MatchedSellIntraday_Mar { get; set; }
        public long? ReceivableT1 { get; set; }
        public long? ReceivableT2 { get; set; }
        public long? ReceivableRight { get; set; }
        public long? Dividend { get; set; }
        public long? ESOP { get; set; }
        public long? Restricted { get; set; }
        public long? MortgageAtBank { get; set; }
        public long? Holding { get; set; }
        public long? TradingWaiting { get; set; }
        public long? ESOPWaiting { get; set; }
        public long? RestrictedWaiting { get; set; }
        public long? MortgageAtBankWaiting { get; set; }
        public long? HoldingWaiting { get; set; }
        public long? WaitingFromCustody { get; set; }
        public long? MarproSuspend { get; set; }
        public long? NetPosition { get; set; }
        public long? OpenPosition { get; set; }
        public long? Price { get; set; }
        public long? VMIntraday { get; set; }
        public string? StockCode2 { get; set; }

        public UpdateSecuritiesCommand()
        {
            string clientCodePrefix = "058C";
            var randomString = Guid.NewGuid().ToString();
            var randomInt = new Random().Next(0, 65456);
            var bussinessType = new Random().Next(257, 264);
            var updateType = new Random().Next(0, 2);
            var clientCode = new Random().Next(1, 75243);

            if(bussinessType == 262)
            {
                bussinessType = 258;
            }

            if(bussinessType == 259)
            {
                bussinessType = 249;
            }

            UpdateTime = DateTime.Now;
            CreateDate = DateTime.Now;
            TranDate = DateTime.Now;
            RefId = randomString;
            SubId = randomString;
            Status = 1;
            UpdateType = Convert.ToByte(updateType);
            ClientCode = clientCodePrefix + clientCode.ToString("D6");
            StockCode = "FTS";
            BusinessType = bussinessType;
            TradingAvail = randomInt;
            TradingAvail_Mar = randomInt;
            PendingBuy = randomInt;
            PendingSell = randomInt;
            PendingSell_Mar = randomInt;
            MatchedBuyIntraday = randomInt;
            MatchedSellIntraday = randomInt;
            MatchedSellIntraday_Mar = randomInt;    
            ReceivableT1 = randomInt;
            ReceivableT2 = randomInt;
            ReceivableRight = randomInt;
            Dividend = randomInt;
            ESOP = randomInt;
            Restricted = randomInt;
            MortgageAtBank = randomInt;
            Holding = randomInt;
            TradingWaiting = randomInt;
            ESOPWaiting = randomInt;
            RestrictedWaiting = randomInt;
            MortgageAtBankWaiting = randomInt;
            HoldingWaiting = randomInt;
            WaitingFromCustody = randomInt;
            MarproSuspend = randomInt;
            NetPosition = randomInt;
            OpenPosition = randomInt;
            Price = randomInt;
            VMIntraday = randomInt;
            StockCode2 = "FPT";
            Desc = randomString;
        }
    }
}
