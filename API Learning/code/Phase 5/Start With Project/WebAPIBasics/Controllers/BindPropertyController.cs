using Microsoft.AspNetCore.Mvc;
using WebAPIBasics.Models;

namespace WebAPIBasics.Controllers
{
    [ApiController]
    [Route("api/[Controller]s")]
    public class BindPropertyController : Controller
    {
        [BindProperty]
        public Student student { get; set; }

        // We can use bind property aslo this way.
        // [BindProperty]
        // public int Id { get; set; }
        // [BindProperty]
        // public int EnrollmentNo { get; set; }
        // [BindProperty]
        // public int RollNo { get; set; }

        // BindProperty
        // Parameter comes from form data(Key Value pair).
        // All method of controller have permision to get parameter.
        // It dose not work on get method.
        // If We want to use with get method then we pass parameter SupportsGet = true in BindProperty
        // For Example : [BindPropertiy(SupportsGet = true)]

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
