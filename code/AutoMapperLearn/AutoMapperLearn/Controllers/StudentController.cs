using AutoMapper;
using AutoMapperLearn.Models.DTO;
using AutoMapperLearn.Models.POCO;
using Microsoft.AspNetCore.Mvc;

namespace AutoMapperLearn.Controllers
{
    [Route("api/[controller]s")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private static List<Student> _students = new List<Student>
        {
           new Student()
           {
               StudentId = 1,
               FirstName = "Dhruvil",
               LastName = "Dobariya"
           },
           new Student()
           {
               StudentId = 2,
               FirstName = "Jenil",
               LastName = "Vasoya"
           },
           new Student()
           {
               StudentId = 3,
               FirstName = "Bhargav",
               LastName = "Vachhani"
           },
           new Student()
           {
               StudentId = 4,
               FirstName = "Dhaval",
               LastName = "Dobariya"
           },
        };

        private readonly IMapper _mapper;
        public StudentController(IMapper mapper)
        {
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult GetStudents()
        {
            //Mapper mapper = AutoMapperConfig.InitializeAutomapper();
            //StudentDTO studentDTO = mapper.Map<StudentDTO>(_students[0]);

            List<StudentDTO> studentDTO = _mapper.Map<List<StudentDTO>>(_students);
            return Ok(studentDTO);
        }

        [HttpGet("{id:int}")]
        public IActionResult GetStudent(int id)
        {
            Student student = _students.FirstOrDefault(x => x.StudentId == id);
            if (student != null)
            {
                return Ok(student);
            }
            return NotFound();

        }

        [HttpPost]
        public IActionResult AddStudent(StudentDTO studentDTO)
        {
            Student student = _mapper.Map<Student>(studentDTO);
            _students.Add(student);
            return Created("", student);
        }

        [HttpPut]
        public IActionResult UpdateStudent(Student student)
        {
            if (_students.FirstOrDefault(x => x.StudentId == student.StudentId) != null)
            {
                _students.Remove(student);
                _students.Add(student);
                return Ok();
            }
            return NotFound();
        }

        [HttpDelete("{id:int}")]
        public IActionResult DeleteStudent(int id)
        {
            Student student = _students.FirstOrDefault(x => x.StudentId == id);
            if (student != null)
            {
                _students.Remove(student);
            }
            return NotFound();
        }
    }
}
