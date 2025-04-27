﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.BLL.Dtos
{
    public class DepartmentToCreateDto
    {
        public string Name { get; set; } = null!;
        public string? Description { get; set; }
        public string Code { get; set; } = null!;
        public DateOnly CreationDate { get; set; }
    }
}
