using InterbetTestAppplication.ApplicationLogic.Models;
using InterbetTestAppplication.ApplicationLogic.Service.Interface;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;

namespace InterbetTestAppplication.API.Controllers
{
    public class TransactionController : ApiController
    {
        private ITransactionService _transactionService;

        public TransactionController(ITransactionService transactionService)
        {
            _transactionService = transactionService;
        }


        // GET: api/Transaction/datetime
        public async Task<IEnumerable<PaymentEntity>> Get(string transDate)
        {
            return await _transactionService.GetPaymentTransactions(DateTime.ParseExact(transDate, "yyyyMMdd",
                          CultureInfo.InvariantCulture,
                          DateTimeStyles.None));
        }

        
    }
}
