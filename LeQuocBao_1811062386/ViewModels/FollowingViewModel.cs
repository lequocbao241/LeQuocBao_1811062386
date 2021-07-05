using LeQuocBao_1811062386.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LeQuocBao_1811062386.ViewModels
{
    public class FollowingViewModel
    {
        public IEnumerable<ApplicationUser> Followings { get; set; }
        public bool ShowAction { get; set; }
    }
}