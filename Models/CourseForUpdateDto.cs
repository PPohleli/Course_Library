﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using CourseLibrary.API.ValidationAttributes;

namespace CourseLibrary.API.Models
{
  public class CourseForUpdateDto : CourseForManipulationDto
  {
    [Required(ErrorMessage = "You should provide a description.")]
    public override string Description { get => base.Description; set => base.Description = value; }
  }
}
