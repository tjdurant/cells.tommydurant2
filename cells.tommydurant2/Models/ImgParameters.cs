using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace cells.tommydurant2.Models
{
    public class ImgParameters
    {
        public int ID { get; set; }

        //This contains a path where the image is locally stored on the server
        public string ImageFile { get; set; }
        public string Caption { get; set; }
        byte[] Image { get; set; }
    }
}
