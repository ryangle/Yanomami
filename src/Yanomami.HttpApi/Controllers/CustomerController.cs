using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Mvc;

namespace Yanomami.Controllers
{
    [Route("api/mycustomer")]
    public class CustomerController : Controller
    {
        CustomerAppServcie _customerAppServcie;
        public CustomerController(CustomerAppServcie customerAppServcie)
        {
            _customerAppServcie = customerAppServcie;
        }
        [HttpGet]
        public string Get()
        {
            var r = _customerAppServcie.GetListAsync(new Volo.Abp.Application.Dtos.PagedAndSortedResultRequestDto()).Result;
            return "stest" + r.TotalCount;
        }
    }
}
