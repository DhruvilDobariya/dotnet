using Microsoft.AspNetCore.Mvc;
using WebAPIBasics.Models;

namespace WebAPIBasics.Controllers
{
    [ApiController]
    [Route("api/[Controller]s")]
    public class ParameterController : Controller
    {
        #region FromQuery
        // FromQuery:
        // Parameter pass through quer string.
        // It has high priorities.
        // If we don't use any atribute then simple type come from query string and complex type come from body by deafult.
        // But we can only pass one complex type parameter from body.

        [HttpGet("FromQuerySimple")]
        public ActionResult<Student> FromQuerySimple(int id, [FromQuery] int enrollmentNo, [FromQuery] int rollNo)
        {
            return new Student { Id = id, EnrollmentNo = enrollmentNo, RollNo = rollNo };
        }

        [HttpGet("FromQueryComplex")]
        public ActionResult<Student> FromQueryComplex([FromQuery] Student student)
        {
            return new Student { Id = student.Id, EnrollmentNo = student.EnrollmentNo, RollNo = student.RollNo };
        }
        #endregion

        #region FromRoute
        [HttpGet("FromRouteSimple/{id}/{enrollmentNo}/{rollNo}")]
        public ActionResult<Student> FromRouteSimple(int id, [FromRoute] int enrollmentNo, [FromRoute] int rollNo)
        {
            return new Student { Id = id, EnrollmentNo = enrollmentNo, RollNo = rollNo };
        }
        [HttpGet("FromRouteComplex/{Id}/{EnrollmentNo}/{RollNo}")]
        public ActionResult<Student> FromRouteComplex([FromRoute] Student student)
        {
            return new Student { Id = student.Id, EnrollmentNo = student.EnrollmentNo, RollNo = student.RollNo };
        }
        #endregion

        #region FromBody
        // FromBody not work with HttpGet.
        // FromBody can take only one parameter.

        [HttpPost("FromBodySimple")]
        public ActionResult<int> FromBodySimple([FromBody] int id)
        {
            return id;
        }

        [HttpPost("FromBodyComplex")]
        public ActionResult<Student> FromBodyComplex([FromBody] Student student)
        {
            return new Student { Id = student.Id, EnrollmentNo = student.EnrollmentNo, RollNo = student.RollNo };
        }
        #endregion

        #region FromForm
        [HttpPost("FromFormSimple")]
        public ActionResult<Student> FromFormSimple([FromForm] int id, [FromForm] int enrollmentNo, [FromForm] int rollNo)
        {
            return new Student { Id = id, EnrollmentNo = enrollmentNo, RollNo = rollNo };
        }

        [HttpPost("FromFormComplex")]
        public ActionResult<Student> FromFormComplex([FromForm] Student student)
        {
            return new Student { Id = student.Id, EnrollmentNo = student.EnrollmentNo, RollNo = student.RollNo };
        }
        #endregion

        #region FromHeader
        [HttpGet("FromHeaderSimple")]
        public ActionResult<Student> FromHeaderSimple([FromHeader] int id, [FromHeader] int enrollmentNo, [FromHeader] int rollNo)
        {
            return new Student { Id = id, EnrollmentNo = enrollmentNo, RollNo = rollNo };
        }
        //[HttpPost("FromHeaderComplex")]
        //public ActionResult<Student> FromHeaderComplex([FromHeader] Student student)
        //{
        //    return new Student { Id = student.Id, EnrollmentNo = student.EnrollmentNo, RollNo = student.RollNo };
        //}
        #endregion

        //[HttpPost()]
        //public ActionResult<string[]> Array([FromQuery]string[] arr)
        //{
        //    return arr;
        //}
    }
}
