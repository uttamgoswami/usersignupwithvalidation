using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace UserSignUpWithValidation.Attributes
{
    public class ValidateCheckBox : ValidationAttribute
    {
        public override bool IsValid(object value)
        {
           
                return (bool)value;
            }
            
        }
    }

