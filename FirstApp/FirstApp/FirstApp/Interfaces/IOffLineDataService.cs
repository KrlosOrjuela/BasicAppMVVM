using System;
using System.Collections.Generic;
using FirstApp.Models;

namespace FirstApp.Interfaces
{
	public interface IOffLineDataService
	{
		List<Section> GetMockSections();
	}
}

