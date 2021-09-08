using AspNetCore.Reporting;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace xmedical_ehr.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestController : Controller
    {
        public TestController()
        {
            System.Text.Encoding.RegisterProvider(System.Text.CodePagesEncodingProvider.Instance);
        }
        
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet("print")]
        public ActionResult Print()
        {
            string mimeType = "";
            int extension = 1;
            var path = Path.Combine(Directory.GetCurrentDirectory(), "Reports", "Test", "Report1.rdlc");
            LocalReport report = new LocalReport(path);

            var parametros = new Dictionary<string, string>();
            parametros.Add("Nombre", "Victor Manuel Brito");


            var result = report.Execute(RenderType.Pdf, extension, parametros, mimeType);
            return File(result.MainStream, "application/pdf");
        }
    }
}
