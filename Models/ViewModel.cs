using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Cellogram.Models
{
   public class ViewModel  
{  
    public IEnumerable<Post> Posts { get; set; }  
    public IEnumerable<Story> Storys { get; set; } 
    
  
}  

}
