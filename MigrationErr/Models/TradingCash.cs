namespace MigrationErr.Models
{
    public class TradingCash
    {
        public string ClientCode { get; init; }
        public long CashAmount { get; set; }
        public long Advance { get; set; }
        public long RemainSecuritiesPower { get; set; }
        public long FSavingPower { get; set; }
        public long Adhoc { get; set; }
        public long MatchedBuy { get; set; }
        public long PendingBuy { get; set; }
        public long IntradayDebt { get; set; }
        public long PendingBuyDebt { get; set; }
        public long MatchedBuyFee { get; set; }
        public long PendingBuyFee { get; set; }
        public long InternalTransfer { get; set; }
        public long ExternalTransfer { get; set; }
        public long FeeSum { get; set; }
        public long CreditLine { get; set; }
        public long RemainDebt { get; set; }
        public long DebtInterest { get; set; }
        public long ReceivableT0 { get; set; }
        public long ReceivableT1 { get; set; }
        public long ReceivableT2 { get; set; }
        public long ReceivableDividend { get; set; }
        public long ReceivableMatureCW { get; set; }
        public long ReceivableOddlot { get; set; }
        public long FSaving { get; set; }
        public long BankGuarantee { get; set; }
        public long BankSaving { get; set; }
        public long FGuarantee { get; set; }

        public long PurchasingPowerTotal => CashAmount + Advance + RemainSecuritiesPower + Adhoc
                                            - PendingBuy - MatchedBuy - MatchedBuyFee - PendingBuyFee - ExternalTransfer - FeeSum;
        public long RemainingCashAmount => CashAmount - MatchedBuy - MatchedBuyFee;
        public long TransferringAmount => InternalTransfer + ExternalTransfer;
        public long ReceivableCashOther => ReceivableMatureCW + ReceivableOddlot;
        public long ReceivableCashTotal => ReceivableT0 + ReceivableT1 + ReceivableT2 + ReceivableDividend + ReceivableMatureCW + ReceivableOddlot;
        public long NetAssetValue => RemainingCashAmount + ReceivableCashTotal - RemainDebt - IntradayDebt - DebtInterest - FeeSum;
    }
}
