﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DtoModel
{
    public class PictureDto
    {
        public int Id { get; set; }

        public byte[] Picture { get; set; }

        public string PictureName { get; set; }
    }
}
