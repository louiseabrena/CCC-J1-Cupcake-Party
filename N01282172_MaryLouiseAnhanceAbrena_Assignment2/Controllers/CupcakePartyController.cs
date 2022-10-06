using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace N01282172_MaryLouiseAnhanceAbrena_Assignment2.Controllers
{
    public class CupcakePartyController : ApiController
    {

        /// <summary>
        /// Output the cupcake left at the cupcake party
        /// (2022 - Junior Problems - J1 Cupcake Party)
        /// (https://cemc.math.uwaterloo.ca/contests/computing/past_ccc_contests/2022/ccc/juniorEF.pdf)
        /// </summary>
        /// <param name="regularCupcake">The number of box that's been input</param>
        /// <param name="smallCupcake">The number of box that's been input</param>
        /// <param name="8">The number of cupcake on one regular box of cupcake</param>
        /// <param name="3">The number of cupcake on one small box of cupcake</param>
        /// <param name="28">The number of students that participated in the cupcake party</param>
        /// <param name="regularCupcakeTotal">The total of cupcakes of the regular boxes that is input</param>
        /// <param name="smallCupcakeTotal">The total of cupcakes of the small boxes that is input</param>
        /// <param name="outputTotal">The total cupcakes left if all the students got one cupcake each</param>
        /// <returns>
        /// The cupcake left after each student have had one cupcake
        /// </returns>
        /// <example>
        /// Get api/cupcakeparty/9/8 -> 68
        /// Get api/cupcakeparty/3/5 -> 11
        /// </example>

    [HttpGet]
    [Route("api/cupcakeparty/{regularCupcake}/{smallCupcake}")]
    public int Get(int regularCupcake, int smallCupcake)
        {
            int outputMessage = 0;
            int regularCupcakeTotal = regularCupcake * 8;
            int smallCupcakeTotal = smallCupcake * 3;
            int cupcakeTotal = regularCupcakeTotal + smallCupcakeTotal;
            int outputTotal = cupcakeTotal - 28;

            return outputMessage = outputTotal;

        }
    }
}