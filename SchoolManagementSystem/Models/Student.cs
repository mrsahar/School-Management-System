using System;
using System.Collections.Generic;

namespace SchoolManagementSystem.Models;

public partial class Student
{
    public int StudentId { get; set; }

    public string StudentName { get; set; } = null!;

    public DateOnly? Dob { get; set; }

    public string? Gender { get; set; }

    public string? Mobile { get; set; }

    public string? Email { get; set; }

    public string? Address { get; set; }

    public string? RollNo { get; set; }

    public DateTime? CreatedDate { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public virtual ICollection<StudentAttendance> StudentAttendances { get; set; } = new List<StudentAttendance>();
}
