using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace RVTR.Booking.ObjectModel.Models
{
  public class Booking : IValidatableObject
  {
    public IEnumerable<ValidationResult> Validate(ValidationContext validationContext) => throw new System.NotImplementedException();
  }
}
