﻿using MvcTemplate.Components.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MvcTemplate.Objects
{
    public class Role : BaseModel
    {
        [Required]
        [StringLength(128)]
        [Index(IsUnique = true)]
        public String Title { get; set; }

        public virtual IList<RolePermission> Permissions { get; set; }
    }
}
