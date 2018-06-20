using InterbetTestAppplicationRepository.Models;
using System;
using System.Globalization;

namespace InterbetTestAppplication.ApplicationLogic.Models.Mapper
{
    public static class DBModelMapper
    {
        /// <summary>
        /// Map to Featured Item ViewModel
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public static CorporatePayment MapToDBModel(CorporatePayments model)
        {
            return new CorporatePayment
            {
                AccountNumber = model.AccountNumber,
                TransactionAmount = model.TransactionAmount,
                BankName = model.BankName,
                BranchCode = model.BranchCode,
                ChequeNumber = model.ChequeNumber,
                DrCrIndicator = model.DrCrIndicator,
                EffectiveDate = DateTime.ParseExact(model.EffectiveDate.ToString(), "yyyyMMdd",
                          CultureInfo.InvariantCulture,
                          DateTimeStyles.None),
                Identifier = model.Identifier,
                ReferenceNumber = model.ReferenceNumber,
                TransactionCode = model.TransactionCode,
                TransactionDate = DateTime.ParseExact(model.TransactionDate.ToString(), "yyyyMMdd",
                          CultureInfo.InvariantCulture,
                          DateTimeStyles.None),
                TransactionTime = model.TransactionTime,
                UniqueInstanceID = model.UniqueInstanceID
            };
        }

        public static PaymentEntity MapToViewModel(CorporatePayment model)
        {
            return new PaymentEntity
            {
                AccountNumber = model.AccountNumber,
                TransactionAmount = model.TransactionAmount,
                BankName = model.BankName,
                BranchCode = model.BranchCode,
                ChequeNumber = model.ChequeNumber,
                DrCrIndicator = model.DrCrIndicator,
                EffectiveDate = model.EffectiveDate,
                Identifier = model.Identifier,
                ReferenceNumber = model.ReferenceNumber,
                TransactionCode = model.TransactionCode,
                TransactionDate = model.TransactionDate,
                TransactionTime = model.TransactionTime,
                UniqueInstanceID = model.UniqueInstanceID
            };
        }
    }
}