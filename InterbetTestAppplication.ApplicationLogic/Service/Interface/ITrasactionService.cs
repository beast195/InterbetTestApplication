
using InterbetTestAppplication.ApplicationLogic.Models;
using InterbetTestAppplicationRepository.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace InterbetTestAppplication.ApplicationLogic.Service.Interface
{
    public interface ITransactionService
    {
        Task AddPayments(List<CorporatePayments> models);

        Task<List<PaymentEntity>> GetPaymentTransactions(DateTime transactionDate);
    }
}