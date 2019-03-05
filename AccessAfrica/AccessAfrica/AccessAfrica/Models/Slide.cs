using System;
using System.Collections.Generic;
using System.Text;

namespace AccessAfrica.Models
{
    public class Slide
    {

        public string Image { get; set; }

        public string Description { get; set; }


        public Slide(string image, string description )
        {
            Image = image;
            Description = description;
        }
    }
}
