using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ProAgil.WebAPI.Model;

namespace ProAgil.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<Evento>> Get()
        {
            return new Evento[] { 
                new Evento(){
                    EventoId = 1,
                    Tema = "Angula e .NET Core",
                    Local= "Belo Horizonte",
                    Lote = "1 Lote",
                    QntPessoas= 250,
                    DataEvento= DateTime.Now.AddDays(2).ToString("dd/MM/yyyy")
                    
                },

                new Evento(){
                    EventoId = 1,
                    Tema = "Angula e suas novidades",
                    Local= "São Paulo",
                    Lote = "2 Lote",
                    QntPessoas= 350,
                    DataEvento= DateTime.Now.AddDays(2).ToString("dd/MM/yyyy")
                    
                }
            };
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<String> Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
