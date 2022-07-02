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
    public class InvoiceLineController : ControllerBase
    {
        private readonly IMozikaSupervisor _MozikaSupervisor;

        public InvoiceLineController(IMozikaSupervisor MozikaSupervisor)
        {
            _MozikaSupervisor = MozikaSupervisor;
        }

        [HttpGet]
        [Produces(typeof(List<InvoiceLineApiModel>))]
        public ActionResult<List<InvoiceLineApiModel>> Get()
        {
            try
            {
                return new ObjectResult(_MozikaSupervisor.GetAllInvoiceLine());
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex);
            }
        }

        [HttpGet("{id}")]
        [Produces(typeof(InvoiceLineApiModel))]
        public ActionResult<InvoiceLineApiModel> Get(int id)
        {
            try
            {
                var invoiceLine = _MozikaSupervisor.GetInvoiceLineById(id);
                if ( invoiceLine == null)
                {
                    return NotFound();
                }

                return Ok(invoiceLine);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex);
            }
        }

        [HttpGet("invoice/{id}")]
        [Produces(typeof(List<InvoiceLineApiModel>))]
        public ActionResult<InvoiceLineApiModel> GetByInvoiceId(int id)
        {
            try
            {
                var invoiceLines = _MozikaSupervisor.GetInvoiceLineByInvoiceId(id);
                if ( invoiceLines == null)
                {
                    return NotFound();
                }

                return Ok(invoiceLines);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex);
            }
        }

        [HttpGet("track/{id}")]
        [Produces(typeof(List<InvoiceLineApiModel>))]
        public ActionResult<InvoiceLineApiModel> GetByTrackId(int id)
        {
            try
            {
                var invoiceLines = _MozikaSupervisor.GetInvoiceLineByTrackId(id);
                if (invoiceLines == null)
                {
                    return NotFound();
                }

                return Ok(invoiceLines);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex);
            }
        }

        [HttpPost]
        public ActionResult<InvoiceLineApiModel> Post([FromBody] InvoiceLineApiModel input)
        {
            try
            {
                if (input == null)
                    return BadRequest();

                return StatusCode(201, _MozikaSupervisor.AddInvoiceLine(input));
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex);
            }
        }

        [HttpPut("{id}")]
        public ActionResult<InvoiceLineApiModel> Put(int id, [FromBody] InvoiceLineApiModel input)
        {
            try
            {
                if (input == null)
                    return BadRequest();
                if (_MozikaSupervisor.GetInvoiceLineById(id) == null)
                {
                    return NotFound();
                }

                // var errors = JsonConvert.SerializeObject(ModelState.Values
                //     .SelectMany(state => state.Errors)
                //     .Select(error => error.ErrorMessage));
                // Debug.WriteLine(errors);

                if (_MozikaSupervisor.UpdateInvoiceLine(input))
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
                if (_MozikaSupervisor.GetInvoiceLineById(id) == null)
                {
                    return NotFound();
                }

                if (_MozikaSupervisor.DeleteInvoiceLine(id))
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
    }
}