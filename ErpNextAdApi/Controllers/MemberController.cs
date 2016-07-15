using Aurora.ErpNext.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Description;

namespace ErpNextAdApi.Controllers
{
    public class MemberController : ApiController
    {
        /// <summary>
        /// Gets Hotel item by code.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns>Hotel Item</returns>
        [HttpGet]
        [ResponseType(typeof(MemberViewModel))]
        public IHttpActionResult Get()
        {
            var data = new MemberViewModel()
            {
                Id = Guid.NewGuid(),
                Test= ""
            };

            return Ok(data);
        }

    }
}
