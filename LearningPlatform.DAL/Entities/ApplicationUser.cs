﻿using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningPlatform.DAL.Entities
{
	public class ApplicationUser:IdentityUser
	{
		public string Name {  get; set; }
	}
}
