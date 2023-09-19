using ChnageTrackerLearn.Data;
using ChnageTrackerLearn.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Org.BouncyCastle.Security;

namespace ChnageTrackerLearn.Controllers;

[ApiController]
[Route("api/[controller]/[action]")]
public class ChangeTrakerController : ControllerBase
{
    private readonly StudentDbContext _context;
    private readonly ILogger<ChangeTrakerController> _logger;

    public ChangeTrakerController(StudentDbContext context, ILogger<ChangeTrakerController> logger)
    {
        _context = context;
        _logger = logger;
    }
    
    [HttpGet]
    public IActionResult GetStudent()
    {
        var students = _context.Students.ToList();
        DisplayChanges(_context.ChangeTracker.Entries());
        
        return Ok(students);
        // Log output
        // ChnageTrackerLearn.Controllers.ChangeTrakerController[0] 
        // Entity: Student, State: Unchanged
        // info: ChnageTrackerLearn.Controllers.ChangeTrakerController[0] 
        // Entity: Student, State: Unchanged
        // info: ChnageTrackerLearn.Controllers.ChangeTrakerController[0]
        // Entity: Student, State: Unchanged
        // info: ChnageTrackerLearn.Controllers.ChangeTrakerController[0]
        // Entity: Student, State: Unchanged
        // info: ChnageTrackerLearn.Controllers.ChangeTrakerController[0]
        // Entity: Student, State: Unchanged
    }
    
    [HttpPost]
    public IActionResult AddStudent(Student student)
    {
        _context.Students.Add(student);
        DisplayChanges(_context.ChangeTracker.Entries());
        return Created("", student);
        
        // If we update anything without use of key the it will comes in add state, if we use key the it comes in update state.
        // But if we use add method with key then it don't comes in update state.
        // It don't matter that we should save changes or not
        
        // info: ChnageTrackerLearn.Controllers.ChangeTrakerController[0] 
        // Entity: Student, State: Added
    }
    
    [HttpPut]
    public IActionResult UpdateStudent(Student student)
    {
        _context.Students.Update(student);
        DisplayChanges(_context.ChangeTracker.Entries());
        return Created("", student);
        
        // {
        //     "studentName": "Dhaval New"
        // }
        // info: ChnageTrackerLearn.Controllers.ChangeTrakerController[0] 
        // Entity: Student, State: Added
        // As we should see in last method that if we should add or update without key the it comes in added state 

        // {
        //     "studentId": 2,
        //     "studentName": "Dhaval New"
        // }
        // info: ChnageTrackerLearn.Controllers.ChangeTrakerController[0] 
        // Entity: Student, State: Modified
    }

    [HttpGet]
    public IActionResult GetUpdateStudent()
    {
        var student = _context.Students.ToList().First();
        student.StudentName = "Dhruvil A. Dobariya";
        DisplayChanges(_context.ChangeTracker.Entries());
        return Ok(student);
        // Because we should change update first student's name so result is,
        // ChnageTrackerLearn.Controllers.ChangeTrakerController[0] 
        // Entity: Student, State: Modified
        // info: ChnageTrackerLearn.Controllers.ChangeTrakerController[0] 
        // Entity: Student, State: Unchanged
        // info: ChnageTrackerLearn.Controllers.ChangeTrakerController[0]
        // Entity: Student, State: Unchanged
        // info: ChnageTrackerLearn.Controllers.ChangeTrakerController[0]
        // Entity: Student, State: Unchanged
        // info: ChnageTrackerLearn.Controllers.ChangeTrakerController[0]
        // Entity: Student, State: Unchanged
    }

    [HttpDelete]
    public IActionResult DeleteStudent(int id)
    {
        var student = _context.Students.Find(id);
        if (student is not null)
        {
            _context.Students.Remove(student);
            DisplayChanges(_context.ChangeTracker.Entries());
            return Ok("Student deleted successfully");
            
            // info: ChnageTrackerLearn.Controllers.ChangeTrakerController[0] 
            // Entity: Student, State: Deleted
        }
        return NotFound();
    }

    [HttpGet]
    public IActionResult DetachLearn()
    {
        var student = new Student()
        {
            StudentId = 7,
            StudentName = "Alex"
        };
        var students = _context.Students.ToList();
        _logger.LogInformation(_context.Entry(student).State.ToString());
        return Ok();
        
        // info: ChnageTrackerLearn.Controllers.ChangeTrakerController[0] 
        // Detached

        // We can also change state at eny movement but it also affect on attached instance,
        // Ex: _context.Entry(students).State = EntryState.Detach;
        // When we select all student and stored in students variable at a time we get entity state is unchnage.
        // After that that variable contains list of students.
        // But if we change state as detach, now if we see the students variable then we don't see the data of all student.
        // It is also more important to use when we should work with multiple type of entities.
    }

    private void DisplayChanges(IEnumerable<EntityEntry> entries)
    {
        foreach (var entity in entries)
        {
            _logger.LogInformation($"Entity: {entity.Entity.GetType().Name}, State: {entity.State.ToString()}");
        }
    }
}