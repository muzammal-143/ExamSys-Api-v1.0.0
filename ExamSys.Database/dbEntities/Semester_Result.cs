﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamSys.Database.dbEntities
{
    public class Semester_Result : Properties
    {
        public int          id          { get; set; }

        [Display(Name = "Total Marks")]
        public double       TM          { get; set; }
        [Display(Name = "Obtain Marks")]
        public double       OM          { get; set; }

        public Session Session { get; set; }
        public int Semester { get; set; }

        //Relations
        public User      Student     { get; set; }
        public Department    Department  { get; set; }
        public Session_Course Session_Course { get; set; }
        public Result_Type  Result_Type { get; set; }
        

        public Semester_Result()
        {
        }
        
    }
}
