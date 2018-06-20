using InterbetTestAppplication.ApplicationLogic.Models;
using InterbetTestAppplication.ApplicationLogic.Models.Mapper;
using InterbetTestAppplication.ApplicationLogic.Service.Interface;
using InterbetTestAppplicationRepository.Models;
using InterbetTestAppplicationRepository.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace InterbetTestAppplication.ApplicationLogic.Service
{
    public class TrasactionService : ITransactionService
    {
        private IRepository<CorporatePayment> _paymentRepository;

        public TrasactionService(IRepository<CorporatePayment> paymentRepository)
        {
            _paymentRepository = paymentRepository;
        }

        public async Task AddPayments(List<CorporatePayments> models)
        {
            try
            {
                foreach (var payment in models)
                {
                    _paymentRepository.Add(DBModelMapper.MapToDBModel(payment));
                }
                await _paymentRepository.SaveAsync();
            }
            catch (Exception e)
            {
            }
        }

        public async Task<List<PaymentEntity>> GetPaymentTransactions(DateTime transactionDate)
        {
            var parameters = new SqlParameter[] { new SqlParameter("@trasactiondate", transactionDate.ToString("yyyy-MM-dd HH:mm:ss.fff")) };

            var payments = await _paymentRepository.GetAccountTransactions(parameters);
            return payments.Select(DBModelMapper.MapToViewModel).ToList();
        }
    }
}