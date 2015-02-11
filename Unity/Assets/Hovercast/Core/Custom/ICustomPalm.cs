﻿using System;
using Hovercast.Core.Navigation;

namespace Hovercast.Core.Custom {

	/*================================================================================================*/
	public interface ICustomPalm {


		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		Type GetPalmRenderer(NavItem pNavItem);

		/*--------------------------------------------------------------------------------------------*/
		SegmentSettings GetPalmSettings(NavItem pNavItem);

	}

}