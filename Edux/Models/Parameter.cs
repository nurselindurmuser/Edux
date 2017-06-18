﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Edux.Models
{
    public class Parameter : BaseEntity
    {
        public Parameter() : base()
        {
            CreateDate = DateTime.Now;
            CreatedBy = "username";
            UpdateDate = DateTime.Now;
            UpdatedBy = "username";
        }
        [StringLength(200)]
        public string Name { get; set; }
        [StringLength(200)]
        public string DisplayName { get; set; }
        public bool IsRequired { get; set; }
        public long ComponentTypeId { get; set; }
        [ForeignKey("ComponentTypeId")]
        public ComponentType ComponentType { get; set; }
        public int Position { get; set; }
    }
}
