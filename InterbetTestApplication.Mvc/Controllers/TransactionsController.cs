using InterbetTestApplication.ViewModels;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace InterbetTestApplication.Mvc.ViewModels
{
    [RoutePrefix("transactions")]
    public class TransactionsController : Controller
    {
        // GET: Transactions
        [Route]
        public async Task<ActionResult> Index()
        {
            var httpClient = new HttpClient();

            var response = await httpClient.GetAsync("http://localhost:52630/api/Transaction?transDate=20180101");

            var result = await response.Content.ReadAsAsync<IEnumerable<PaymentViewModelResult>>();

            return View(result);
        }
        [Route("{datetime:int}")]
        public async Task<ActionResult> Get(int datetime)
        {
            var httpClient = new HttpClient();
            var response = await httpClient.GetAsync($"http://localhost:52630/api/Transaction?transDate={datetime}");

            var result = await response.Content.ReadAsAsync<IEnumerable<PaymentViewModelResult>>();

            return View(result);
        }
    }
}