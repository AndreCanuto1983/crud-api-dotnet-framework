﻿using System;
using System.Threading.Tasks;
using System.Web.Http;

namespace WebAPI.Controllers
{
    [Authorize]
    [RoutePrefix("api/Make")]
    public class MakeController : ApiController
    {
        #region Controller for CRUD Make

        // POST api/V1/Usuario/Registrar
        [AllowAnonymous]
        [HttpPost]
        [Route("CrudMake")]
        public async Task<IHttpActionResult> CrudMake([FromBody]RegisterUserModel model)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);

            try
            {
                //User xiUser = null;

                //using (UserService userService = new UserService(Context))
                //    xiUser = await userService.RegisterUserAsync(model);

                ////generate access token response
                //var accessTokenResponse = GenerateLocalAccessTokenResponse(xiUser.Email);

                return Ok("");
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }

        #endregion  

        #region Controller for GET Make

        // GET api/V1/Usuario/ValidateTokenResetPassword
        [AllowAnonymous]
        [HttpGet]
        [Route("GetMake")]
        public async Task<IHttpActionResult> GetMake(string token)
        {
            try
            {

                return Ok();
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }

        #endregion                            
    }
}