using System;
using System.Collections.Generic;
using FirstApp.Models;
using FirstApp.ViewModels;

namespace FirstApp.Interfaces
{
	public interface ICourseService
	{
        List<VMSection> GetCourseSections();
    }
}

