using Microsoft.AspNetCore.Mvc;
using WebAPIBasics.Models;

namespace WebAPIBasics.Controllers
{
    [ApiController]
    [Route("api/[Controller]s")]
    [BindProperties]
    public class BindPropertiesController : Controller
    {
        public Student student { get; set; }

        // We can use bind property aslo this way.
        // public int Id { get; set; }
        // public int EnrollmentNo { get; set; }
        // public int RollNo { get; set; }

        // BindPropertie
        // This is controller level.
        // Parameter comes from form data(Key Value pair).
        // All method of controller have permision to get parameter.
        // It dose not work on get method.
        // If We want to use with get method then we pass parameter SupportsGet = true in BindProperty
        // For Example : [BindProperties(SupportsGet = true)]

        [HttpPost("Index")]
        public ActionResult<Student> Index()
        {
            return student;
        }
        // Curl is :
        // curl -X 'POST' \
        // 'https://localhost:44362/api/ModelBinders?student.Id=1&student.EnrollmentNo=1&student.RollNo=1' \
        // -H 'accept: text/plain' \
        // -d ''

        [HttpPost("Index2")]
        public ActionResult<Student> Index2()
        {
            return student;
        }
        // Curl is :
        // curl -X 'POST' \
        // 'https://localhost:44362/api/ModelBinders?student.Id=1&student.EnrollmentNo=1&student.RollNo=1' \
        // -H 'accept: text/plain' \
        // -d ''

    }
}
