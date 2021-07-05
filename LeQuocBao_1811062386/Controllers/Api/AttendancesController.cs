﻿using LeQuocBao_1811062386.DTO;
using LeQuocBao_1811062386.Models;
using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace LeQuocBao_1811062386.Controllers.Api
{
    
        [Authorize]
        public class AttendancesController : ApiController
        {
            private ApplicationDbContext _dbContext;

            public AttendancesController()
            {
                _dbContext = new ApplicationDbContext();
            }

            /*
            [HttpPost]
            public IHttpActionResult Attend([FromBody] int courseId)
            {
                var userId = User.Identity.GetUserId();
                if (_dbContext.Attendances.Any(a => a.AttendeeId == userId && a.CourseId == courseId))
                {
                    return BadRequest("The Attendance already exits");
                }
                var attendance = new Attendance
                {
                    CourseId = courseId,
                    AttendeeId = userId


                };

                _dbContext.Attendances.Add(attendance);
                _dbContext.SaveChanges();

                return Ok();

            }
            */

            [HttpPost]
            public IHttpActionResult Attend(AttendanceDTO attendanceDTO)
            {
                var userId = User.Identity.GetUserId();
                if (_dbContext.Attendances.Any(a => a.AttendeeId == userId && a.CourseId == attendanceDTO.courseId))
                {
                    return BadRequest("The Attendance already exits");
                }
                var attendance = new Attendance
                {
                    CourseId = attendanceDTO.courseId,
                    AttendeeId = userId


                };

                _dbContext.Attendances.Add(attendance);
                _dbContext.SaveChanges();

                return Ok();

            }


        }
    
}