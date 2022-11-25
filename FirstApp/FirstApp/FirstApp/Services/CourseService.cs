using System;
using System.Collections.Generic;
using System.Linq;
using FirstApp.Interfaces;
using FirstApp.Models;
using FirstApp.ViewModels;

namespace FirstApp.Services
{
    public class CourseService : ICourseService
    {
        private readonly IOffLineDataService offLineDataService;

        public CourseService()
        {
            this.offLineDataService = new OffLineDataService();
        }

        public List<VMSection> GetCourseSections()
        {
            /// have a list of sections coming from offlineDataService
            var sections = this.offLineDataService.GetMockSections();
            /// converting each section into VMSection
            sections.ForEach(s => GetSectionViewModel(s));
            /// return the list of VMSection 
            return sections.Select(s => GetSectionViewModel(s)).ToList();
        }

        private VMSection GetSectionViewModel(Section section)
        {
            return new VMSection(section);
        }
    }
}

