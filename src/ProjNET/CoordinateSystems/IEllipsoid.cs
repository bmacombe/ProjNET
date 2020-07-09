// Copyright 2005 - 2020 - Morten Nielsen (www.xaml.dev)
//
// This file is part of ProjNet.
//
// MIT License  
//  
// Permission is hereby granted, free of charge, to any person obtaining a copy of this  
// software and associated documentation files (the "Software"), to deal in the Software  
// without restriction, including without limitation the rights to use, copy, modify, merge,  
// publish, distribute, sublicense, and/or sell copies of the Software, and to permit persons  
// to whom the Software is furnished to do so, subject to the following conditions:  
//  
// The above copyright notice and this permission notice shall be included in all copies or  
// substantial portions of the Software.  
//  
// THE SOFTWARE IS PROVIDED *AS IS*, WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED,  
// INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR  
// PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE  
// FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR  
// OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER  
// DEALINGS IN THE SOFTWARE.  

using System;
using System.Collections.Generic;
using System.Text;

namespace ProjNet.CoordinateSystems
{
	/// <summary>
	/// The IEllipsoid interface defines the standard information stored with ellipsoid objects.
	/// </summary>
	public interface IEllipsoid : IInfo
	{
		/// <summary>
		/// Gets or sets the value of the semi-major axis.
		/// </summary>
		double SemiMajorAxis { get; set; }
		/// <summary>
		/// Gets or sets the value of the semi-minor axis.
		/// </summary>
		double SemiMinorAxis { get; set; }
		/// <summary>
		/// Gets or sets the value of the inverse of the flattening constant of the ellipsoid.
		/// </summary>
		double InverseFlattening { get; set; }
		/// <summary>
		/// Gets or sets the value of the axis unit.
		/// </summary>
		ILinearUnit AxisUnit { get; set; }
		/// <summary>
		/// Is the Inverse Flattening definitive for this ellipsoid? Some ellipsoids use the
		/// IVF as the defining value, and calculate the polar radius whenever asked. Other
		/// ellipsoids use the polar radius to calculate the IVF whenever asked. This
		/// distinction can be important to avoid floating-point rounding errors.
		/// </summary>
		bool IsIvfDefinitive { get; set; }
	}
}
