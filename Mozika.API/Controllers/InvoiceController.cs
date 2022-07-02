using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Mozika.Domain.Supervisor;
using Mozika.Domain.ApiModels;
using Microsoft.AspNetCore.Cors;

namespace Mozika.API.Controllers
{
    [Route("api/[controller]")]
    [EnableCors("CorsPolicy")]
    [ApiController]
    public class InvoiceController : ControllerBase
    {
        private readonly IMozikaSupervisor _MozikaSupervisor;

        public InvoiceController(IMozikaSupervisor MozikaSupervisor)
        {
            _MozikaSupervisor = MozikaSupervisor;
        }

        [HttpGet]
        [Produces(typeof(List<InvoiceApiModel>))]
        public ActionResult<List<InvoiceApiModel>> Get()
        {
            try
            {
                return new ObjectResult(_MozikaSupervisor.GetAllInvoice());
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex);
            }
        }

        [HttpGet("{id}")]
        [Produces(typeof(InvoiceApiModel))]
        public ActionResult<InvoiceApiModel> Get(int id)
        {
            try
            {
                var invoice = _MozikaSupervisor.GetInvoiceById(id);
                if ( invoice == null)
                {
                    return NotFound();
                }

                return Ok(invoice);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex);
            }
        }

        [HttpGet("customer/{id}")]
        [Produces(typeof(List<InvoiceApiModel>))]
        public ActionResult<InvoiceApiModel> GetByCustomerId(int id)
        {
            try
            {
                if (_MozikaSupervisor.GetCustomerById(id) == null)
                {
                    return NotFound();
                }

                return Ok(_MozikaSupervisor.GetInvoiceByCustomerId(id));
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex);
            }
        }

        [HttpPost]
        public ActionResult<InvoiceApiModel> Post([FromBody] InvoiceApiModel input)
        {
            try
            {
                if (input == null)
                    return BadRequest();

                return StatusCode(201, _MozikaSupervisor.AddInvoice(input));
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex);
            }
        }

        [HttpPut("{id}")]
        public ActionResult<InvoiceApiModel> Put(int id, [FromBody] InvoiceApiModel input)
        {
            try
            {
                if (input == null)
                    return BadRequest();
                if (_MozikaSupervisor.GetInvoiceById(id) == null)
                {
                    return NotFound();
                }

                // var errors = JsonConvert.SerializeObject(ModelState.Values
                //     .SelectMany(state => state.Errors)
                //     .Select(error => error.ErrorMessage));
                // Debug.WriteLine(errors);

                if (_MozikaSupervisor.UpdateInvoice(input))
                {
                    return Ok(input);
                }

                return StatusCode(500);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex);
            }
        }

        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            try
            {
                if (_MozikaSupervisor.GetInvoiceById(id) == null)
                {
                    return NotFound();
                }

                if (_MozikaSupervisor.DeleteInvoice(id))
                {
                    return Ok();
                }

                return StatusCode(500);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex);
            }
        }
        
        [HttpGet("employee/{id}")]
        [Produces(typeof(List<InvoiceApiModel>))]
        public ActionResult<InvoiceApiModel> GetByEmployeeId(int id)
        {
            try
            {
                if (_MozikaSupervisor.GetCustomerById(id) == null)
                {
                    return NotFound();
                }

                return Ok(_MozikaSupervisor.GetInvoiceByEmployeeId(id));
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex);
            }
        }
    }
}