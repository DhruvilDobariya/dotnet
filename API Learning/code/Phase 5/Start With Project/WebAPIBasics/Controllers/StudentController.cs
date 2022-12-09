using Microsoft.AspNetCore.Mvc;
using System.Web.Http;
using WebAPIBasics.Models;

namespace WebAPIBasics.Controllers
{
    [ApiController]
    [Microsoft.AspNetCore.Mvc.Route("api/[Controller]s")]
    public class StudentController : ControllerBase
    {
        [Microsoft.AspNetCore.Mvc.HttpPost("{id}")]
        public ActionResult<Student> FromUriFromBody([FromUri] int id, [Microsoft.AspNetCore.Mvc.FromBody] int enrollmentNo, [FromUri] int rollNo) // By default 
        {
            return new Student { Id = id, EnrollmentNo = enrollmentNo, RollNo = rollNo };
        }

        [Microsoft.AspNetCore.Mvc.HttpPost("")]
        public ActionResult<Student> PostStudent(Student student)
        {
            return student;
        }

        // FromURI :
        // all text perameter by default comeing from uri
        // We can get multipule peramereter from uri
        // We can't get object as parameter using FromUri

        // FromBody
        // FromBody not availabe in Get Methods
        // object and text perameter come by default from body
        // When we want to get object as parameter then it's come from body by default.
        // We can get only one parameter from body


    }
}
