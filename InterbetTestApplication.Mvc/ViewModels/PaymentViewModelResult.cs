using System;

namespace InterbetTestApplication.ViewModels
{
    public class PaymentViewModelResult
    {
        public Guid UniqueInstanceID { get; set; }
        public DateTime EffectiveDate { get; set; }
        public int TransactionCode { get; set; }
        public double TransactionAmount { get; set; }
        public DateTime TransactionDate { get; set; }
        public int TransactionTime { get; set; }
        public string ChequeNumber { get; set; }
        public string DrCrIndicator { get; set; }
        public string BankName { get; set; }
        public string BranchCode { get; set; }
        public string ReferenceNumber { get; set; }
        public int AccountNumber { get; set; }
        public string Identifier { get; set; }
    }
}