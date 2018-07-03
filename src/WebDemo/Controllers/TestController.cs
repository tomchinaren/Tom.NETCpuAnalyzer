using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Web;
using System.Web.Mvc;

namespace WebDemo.Controllers
{
    public class TestController : Controller
    {
        // GET: Test
        public ActionResult Index()
        {
            new Thread(A).Start();
            new Thread(B).Start();
            return Content("index");
        }

        private static void A(object state)
        {
            var k = 1000;
            var total = 0;
            while (true)
            {
                Thread.Sleep(1000);
                //total++;
                if (total > k * k * k)
                {
                    break;
                }
            }
        }

        private static void B(object state)
        {
            var k = 1000;
            var total = 0;
            while (true)
            {
                //total++;
                double d = new Random().NextDouble() * new Random().NextDouble();
                if (total > 10 * k * k)
                {
                    break;
                }
            }
        }
    }
}