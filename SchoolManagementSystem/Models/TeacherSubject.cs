using System;
using System.Collections.Generic;

namespace SchoolManagementSystem.Models;

public partial class TeacherSubject
{
    public int Id { get; set; }

    public int ClassId { get; set; }

    public int SubjectId { get; set; }

    public int TeacherId { get; set; }

    public DateTime? CreatedDate { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public virtual Class Class { get; set; } = null!;

    public virtual Subject Subject { get; set; } = null!;

    public virtual Teacher Teacher { get; set; } = null!;
}
