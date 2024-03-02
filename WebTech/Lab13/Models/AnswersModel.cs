using System.ComponentModel.DataAnnotations;
using System.Numerics;
using System.Runtime.CompilerServices;
using Microsoft.Extensions.FileSystemGlobbing.Internal.PathSegments;

namespace Lab13.Models
{
    public class AnswerModel(){
        [Required]
        [RegularExpression(@"^[-+]?\d+\.?\d*$")]
        public string answer{get;set;}
    }
}