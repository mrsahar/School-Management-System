using System;
using System.Collections.Generic;

namespace SchoolManagementSystem.Models;

public partial class Fee
{
    public int FeesId { get; set; }

    public int? ClassId { get; set; }

    public int FeesAmount { get; set; }

    public DateTime? CreatedDate { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public virtual Class? Class { get; set; }
}
