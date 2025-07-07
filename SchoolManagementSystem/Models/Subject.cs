using System;
using System.Collections.Generic;

namespace SchoolManagementSystem.Models;

public partial class Subject
{
    public int SubjectId { get; set; }

    public int ClassId { get; set; }

    public string? SubjectName { get; set; }

    public DateTime? CreatedDate { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public virtual Class Class { get; set; } = null!;

    public virtual ICollection<Exam> Exams { get; set; } = new List<Exam>();

    public virtual ICollection<Expense> Expenses { get; set; } = new List<Expense>();

    public virtual ICollection<StudentAttendance> StudentAttendances { get; set; } = new List<StudentAttendance>();

    public virtual ICollection<TeacherSubject> TeacherSubjects { get; set; } = new List<TeacherSubject>();
}
