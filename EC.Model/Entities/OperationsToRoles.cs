﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EC.Model.Entities
{
    public class OperationsToRoles
    {
        public string RoleName { get; set; }
        public int ResourceId { get; set; }
        public Operations Operations { get; set; }
    }
}