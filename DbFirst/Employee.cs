﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

#nullable disable

namespace DAL
{
    public partial class Employee
    {
        public int EmpId { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string ImgPath { get; set; }
        public int Deptid { get; set; }

        public virtual Department Dept { get; set; }
    }
}