using System;
using System.Collections.Generic;

namespace SchoolManagementSystem.Models;

public partial class StudentAttendance
{
    public int Id { get; set; }

    public int StudentId { get; set; }

    public int SubjectId { get; set; }

    public string? RollNo { get; set; }

    public bool? Status { get; set; }

    public DateOnly Date { get; set; }

    public DateTime? CreatedDate { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public virtual Student Student { get; set; } = null!;

    public virtual Subject Subject { get; set; } = null!;
}
