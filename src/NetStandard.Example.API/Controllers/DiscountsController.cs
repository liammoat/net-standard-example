using System;
using Microsoft.AspNetCore.Mvc;
using NetStandard.Example.Core;

namespace NetStandard.Example.API.Controllers
{
    [Route("api/discounts")]
    [ApiController]
    public class DiscountsController : ControllerBase
    {
        private readonly DiscountEngine _discountEngine;

        public DiscountsController(DiscountEngine discountEngine)
        {
            _discountEngine = discountEngine;
        }

        [HttpGet]
        public ActionResult<double> Get(DateTime dateJoined)
        {
            return _discountEngine.GetDiscountAmount(dateJoined);
        }
    }
}
