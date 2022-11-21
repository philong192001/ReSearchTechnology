using System.Data;
using System.Dynamic;

namespace AutoPubMsg.Models;

public class UpdateCashCommand : BaseAccountCommand
{
    public DateTime? TranDate { get; set; }

    public string? SubId { get; set; }

    public byte? Status { get; set; }

    public long? CashAmount { get; set; }

    public long? Advance { get; set; }

    public long? RemainSecuritiesPower { get; set; }

    public long? Adhoc { get; set; }

    public long? MatchedBuy { get; set; }

    public long? PendingBuy { get; set; }

    public long? MatchedBuyFee { get; set; }

    public long? PendingBuyFee { get; set; }

    public long? IntradayDebt { get; set; }

    public long? PendingBuyDebt { get; set; }

    public long? InternalTransfer { get; set; }

    public long? ExternalTransfer { get; set; }

    public long? FeeSum { get; set; }

    public long? SMSFee { get; set; }

    public long? AdvisorSelectFee { get; set; }

    public long? VSDFee { get; set; }

    public long? RemainDebt { get; set; }

    public long? DebtInterest { get; set; }

    public long? CreditLine { get; set; }

    public long? ReceivableT0 { get; set; }

    public long? ReceivableT1 { get; set; }

    public long? ReceivableT2 { get; set; }

    public long? ReceivableDividend { get; set; }

    public long? ReceivableMatureCW { get; set; }
    public long? ReceivableOddlot { get; set; }

    public long? DVSD { get; set; }

    public long? UnpaidVM { get; set; }

    public long? TransferDFPTSToDVSD { get; set; }

    public long? TransferDVSDToDFPTS { get; set; }

    public long? FUTradingTax { get; set; }

    public long? FSavingPower { get; set; }

    public long? BankGuarantee { get; set; }

    public long? FSaving { get; set; }

    public long? BankSaving { get; set; }

    public long? FGuarantee { get; set; }

    public byte? UpdateType { get; set; }

    public string StockCode { get; set; }

    public UpdateCashCommand()
    {
        string clientCodePrefix = "058C";
        var randomString = Guid.NewGuid().ToString();
        var randomInt = new Random().Next(0,65456);
        var bussinessType = new Random().Next(188, 203);
        var updateType = new Random().Next(0, 2);
        var clientCode = new Random().Next(1, 75243);

        TranDate = DateTime.Now;
        SubId = randomString;
        Status = 1;
        CashAmount = randomInt;
        Advance = randomInt;
        RemainSecuritiesPower = randomInt;
        Adhoc = randomInt;
        MatchedBuy = randomInt;
        MatchedBuyFee = randomInt;
        PendingBuy = randomInt;
        PendingBuyFee = randomInt;
        PendingBuyDebt = randomInt;
        InternalTransfer = randomInt;
        ExternalTransfer = randomInt;
        FeeSum = randomInt;
        SMSFee = randomInt;
        AdvisorSelectFee = randomInt;
        VSDFee = randomInt;
        RemainDebt = randomInt;
        DebtInterest = randomInt;
        CreditLine = randomInt;
        ReceivableT0 = randomInt;
        ReceivableT1 = randomInt;
        ReceivableT2 = randomInt;
        ReceivableDividend = randomInt;
        ReceivableMatureCW = randomInt;
        ReceivableOddlot = randomInt;
        DVSD = randomInt;
        UnpaidVM = randomInt;
        TransferDFPTSToDVSD = randomInt;
        TransferDVSDToDFPTS = randomInt;
        FUTradingTax = randomInt;
        FSavingPower = randomInt;
        BankGuarantee = randomInt;
        FSaving = randomInt;
        BankSaving = randomInt;
        FGuarantee = randomInt;
        UpdateType = Convert.ToByte(updateType);
        StockCode = "FTS";
        RefId = randomString;
        ClientCode = clientCodePrefix + clientCode.ToString("D6");
        BusinessType = bussinessType;
        UpdateTime = DateTime.Now;
        Desc = randomString;
        TopicName = "accbalance";
        Partition = 0;
        Offset = randomInt;
        CreateDate = DateTime.Now;
    }
}

public class GetUpdateCashCommandMapper
{
    public static List<UpdateCashCommand> CreateUpdateCashCommandFromTRDMapper(DataTable assetReport)
    {
        var list = new List<UpdateCashCommand>();
        foreach (DataRow dr in assetReport.Rows)
        {
            try
            {
                var trdCash = new UpdateCashCommand();
                trdCash.UpdateTime = DateTime.Now;
                trdCash.CreateDate = DateTime.Now;
                trdCash.TranDate = DateTime.Now;
                trdCash.RefId = "RELOAD_CASH";
                trdCash.Status = 1;
                trdCash.UpdateType = 1;
                trdCash.BusinessType = -10;
                trdCash.ClientCode = dr["clientcode"].ToString();

                if (long.TryParse(dr["CASHAMOUNT"].ToString(), out var cashAmount))
                    trdCash.CashAmount = cashAmount;

                if (long.TryParse(dr["ADVANCE"].ToString(), out var advance))
                    trdCash.Advance = advance;

                if (long.TryParse(dr["REMAINSECURITIESPOWER"].ToString(), out var remainSecPower))
                    trdCash.RemainSecuritiesPower = remainSecPower;

                if (long.TryParse(dr["ADHOC"].ToString(), out var adhoc))
                    trdCash.Adhoc = adhoc;

                if (long.TryParse(dr["EXTERNALTRANSFER"].ToString(), out var externalTransfer))
                    trdCash.ExternalTransfer = externalTransfer;

                if (long.TryParse(dr["FSAVING"].ToString(), out var fSaving))
                    trdCash.FSaving = fSaving;

                if (long.TryParse(dr["BANKGUARANTEE"].ToString(), out var bankGuarantee))
                    trdCash.BankGuarantee = bankGuarantee;

                if (long.TryParse(dr["FSAVINGPOWER"].ToString(), out var fSavingPower))
                    trdCash.FSavingPower = fSavingPower;

                if (long.TryParse(dr["INTRADAYDEBT"].ToString(), out var intradayDebt))
                    trdCash.IntradayDebt = intradayDebt;

                if (long.TryParse(dr["MATCHEDBUY"].ToString(), out var matchedBuy))
                    trdCash.MatchedBuy = matchedBuy;

                if (long.TryParse(dr["MATCHEDBUYFEE"].ToString(), out var matchedBuyFee))
                    trdCash.MatchedBuyFee = matchedBuyFee;

                if (long.TryParse(dr["PENDINGBUY"].ToString(), out var pendingBuy))
                    trdCash.PendingBuy = pendingBuy;

                if (long.TryParse(dr["PENDINGBUYDEBT"].ToString(), out var pendingBuyDebt))
                    trdCash.PendingBuyDebt = pendingBuyDebt;

                if (long.TryParse(dr["PENDINGBUYFEE"].ToString(), out var pendingBuyFee))
                    trdCash.PendingBuyFee = pendingBuyFee;

                if (long.TryParse(dr["FEESUM"].ToString(), out var feeSum))
                    trdCash.FeeSum = feeSum;

                if (long.TryParse(dr["REMAINDEBT"].ToString(), out var remaindebt))
                    trdCash.RemainDebt = remaindebt;

                if (long.TryParse(dr["DEBTINTEREST"].ToString(), out var debtInterest))
                    trdCash.DebtInterest = debtInterest;

                if (long.TryParse(dr["VSDFEE"].ToString(), out var vsdFee))
                    trdCash.VSDFee = vsdFee;

                if (long.TryParse(dr["SMSFEE"].ToString(), out var smsFee))
                    trdCash.SMSFee = smsFee;

                if (long.TryParse(dr["ADVISORSELECTFEE"].ToString(), out var advisorSelectFee))
                    trdCash.AdvisorSelectFee = advisorSelectFee;

                if (long.TryParse(dr["FGUARANTEE"].ToString(), out var fGuarantee))
                    trdCash.FGuarantee = fGuarantee;

                list.Add(trdCash);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }
        return list;
    }
}
