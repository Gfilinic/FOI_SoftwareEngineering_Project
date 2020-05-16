using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBase
{
    public class Image
    {
        public int Id_image { get; set; }
        public byte[] Image_ { get; set; }

        public Image(int id_image, byte[] image)
        {
            this.Id_image = id_image;
            this.Image_ = image;
        }
    }
}
