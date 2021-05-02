using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Cellogram.Models
{
    public class Story
    {   
        public long Id { get; set; }

        public string _key;

        public string Key
        {
            get
            {
                return _key;
            }
            set { _key = value; }
        }

        public String ProfileImage {get; set;}
        public String User {get; set;}
        public String Image {get;set;}
        public DateTime Posted {get; set;}
        
    }

}
