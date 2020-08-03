using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ClassLibrary;
using ClassLibrary.Model;
using Newtonsoft.Json;

namespace TestForBPOTravel.Controllers
{
    public class SearchController : Controller
    {
        private readonly Bitrix24 bx_logon;
        private readonly ExchangeRateResponse exchangeRateResponse;
        
        public SearchController(Bitrix24 bitrix24, ExchangeRateResponse exchangeRateResponse)
        {
            this.bx_logon = bitrix24;
            this.exchangeRateResponse = exchangeRateResponse;
        }

        public IActionResult Index(string query)
        {
            //Создаем наш класс, при этом срабатывает конструктор, который сразу авторизируется в Битрикс24
            // bx_logon = new Bitrix24();

            //Отправляет REST-запрос в Битрикс24, например, получаем список всех задач с помощью команды "task.item.list",
            string TaskListByJSON = bx_logon.SendCommand("crm.currency.list");
            ExchangeRateResponse response = JsonConvert.DeserializeObject<ExchangeRateResponse>(TaskListByJSON);

            //foreach (var item in response.result)
            //{
            //    Console.WriteLine(item.FULL_NAME + " : " + item.AMOUNT + " руб");
            //}

            return View(response.result);
        }
    }
}
