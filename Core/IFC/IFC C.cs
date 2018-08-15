// MIT License
// Copyright (c) 2016 Geometry Gym Pty Ltd

// Permission is hereby granted, free of charge, to any person obtaining a copy of this software 
// and associated documentation files (the "Software"), to deal in the Software without restriction, 
// including without limitation the rights to use, copy, modify, merge, publish, distribute, sublicense, 
// and/or sell copies of the Software, and to permit persons to whom the Software is furnished to do so, 
// subject to the following conditions:

// The above copyright notice and this permission notice shall be included in all copies or substantial 
// portions of the Software.

// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT 
// LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. 
// IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, 
// WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE 
// SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.

using System;
using System.Collections.Generic;
using System.Text;
using System.Reflection;
using System.IO;
using System.ComponentModel;
using System.Linq;

using GeometryGym.STEP;


namespace GeometryGym.Ifc
{
	public partial class IfcCableCarrierFitting : IfcFlowFitting //IFC4
	{
		internal IfcCableCarrierFittingTypeEnum mPredefinedType = IfcCableCarrierFittingTypeEnum.NOTDEFINED;// OPTIONAL : IfcCableCarrierFittingTypeEnum;
		public IfcCableCarrierFittingTypeEnum PredefinedType { get { return mPredefinedType; } set { mPredefinedType = value; } }
		internal IfcCableCarrierFitting() : base() { }
		internal IfcCableCarrierFitting(DatabaseIfc db, IfcCableCarrierFitting f) : base(db,f) { mPredefinedType = f.mPredefinedType; }
		protected IfcCableCarrierFitting(IfcObjectDefinition host, IfcObjectPlacement placement, IfcProductRepresentation representation, IfcDistributionSystem system) : base(host, placement, representation, system) { }

		internal static void parseFields(IfcCableCarrierFitting s, List<string> arrFields, ref int ipos)
		{
			IfcEnergyConversionDevice.parseFields(s, arrFields, ref ipos);
			string str = arrFields[ipos++];
			if (str[0] == '.')
				s.mPredefinedType = (IfcCableCarrierFittingTypeEnum)Enum.Parse(typeof(IfcCableCarrierFittingTypeEnum), str);
		}
		internal new static IfcCableCarrierFitting Parse(string strDef) { IfcCableCarrierFitting s = new IfcCableCarrierFitting(); int ipos = 0; parseFields(s, ParserSTEP.SplitLineFields(strDef), ref ipos); return s; }
		protected override string BuildStringSTEP()
		{
			return base.BuildStringSTEP() + (mDatabase.mRelease == ReleaseVersion.IFC2x3 ? "" : (mPredefinedType == IfcCableCarrierFittingTypeEnum.NOTDEFINED ? ",$" : ",." + mPredefinedType.ToString() + "."));
		}
	}
	public partial class IfcCableCarrierFittingType : IfcFlowFittingType
	{
		internal IfcCableCarrierFittingTypeEnum mPredefinedType = IfcCableCarrierFittingTypeEnum.NOTDEFINED;// : IfcDuctFittingTypeEnum; 
		public IfcCableCarrierFittingTypeEnum PredefinedType { get { return mPredefinedType; } set { mPredefinedType = value; } }
		internal IfcCableCarrierFittingType() : base() { }
		internal IfcCableCarrierFittingType(DatabaseIfc db, IfcCableCarrierFittingType t) : base(db, t) { mPredefinedType = t.mPredefinedType; }
		internal static void parseFields(IfcCableCarrierFittingType t, List<string> arrFields, ref int ipos) { IfcFlowFittingType.parseFields(t, arrFields, ref ipos); t.mPredefinedType = (IfcCableCarrierFittingTypeEnum)Enum.Parse(typeof(IfcCableCarrierFittingTypeEnum), arrFields[ipos++].Replace(".", "")); }
		internal new static IfcCableCarrierFittingType Parse(string strDef) { IfcCableCarrierFittingType t = new IfcCableCarrierFittingType(); int ipos = 0; parseFields(t, ParserSTEP.SplitLineFields(strDef), ref ipos); return t; }
		protected override string BuildStringSTEP() { return base.BuildStringSTEP() + ",." + mPredefinedType.ToString() + "."; }
	}
	public partial class IfcCableCarrierSegment : IfcFlowSegment //IFC4
	{
		internal IfcCableCarrierSegmentTypeEnum mPredefinedType = IfcCableCarrierSegmentTypeEnum.NOTDEFINED;// OPTIONAL : IfcCableCarrierSegmentTypeEnum;
		public IfcCableCarrierSegmentTypeEnum PredefinedType { get { return mPredefinedType; } set { mPredefinedType = value; } }

		internal IfcCableCarrierSegment() : base() { }
		internal IfcCableCarrierSegment(DatabaseIfc db, IfcCableCarrierSegment s) : base(db,s) { mPredefinedType = s.mPredefinedType; }
 
		internal static void parseFields(IfcCableCarrierSegment s, List<string> arrFields, ref int ipos)
		{
			IfcFlowSegment.parseFields(s, arrFields, ref ipos);
			string str = arrFields[ipos++];
			if (str[0] == '.')
				s.mPredefinedType = (IfcCableCarrierSegmentTypeEnum)Enum.Parse(typeof(IfcCableCarrierSegmentTypeEnum), str);
		}
		internal new static IfcCableCarrierSegment Parse(string strDef) { IfcCableCarrierSegment s = new IfcCableCarrierSegment(); int ipos = 0; parseFields(s, ParserSTEP.SplitLineFields(strDef), ref ipos); return s; }
		protected override string BuildStringSTEP() { return base.BuildStringSTEP() + (mDatabase.mRelease == ReleaseVersion.IFC2x3 ? "" : (mPredefinedType == IfcCableCarrierSegmentTypeEnum.NOTDEFINED ? ",$" : ",." + mPredefinedType.ToString() + ".")); }
	}
	public partial class IfcCableCarrierSegmentType : IfcFlowSegmentType
	{
		internal IfcCableCarrierSegmentTypeEnum mPredefinedType = IfcCableCarrierSegmentTypeEnum.NOTDEFINED;// : IfcCableCarrierSegmentTypeEnum; 
		public IfcCableCarrierSegmentTypeEnum PredefinedType { get { return mPredefinedType; } set { mPredefinedType = value; } }

		internal IfcCableCarrierSegmentType() : base() { }
		internal IfcCableCarrierSegmentType(DatabaseIfc db, IfcCableCarrierSegmentType t) : base(db, t) { mPredefinedType = t.mPredefinedType; }
		internal IfcCableCarrierSegmentType(DatabaseIfc m, string name, IfcCableCarrierSegmentTypeEnum t) : base(m) { Name = name; mPredefinedType = t; }
		internal static void parseFields(IfcCableCarrierSegmentType t, List<string> arrFields, ref int ipos) { IfcFlowSegmentType.parseFields(t, arrFields, ref ipos); t.mPredefinedType = (IfcCableCarrierSegmentTypeEnum)Enum.Parse(typeof(IfcCableCarrierSegmentTypeEnum), arrFields[ipos++].Replace(".", "")); }
		internal new static IfcCableCarrierSegmentType Parse(string strDef) { IfcCableCarrierSegmentType t = new IfcCableCarrierSegmentType(); int ipos = 0; parseFields(t, ParserSTEP.SplitLineFields(strDef), ref ipos); return t; }
		protected override string BuildStringSTEP() { return base.BuildStringSTEP() + ",." + mPredefinedType.ToString() + "."; }
	}
	public partial class IfcCableFitting : IfcFlowFitting //IFC4
	{
		internal IfcCableFittingTypeEnum mPredefinedType = IfcCableFittingTypeEnum.NOTDEFINED;// OPTIONAL : IfcCableFittingTypeEnum;
		public IfcCableFittingTypeEnum PredefinedType { get { return mPredefinedType; } set { mPredefinedType = value; } }

		internal IfcCableFitting() : base() { }
		internal IfcCableFitting(DatabaseIfc db, IfcCableFitting f) : base(db, f) { mPredefinedType = f.mPredefinedType; }
		protected IfcCableFitting(IfcObjectDefinition host, IfcObjectPlacement placement, IfcProductRepresentation representation, IfcDistributionSystem system) : base(host, placement, representation, system) { }

		internal static void parseFields(IfcCableFitting s, List<string> arrFields, ref int ipos)
		{
			IfcEnergyConversionDevice.parseFields(s, arrFields, ref ipos);
			string str = arrFields[ipos++];
			if (str[0] == '.')
				s.mPredefinedType = (IfcCableFittingTypeEnum)Enum.Parse(typeof(IfcCableFittingTypeEnum), str);
		}
		internal new static IfcCableFitting Parse(string strDef) { IfcCableFitting s = new IfcCableFitting(); int ipos = 0; parseFields(s, ParserSTEP.SplitLineFields(strDef), ref ipos); return s; }
		protected override string BuildStringSTEP()
		{
			return base.BuildStringSTEP() + (mDatabase.mRelease == ReleaseVersion.IFC2x3 ? "" : (mPredefinedType == IfcCableFittingTypeEnum.NOTDEFINED ? ",$" : ",." + mPredefinedType.ToString() + "."));
		}
	}
	public partial class IfcCableFittingType : IfcFlowFittingType
	{
		internal IfcCableFittingTypeEnum mPredefinedType = IfcCableFittingTypeEnum.NOTDEFINED;// : IfcDuctFittingTypeEnum; 
		public IfcCableFittingTypeEnum PredefinedType { get { return mPredefinedType; } set { mPredefinedType = value; } }

		internal IfcCableFittingType() : base() { }
		internal IfcCableFittingType(DatabaseIfc db, IfcCableFittingType t) : base(db, t) { mPredefinedType = t.mPredefinedType; }
		internal static void parseFields(IfcCableFittingType t, List<string> arrFields, ref int ipos) { IfcFlowFittingType.parseFields(t, arrFields, ref ipos); t.mPredefinedType = (IfcCableFittingTypeEnum)Enum.Parse(typeof(IfcCableFittingTypeEnum), arrFields[ipos++].Replace(".", "")); }
		internal new static IfcCableFittingType Parse(string strDef) { IfcCableFittingType t = new IfcCableFittingType(); int ipos = 0; parseFields(t, ParserSTEP.SplitLineFields(strDef), ref ipos); return t; }
		protected override string BuildStringSTEP() { return base.BuildStringSTEP() + ",." + mPredefinedType.ToString() + "."; }
	}
	public partial class IfcCableSegment : IfcFlowSegment //IFC4
	{
		internal IfcCableSegmentTypeEnum mPredefinedType = IfcCableSegmentTypeEnum.NOTDEFINED;// OPTIONAL : IfcCableSegmentTypeEnum;
		public IfcCableSegmentTypeEnum PredefinedType { get { return mPredefinedType; } set { mPredefinedType = value; } }
		
		internal IfcCableSegment() : base() { }
		internal IfcCableSegment(DatabaseIfc db, IfcCableSegment s) : base(db,s) { mPredefinedType = s.mPredefinedType; }
 
		internal static void parseFields(IfcCableSegment s, List<string> arrFields, ref int ipos)
		{
			IfcFlowSegment.parseFields(s, arrFields, ref ipos);
			string str = arrFields[ipos++];
			if (str[0] == '.')
				s.mPredefinedType = (IfcCableSegmentTypeEnum)Enum.Parse(typeof(IfcCableSegmentTypeEnum), str);
		}
		internal new static IfcCableSegment Parse(string strDef) { IfcCableSegment s = new IfcCableSegment(); int ipos = 0; parseFields(s, ParserSTEP.SplitLineFields(strDef), ref ipos); return s; }
		protected override string BuildStringSTEP() { return base.BuildStringSTEP() + (mDatabase.mRelease == ReleaseVersion.IFC2x3 ? "" : ",." + mPredefinedType.ToString() + "."); }
	}
	public partial class IfcCableSegmentType : IfcFlowSegmentType
	{
		internal IfcCableSegmentTypeEnum mPredefinedType = IfcCableSegmentTypeEnum.NOTDEFINED;// : IfcCableSegmentTypeEnum; 
		public IfcCableSegmentTypeEnum PredefinedType { get { return mPredefinedType; } set { mPredefinedType = value; } }

		internal IfcCableSegmentType() : base() { }
		internal IfcCableSegmentType(DatabaseIfc db, IfcCableSegmentType t) : base(db, t) { mPredefinedType = t.mPredefinedType; }
		internal IfcCableSegmentType(DatabaseIfc m, string name, IfcCableSegmentTypeEnum t) : base(m) { Name = name; mPredefinedType = t; }
		internal IfcCableSegmentType(DatabaseIfc m, string name, IfcMaterialProfileSet mps, IfcCableSegmentTypeEnum t) : base(m) { Name = name; MaterialSelect = mps; PredefinedType = t; }
		internal static void parseFields(IfcCableSegmentType t, List<string> arrFields, ref int ipos) { IfcFlowSegmentType.parseFields(t, arrFields, ref ipos); t.mPredefinedType = (IfcCableSegmentTypeEnum)Enum.Parse(typeof(IfcCableSegmentTypeEnum), arrFields[ipos++].Replace(".", "")); }
		internal new static IfcCableSegmentType Parse(string strDef) { IfcCableSegmentType t = new IfcCableSegmentType(); int ipos = 0; parseFields(t, ParserSTEP.SplitLineFields(strDef), ref ipos); return t; }
		protected override string BuildStringSTEP() { return base.BuildStringSTEP() + ",." + mPredefinedType.ToString() + "."; }
	}
	public partial class IfcCalendarDate : BaseClassIfc, IfcDateTimeSelect //DEPRECEATED IFC4
	{
		internal int mDayComponent;//  : IfcDayInMonthNumber;
		internal int mMonthComponent;//  : IfcMonthInYearNumber;
		internal int mYearComponent;// : IfcYearNumber; 

		internal IfcCalendarDate() : base() { }
		internal IfcCalendarDate(DatabaseIfc db, IfcCalendarDate d) : base(db,d) { mDayComponent = d.mDayComponent; mMonthComponent = d.mMonthComponent; mYearComponent = d.mYearComponent; }
		internal IfcCalendarDate(DatabaseIfc m, int day, int month, int year) : base(m)
		{
			if (m.mRelease != ReleaseVersion.IFC2x3) throw new Exception("IfcCalanderDate DEPRECEATED, use IfcDate");
			mDayComponent = day;
			mMonthComponent = month;
			mYearComponent = year;
		}
		internal static IfcCalendarDate Parse(string strDef) { IfcCalendarDate d = new IfcCalendarDate(); int ipos = 0; parseFields(d, ParserSTEP.SplitLineFields(strDef), ref ipos); return d; }
		internal static void parseFields(IfcCalendarDate c, List<string> arrFields, ref int ipos)
		{
			c.mDayComponent = ParserSTEP.ParseInt(arrFields[ipos++]);
			c.mMonthComponent = ParserSTEP.ParseInt(arrFields[ipos++]);
			c.mYearComponent = ParserSTEP.ParseInt(arrFields[ipos++]);
		}
		protected override string BuildStringSTEP() { return base.BuildStringSTEP() + "," + mDayComponent + "," + mMonthComponent + "," + mYearComponent; }
		public DateTime DateTime { get { return new DateTime(mYearComponent, mMonthComponent, mDayComponent); } }
	}
	public partial class IfcCartesianPoint : IfcPoint
	{
		private double mCoordinateX = 0, mCoordinateY = double.NaN, mCoordinateZ = double.NaN;

		public Tuple<double,double,double> Coordinates
		{
			get { return new Tuple<double, double, double>(mCoordinateX, mCoordinateY, double.IsNaN(mCoordinateZ) ? 0 : mCoordinateZ); }
			set { mCoordinateX = value.Item1; mCoordinateY = value.Item2; mCoordinateZ = value.Item3; }
		}
		internal IfcCartesianPoint() : base() { }
		internal IfcCartesianPoint(DatabaseIfc db, IfcCartesianPoint p) : base(db, p) { mCoordinateX = p.mCoordinateX; mCoordinateY = p.mCoordinateY; mCoordinateZ = p.mCoordinateZ; }
		
		public IfcCartesianPoint(DatabaseIfc db, double x, double y) : base(db) { mCoordinateX = x; mCoordinateY = y; mCoordinateZ = double.NaN; }
		public IfcCartesianPoint(DatabaseIfc db, double x, double y, double z) : base(db) { mCoordinateX = x; mCoordinateY = y; mCoordinateZ = z; }
		
		internal static IfcCartesianPoint Parse(string str)
		{
			IfcCartesianPoint p = new IfcCartesianPoint();
			string s = str.Trim();
			if (s[0] == '(')
			{
				string[] fields = str.Substring(1,str.Length-2).Split(",".ToCharArray());
				if(fields != null && fields.Length > 0)
				{ 
					p.mCoordinateX = ParserSTEP.ParseDouble(fields[0]);
					if (fields.Length > 1)
					{
						p.mCoordinateY = ParserSTEP.ParseDouble(fields[1]);
						if(fields.Length > 2)
							p.mCoordinateZ = ParserSTEP.ParseDouble(fields[2]);
					}
				}
			}
			return p;
		}
		protected override string BuildStringSTEP()
		{
			double tol = (mDatabase.Factory.mGeometricRepresentationContext != null ? mDatabase.Factory.mGeometricRepresentationContext.mPrecision / 100 : 1e-6);
			int digits = mDatabase.mLengthDigits;
			double x = Math.Round( mCoordinateX,digits), y = Math.Round( double.IsNaN(mCoordinateY) ? 0 : mCoordinateY,digits);

			if (Math.Abs(x) < tol)
				x = 0;
			if (Math.Abs(y) < tol)
				y = 0;
			if (is2D)
				return base.BuildStringSTEP() + ",(" + ParserSTEP.DoubleToString(x) + "," + ParserSTEP.DoubleToString(y) + ")";
			double z = Math.Round( mCoordinateZ,digits);
			if (Math.Abs(z) < tol)
				z = 0;
			return base.BuildStringSTEP() + ",(" + ParserSTEP.DoubleToString(x) + "," + ParserSTEP.DoubleToString(y) + "," + ParserSTEP.DoubleToString(z) + ")";
		}
		internal bool is2D { get { return double.IsNaN(mCoordinateZ); } }
		internal bool isOrigin { get { double tol = mDatabase.Tolerance; return ((double.IsNaN(mCoordinateX) || Math.Abs(mCoordinateX) < tol) && (double.IsNaN(mCoordinateY) || Math.Abs(mCoordinateY) < tol) && (double.IsNaN(mCoordinateZ) || Math.Abs(mCoordinateZ) < tol)); } }
	}
	public abstract partial class IfcCartesianPointList : IfcGeometricRepresentationItem //IFC4
	{
		protected IfcCartesianPointList() : base() { }
		protected IfcCartesianPointList(DatabaseIfc db) : base(db) { }
		protected IfcCartesianPointList(DatabaseIfc db, IfcCartesianPointList l) : base(db,l) { }
	}
	public partial class IfcCartesianPointList2D : IfcCartesianPointList //IFC4
	{ 
		internal Tuple<double, double>[] mCoordList = new Tuple<double, double>[0];//	 :	LIST [1:?] OF LIST [2:2] OF IfcLengthMeasure; 

		internal IfcCartesianPointList2D() : base() { }
		internal IfcCartesianPointList2D(DatabaseIfc db, IfcCartesianPointList2D l) : base(db,l) { mCoordList = l.mCoordList.ToArray(); }
		public IfcCartesianPointList2D(DatabaseIfc m, IEnumerable<Tuple<double, double>> coordList) : base(m)
		{
			List<Tuple<double, double>> pts = new List<Tuple<double, double>>();
			foreach (Tuple<double, double> t in coordList)
				pts.Add(new Tuple<double, double>(t.Item1, t.Item2));
			mCoordList = pts.ToArray();
		}
		internal static IfcCartesianPointList2D Parse(string strDef)
		{
			IfcCartesianPointList2D l = new IfcCartesianPointList2D();
			l.mCoordList = ParserSTEP.SplitListDoubleTuple(strDef);
			return l;
		}
		protected override string BuildStringSTEP()
		{
			StringBuilder sb = new StringBuilder();
			Tuple<double, double> p = mCoordList[0];
			int digits = mDatabase.mLengthDigits;
			sb.Append(",((" + ParserSTEP.DoubleToString(Math.Round(p.Item1,digits)) + "," + ParserSTEP.DoubleToString(Math.Round(p.Item2,digits)) + ")");
			for (int icounter = 1; icounter < mCoordList.Length; icounter++)
			{
				p = mCoordList[icounter];
				sb.Append(",(" + ParserSTEP.DoubleToString(Math.Round(p.Item1, digits)) + "," + ParserSTEP.DoubleToString(Math.Round(p.Item2, digits)) + ")");
			}
			return base.BuildStringSTEP() + sb.ToString() + ")";
		}
	}
	public partial class IfcCartesianPointList3D : IfcCartesianPointList //IFC4
	{
		private Tuple<double, double, double>[] mCoordList = new Tuple<double, double, double>[0];//	 :	LIST [1:?] OF LIST [3:3] OF IfcLengthMeasure; 

		internal IfcCartesianPointList3D() : base() { }
		internal IfcCartesianPointList3D(DatabaseIfc db, IfcCartesianPointList3D l) : base(db,l) { mCoordList = l.mCoordList.ToArray(); }
		internal static IfcCartesianPointList3D Parse(string strDef)
		{
			IfcCartesianPointList3D l = new IfcCartesianPointList3D();
			l.mCoordList = ParserSTEP.SplitListDoubleTriple(strDef);
			return l;
		}
		public IfcCartesianPointList3D(DatabaseIfc m, IEnumerable<Tuple<double, double, double>> coordList) : base(m)
		{
			List<Tuple<double, double, double>> pts = new List<Tuple<double, double, double>>();
			foreach (Tuple<double, double, double> t in coordList)
				pts.Add(new Tuple<double, double, double>(t.Item1, t.Item2, t.Item3));
			mCoordList = pts.ToArray();
		}
		protected override string BuildStringSTEP()
		{
			StringBuilder sb = new StringBuilder();
			int digits = mDatabase.mLengthDigits;
			Tuple<double, double, double> p = mCoordList[0];
			sb.Append(",((" + ParserSTEP.DoubleToString(Math.Round(p.Item1, digits)) + "," + ParserSTEP.DoubleToString(Math.Round(p.Item2,digits)) + "," + ParserSTEP.DoubleToString(Math.Round(p.Item3,digits)) + ")");
			for (int icounter = 1; icounter < mCoordList.Length; icounter++)
			{
				p = mCoordList[icounter];
				sb.Append(",(" + ParserSTEP.DoubleToString(Math.Round(p.Item1, digits)) + "," + ParserSTEP.DoubleToString(Math.Round(p.Item2, digits)) + "," + ParserSTEP.DoubleToString(Math.Round(p.Item3, digits)) + ")");
			}
			return base.BuildStringSTEP() + sb.ToString() + ")";
		}
	}
	public abstract partial class IfcCartesianTransformationOperator : IfcGeometricRepresentationItem /*ABSTRACT SUPERTYPE OF (ONEOF (IfcCartesianTransformationOperator2D ,IfcCartesianTransformationOperator3D))*/
	{ 
		protected int mAxis1;// : OPTIONAL IfcDirection
		protected int mAxis2;// : OPTIONAL IfcDirection;
		private int mLocalOrigin;// : IfcCartesianPoint;
		private double mScale = 1;// : OPTIONAL REAL;

		public IfcDirection Axis1 { get { return mDatabase[mAxis1] as IfcDirection; } set { mAxis1 = (value == null ? 0 : value.mIndex); } }
		public IfcDirection Axis2 { get { return mDatabase[mAxis2] as IfcDirection; } set { mAxis2 = (value == null ? 0 : value.mIndex); } }
		public IfcCartesianPoint LocalOrigin
		{
			get { return mDatabase[mLocalOrigin] as IfcCartesianPoint; }
			set { mLocalOrigin = value.mIndex; }
		}
		public double Scale { get { return mScale; } set { mScale = double.IsNaN( value) || Math.Abs(value) < 1e-6 ? 1 : value; } }

		protected IfcCartesianTransformationOperator() { }
		protected IfcCartesianTransformationOperator(IfcCartesianPoint p) : base(p.mDatabase) { LocalOrigin = p; }
		protected IfcCartesianTransformationOperator(DatabaseIfc db) : base(db)
		{
			LocalOrigin = db.Factory.Origin;
		}
		protected IfcCartesianTransformationOperator(DatabaseIfc db, IfcCartesianTransformationOperator o) : base(db,o) { if(o.mAxis1 > 0) Axis1 = db.Factory.Duplicate( o.Axis1) as IfcDirection; if(o.mAxis2 > 0) Axis2 = db.Factory.Duplicate( o.Axis2) as IfcDirection; LocalOrigin = db.Factory.Duplicate(o.LocalOrigin) as IfcCartesianPoint; mScale = o.mScale; }
		protected IfcCartesianTransformationOperator(IfcDirection ax1, IfcDirection ax2, IfcCartesianPoint o, double scale)
			: base(ax1 == null ? (ax2 == null ? o.mDatabase : ax2.mDatabase) : ax1.mDatabase) { if (ax1 != null) mAxis1 = ax1.mIndex; if (ax2 != null) mAxis2 = ax2.mIndex; mLocalOrigin = o.mIndex; mScale = scale; }
		protected virtual void Parse(string str, ref int pos, int len)
		{
			mAxis1 = ParserSTEP.StripLink(str, ref pos, len);
			mAxis2 = ParserSTEP.StripLink(str, ref pos, len);
			mLocalOrigin = ParserSTEP.StripLink(str, ref pos, len);
			mScale = ParserSTEP.StripDouble(str, ref pos, len);
		}
		protected override string BuildStringSTEP()
		{
			return base.BuildStringSTEP() + "," + ParserSTEP.LinkToString(mAxis1) + "," + ParserSTEP.LinkToString(mAxis2) + "," +
				ParserSTEP.LinkToString(mLocalOrigin) + "," + ParserSTEP.DoubleOptionalToString(mScale);
		}

	}
	public partial class IfcCartesianTransformationOperator2D : IfcCartesianTransformationOperator // SUPERTYPE OF(IfcCartesianTransformationOperator2DnonUniform)
	{
		internal IfcCartesianTransformationOperator2D() : base() { }
		public IfcCartesianTransformationOperator2D(IfcCartesianPoint cp) : base(cp) { }
		public IfcCartesianTransformationOperator2D(DatabaseIfc db) : base(new IfcCartesianPoint(db,0,0)) { }
		internal IfcCartesianTransformationOperator2D(DatabaseIfc db, IfcCartesianTransformationOperator2D o) : base(db,o) { }
		public IfcCartesianTransformationOperator2D(IfcDirection ax1, IfcDirection ax2, IfcCartesianPoint o, double scale) : base(ax1,ax2,o, scale) { }

		internal static IfcCartesianTransformationOperator2D Parse(string str) { IfcCartesianTransformationOperator2D o = new IfcCartesianTransformationOperator2D(); int pos = 0; o.Parse(str, ref pos, str.Length); return o; }
	}
	public partial class IfcCartesianTransformationOperator2DnonUniform : IfcCartesianTransformationOperator2D
	{
		private double mScale2 = double.NaN; //OPTIONAL REAL;
		public double Scale2 { get { return mScale2; } set { mScale2 = value; } }

		internal IfcCartesianTransformationOperator2DnonUniform() : base() { }
		internal IfcCartesianTransformationOperator2DnonUniform(DatabaseIfc db, IfcCartesianTransformationOperator2DnonUniform o) : base(db,o) { mScale2 = o.mScale2; }
		internal static IfcCartesianTransformationOperator2DnonUniform Parse(string str) { IfcCartesianTransformationOperator2DnonUniform o = new IfcCartesianTransformationOperator2DnonUniform(); int pos = 0; o.Parse(str, ref pos, str.Length); return o; }
		protected override void Parse(string str, ref int pos, int len)
		{
			base.Parse(str, ref pos, len);
			mScale2 = ParserSTEP.StripDouble(str, ref pos, len);
		}

		protected override string BuildStringSTEP() { return base.BuildStringSTEP() + "," + ParserSTEP.DoubleOptionalToString(mScale2); }
	}
	public partial class IfcCartesianTransformationOperator3D : IfcCartesianTransformationOperator //SUPERTYPE OF(IfcCartesianTransformationOperator3DnonUniform)
	{
		private int mAxis3;// : OPTIONAL IfcDirection
		public IfcDirection Axis3 { get { return mDatabase[mAxis3] as IfcDirection; } set { mAxis3 = (value == null ? 0 : value.mIndex); } }

		internal IfcCartesianTransformationOperator3D() { }
		public IfcCartesianTransformationOperator3D(DatabaseIfc db) : base(db) { }
		internal IfcCartesianTransformationOperator3D(DatabaseIfc db, IfcCartesianTransformationOperator3D o) : base(db,o) { if(o.mAxis3 > 0) Axis3 = db.Factory.Duplicate( o.Axis3) as IfcDirection; }
		internal static IfcCartesianTransformationOperator3D Parse(string str) { IfcCartesianTransformationOperator3D o = new IfcCartesianTransformationOperator3D(); int pos = 0; o.Parse(str, ref pos, str.Length); return o; }
		protected override void Parse(string str, ref int pos, int len)
		{
			base.Parse(str, ref pos, len);
			mAxis3 = ParserSTEP.StripLink(str, ref pos, len);
		}
		
		protected override string BuildStringSTEP() { return base.BuildStringSTEP() + "," + ParserSTEP.LinkToString(mAxis3); }
		internal IfcAxis2Placement3D generate()
		{
			if (LocalOrigin.isOrigin && (mAxis1 == 0 || Axis1.isXAxis) && (mAxis2 == 0 || Axis2.isYAxis))
				return mDatabase.Factory.PlaneXYPlacement;
			return new IfcAxis2Placement3D(LocalOrigin, mAxis3 == 0 ? mDatabase.Factory.ZAxis : Axis3, mAxis1 == 0 ? mDatabase.Factory.XAxis : Axis1);
		}
	}
	public partial class IfcCartesianTransformationOperator3DnonUniform : IfcCartesianTransformationOperator3D
	{
		private double mScale2 = 1;// : OPTIONAL REAL;
		private double mScale3 = 1;// : OPTIONAL REAL; 

		public double Scale2 { get { return mScale2; } set { mScale2 = value; } }
		public double Scale3 { get { return mScale3; } set { mScale3 = value; } }

		internal IfcCartesianTransformationOperator3DnonUniform() { }
		internal IfcCartesianTransformationOperator3DnonUniform(DatabaseIfc db, IfcCartesianTransformationOperator3DnonUniform o) : base(db,o) { mScale2 = o.mScale2; mScale3 = o.mScale3; }
		internal static IfcCartesianTransformationOperator3DnonUniform Parse(string str) { IfcCartesianTransformationOperator3DnonUniform o = new IfcCartesianTransformationOperator3DnonUniform(); int pos = 0; o.Parse(str, ref pos, str.Length); return o; }
		protected override void Parse(string str, ref int pos, int len)
		{
			base.Parse(str, ref pos, len);
			mScale2 = ParserSTEP.StripDouble(str, ref pos, len);
			mScale3 = ParserSTEP.StripDouble(str, ref pos, len);
		}

		protected override string BuildStringSTEP() { return base.BuildStringSTEP() + "," + ParserSTEP.DoubleOptionalToString(mScale2) + "," + ParserSTEP.DoubleOptionalToString(mScale3); }

	}
	public partial class IfcCenterLineProfileDef : IfcArbitraryOpenProfileDef
	{
		internal double mThickness;// : IfcPositiveLengthMeasure;
		public double Thickness { get { return mThickness; } set { mThickness = value; } }

		internal IfcCenterLineProfileDef() : base() { }
		internal IfcCenterLineProfileDef(DatabaseIfc db, IfcCenterLineProfileDef p) : base(db, p) { mThickness = p.mThickness; }
		public IfcCenterLineProfileDef(string name, IfcBoundedCurve curve, double thickness) : base(name, curve) { mThickness = thickness; }
		internal new static IfcCenterLineProfileDef Parse(string strDef) { IfcCenterLineProfileDef p = new IfcCenterLineProfileDef(); int ipos = 0; parseFields(p, ParserSTEP.SplitLineFields(strDef), ref ipos); return p; }
		internal static void parseFields(IfcCenterLineProfileDef p, List<string> arrFields, ref int ipos) { IfcArbitraryOpenProfileDef.parseFields(p, arrFields, ref ipos); p.mThickness = ParserSTEP.ParseDouble(arrFields[ipos++]); }
		protected override string BuildStringSTEP() { return base.BuildStringSTEP() + "," + ParserSTEP.DoubleToString(mThickness); }
	}
	public partial class IfcChamferEdgeFeature : IfcEdgeFeature //DEPRECEATED IFC4
	{
		internal double mWidth;// : OPTIONAL IfcPositiveLengthMeasure
		internal double mHeight;// : OPTIONAL IfcPositiveLengthMeasure;
		internal IfcChamferEdgeFeature() : base() { }
		internal IfcChamferEdgeFeature(DatabaseIfc db, IfcChamferEdgeFeature p) : base(db, p) { mWidth = p.mWidth; mHeight = p.mHeight; }
		internal static void parseFields(IfcChamferEdgeFeature f, List<string> arrFields, ref int ipos) { IfcEdgeFeature.parseFields(f, arrFields, ref ipos); f.mWidth = ParserSTEP.ParseDouble(arrFields[ipos++]); f.mHeight = ParserSTEP.ParseDouble(arrFields[ipos++]); }
		internal static IfcChamferEdgeFeature Parse(string strDef) { IfcChamferEdgeFeature f = new IfcChamferEdgeFeature(); int ipos = 0; parseFields(f, ParserSTEP.SplitLineFields(strDef), ref ipos); return f; }
		protected override string BuildStringSTEP() { return base.BuildStringSTEP() + "," + ParserSTEP.DoubleOptionalToString(mWidth) + "," + ParserSTEP.DoubleOptionalToString(mHeight); }
	}
	public partial class IfcChiller : IfcEnergyConversionDevice //IFC4
	{
		internal IfcChillerTypeEnum mPredefinedType = IfcChillerTypeEnum.NOTDEFINED;// OPTIONAL : IfctypeEnum;
		public IfcChillerTypeEnum PredefinedType { get { return mPredefinedType; } set { mPredefinedType = value; } }

		internal IfcChiller() : base() { }
		internal IfcChiller(DatabaseIfc db, IfcChiller c) : base(db, c) { mPredefinedType = c.mPredefinedType; }
		public IfcChiller(IfcObjectDefinition host, IfcObjectPlacement placement, IfcProductRepresentation representation, IfcDistributionSystem system) : base(host, placement, representation, system) { }

		internal static void parseFields(IfcChiller s, List<string> arrFields, ref int ipos)
		{
			IfcEnergyConversionDevice.parseFields(s, arrFields, ref ipos);
			string str = arrFields[ipos++];
			if (str[0] == '.')
				s.mPredefinedType = (IfcChillerTypeEnum)Enum.Parse(typeof(IfcChillerTypeEnum), str);
		}
		internal new static IfcBurner Parse(string strDef) { IfcBurner s = new IfcBurner(); int ipos = 0; parseFields(s, ParserSTEP.SplitLineFields(strDef), ref ipos); return s; }
		protected override string BuildStringSTEP()
		{
			return base.BuildStringSTEP() + (mDatabase.mRelease == ReleaseVersion.IFC2x3 ? "" : (mPredefinedType == IfcChillerTypeEnum.NOTDEFINED ? ",$" : ",." + mPredefinedType.ToString() + "."));
		}
	}
	public partial class IfcChillerType : IfcEnergyConversionDeviceType
	{
		internal IfcChillerTypeEnum mPredefinedType = IfcChillerTypeEnum.NOTDEFINED;// : IfcChillerTypeEnum
		public IfcChillerTypeEnum PredefinedType { get { return mPredefinedType; } set { mPredefinedType = value; } }

		internal IfcChillerType() : base() { }
		internal IfcChillerType(DatabaseIfc db, IfcChillerType t) : base(db, t) { mPredefinedType = t.mPredefinedType; }
		public IfcChillerType(DatabaseIfc db, string name, IfcChillerTypeEnum type) : base(db) { Name = name; mPredefinedType = type; }

		internal static void parseFields(IfcChillerType t, List<string> arrFields, ref int ipos) { IfcEnergyConversionDeviceType.parseFields(t, arrFields, ref ipos); t.mPredefinedType = (IfcChillerTypeEnum)Enum.Parse(typeof(IfcChillerTypeEnum), arrFields[ipos++].Replace(".", "")); }
		internal new static IfcChillerType Parse(string strDef) { IfcChillerType t = new IfcChillerType(); int ipos = 0; parseFields(t, ParserSTEP.SplitLineFields(strDef), ref ipos); return t; }
		protected override string BuildStringSTEP() { return base.BuildStringSTEP() + ",." + mPredefinedType.ToString() + "."; }
	}
	public partial class IfcChimney : IfcBuildingElement
	{
		internal IfcChimneyTypeEnum mPredefinedType = IfcChimneyTypeEnum.NOTDEFINED;//: OPTIONAL IfcChimneyTypeEnum; 
		public IfcChimneyTypeEnum PredefinedType { get { return mPredefinedType; } set { mPredefinedType = value; } }

		internal IfcChimney() : base() { }
		public IfcChimney(IfcObjectDefinition host, IfcObjectPlacement placement, IfcProductRepresentation representation) : base(host, placement, representation) { }
		internal IfcChimney(DatabaseIfc db, IfcChimney c) : base(db, c) { mPredefinedType = c.mPredefinedType; }
	
		internal static IfcChimney Parse(string strDef, ReleaseVersion schema) { IfcChimney w = new IfcChimney(); int ipos = 0; parseFields(w, ParserSTEP.SplitLineFields(strDef), ref ipos, schema); return w; }
		internal static void parseFields(IfcChimney w, List<string> arrFields, ref int ipos, ReleaseVersion schema)
		{
			IfcBuildingElement.parseFields(w, arrFields, ref ipos);
			if (schema != ReleaseVersion.IFC2x3)
			{
				string str = arrFields[ipos++];
				if (str[0] == '.')
					w.mPredefinedType = (IfcChimneyTypeEnum)Enum.Parse(typeof(IfcChimneyTypeEnum), str.Substring(1, str.Length - 2));
			}
		}
		protected override string BuildStringSTEP() { return base.BuildStringSTEP() + (mDatabase.mRelease == ReleaseVersion.IFC2x3 ? "" : (mPredefinedType == IfcChimneyTypeEnum.NOTDEFINED ? ",$" : ",." + mPredefinedType.ToString() + ".")); }
	}
	public partial class IfcChimneyType : IfcBuildingElementType
	{
		internal IfcChimneyTypeEnum mPredefinedType = IfcChimneyTypeEnum.NOTDEFINED;
		public IfcChimneyTypeEnum PredefinedType { get { return mPredefinedType; } set { mPredefinedType = value; } }

		internal IfcChimneyType() : base() { } 
		internal IfcChimneyType(DatabaseIfc db, IfcChimneyType t) : base(db,t) { mPredefinedType = t.mPredefinedType; }
		internal IfcChimneyType(DatabaseIfc m, string name, IfcChimneyTypeEnum type) : base(m) { Name = name; mPredefinedType = type; }
		internal static void parseFields(IfcChimneyType t, List<string> arrFields, ref int ipos) { IfcBuildingElementType.parseFields(t, arrFields, ref ipos); t.mPredefinedType = (IfcChimneyTypeEnum)Enum.Parse(typeof(IfcChimneyTypeEnum), arrFields[ipos++].Replace(".", "")); }
		internal new static IfcChimneyType Parse(string strDef) { IfcChimneyType t = new IfcChimneyType(); int ipos = 0; parseFields(t, ParserSTEP.SplitLineFields(strDef), ref ipos); return t; }
		protected override string BuildStringSTEP() { return base.BuildStringSTEP() + ",." + mPredefinedType.ToString() + "."; }
	}
	public partial class IfcCircle : IfcConic
	{
		private double mRadius;// : IfcPositiveLengthMeasure;
		public double Radius { get { return mRadius; } set { mRadius = value; } }

		public IfcCircle() : base() { }
        public IfcCircle(DatabaseIfc db, IfcCircle c) : base(db,c) { mRadius = c.mRadius; }
        public IfcCircle(DatabaseIfc db, double radius) : base(db.Factory.Origin2dPlace) { mRadius = radius; }
		public IfcCircle(IfcAxis2Placement ap, double radius) : base(ap) { mRadius = radius; }
		internal static IfcCircle Parse(string str) { IfcCircle c = new IfcCircle(); int pos = 0; c.Parse(str,ref pos, str.Length); return c; }
		internal override void Parse(string str, ref int pos, int len)
		{
			base.Parse(str, ref pos, len);
			mRadius = ParserSTEP.StripDouble(str, ref pos, len);
		}
		protected override string BuildStringSTEP() { return base.BuildStringSTEP() + "," + ParserSTEP.DoubleToString(Math.Round( mRadius,mDatabase.mLengthDigits)); }
	}
	public partial class IfcCircleHollowProfileDef : IfcCircleProfileDef
	{
		public override string KeyWord { get { return (mWallThickness < mDatabase.Tolerance ? "IfcCircleProfileDef" : base.KeyWord); } }

		internal double mWallThickness;// : IfcPositiveLengthMeasure;
		public double WallThickness { get { return mWallThickness; } set { mWallThickness = value; } }

		internal IfcCircleHollowProfileDef() : base() { }
		internal IfcCircleHollowProfileDef(DatabaseIfc db, IfcCircleHollowProfileDef c) : base(db, c) { mWallThickness = c.mWallThickness; }
		public IfcCircleHollowProfileDef(DatabaseIfc m, string name, double radius, double wallThickness) : base(m, name, radius) { mWallThickness = wallThickness; }
		internal static void parseFields(IfcCircleHollowProfileDef p, List<string> arrFields, ref int ipos) { IfcCircleProfileDef.parseFields(p, arrFields, ref ipos); p.mWallThickness = ParserSTEP.ParseDouble(arrFields[ipos++]); }
		internal new static IfcCircleHollowProfileDef Parse(string strDef) { IfcCircleHollowProfileDef p = new IfcCircleHollowProfileDef(); int ipos = 0; parseFields(p, ParserSTEP.SplitLineFields(strDef), ref ipos); return p; }
		protected override string BuildStringSTEP() { return base.BuildStringSTEP() + (mWallThickness < mDatabase.Tolerance ? "" : "," + ParserSTEP.DoubleToString(Math.Round(mWallThickness,mDatabase.mLengthDigits))); }
	}
	public partial class IfcCircleProfileDef : IfcParameterizedProfileDef //SUPERTYPE OF(IfcCircleHollowProfileDef)
	{
		internal double mRadius;// : IfcPositiveLengthMeasure;		
		public double Radius { get { return mRadius; } set { mRadius = value; } }
		internal IfcCircleProfileDef() : base() { }
		internal IfcCircleProfileDef(DatabaseIfc db, IfcCircleProfileDef c) : base(db, c) { mRadius = c.mRadius; }
		public IfcCircleProfileDef(DatabaseIfc db, string name, double radius) : base(db,name) { mRadius = radius; }
		internal static void parseFields(IfcCircleProfileDef p, List<string> arrFields, ref int ipos) { IfcParameterizedProfileDef.parseFields(p, arrFields, ref ipos); p.mRadius = ParserSTEP.ParseDouble(arrFields[ipos++]); }
		protected override string BuildStringSTEP() { return base.BuildStringSTEP() + "," + ParserSTEP.DoubleToString(Math.Round( mRadius,mDatabase.mLengthDigits)); }
		internal new static IfcCircleProfileDef Parse(string strDef) { IfcCircleProfileDef p = new IfcCircleProfileDef(); int ipos = 0; parseFields(p, ParserSTEP.SplitLineFields(strDef), ref ipos); return p; }
	}
	public partial class IfcCivilElement : IfcElement  //IFC4
	{
		internal IfcCivilElement() : base() { }
		internal IfcCivilElement(DatabaseIfc db, IfcCivilElement e) : base(db,e,false) { }
		public IfcCivilElement(IfcObjectDefinition host, IfcObjectPlacement placement, IfcProductRepresentation representation) : base(host, placement, representation) { if (mDatabase.mRelease == ReleaseVersion.IFC2x3) throw new Exception(KeyWord + " only supported in IFC4!"); }
		internal static IfcCivilElement Parse(string strDef) { IfcCivilElement e = new IfcCivilElement(); int ipos = 0; parseFields(e, ParserSTEP.SplitLineFields(strDef), ref ipos); return e; }
		internal static void parseFields(IfcCivilElement e, List<string> arrFields, ref int ipos) { IfcElement.parseFields(e, arrFields, ref ipos); }
	}
	public abstract partial class IfcCivilElementPart : IfcElementComponent //	ABSTRACT SUPERTYPE OF(ONEOF(IfcBridgeSegmentPart , IfcBridgeContactElement , IfcCivilSheath , IfcCivilVoid))
	{
		// INVERSE
		//ContainedInSegment : IfcBridgeSegment FOR SegmentParts;
		protected IfcCivilElementPart() : base() { }
		protected IfcCivilElementPart(DatabaseIfc db, IfcCivilElementPart e) : base(db, e) { }
		protected IfcCivilElementPart(IfcObjectDefinition host, IfcObjectPlacement placement, IfcProductRepresentation representation) : base(host, placement, representation) { }
		protected static void parseFields(IfcCivilElementPart e, List<string> arrFields, ref int ipos)
		{
			IfcElementComponent.parseFields(e, arrFields, ref ipos);
		}
	}
	public partial class IfcCivilElementType : IfcElementType //IFC4
	{
		internal IfcCivilElementType() : base() { }
		internal IfcCivilElementType(DatabaseIfc db, IfcCivilElementType t) : base(db, t) { }
		internal IfcCivilElementType(DatabaseIfc m, string name) : base(m) { Name = name; if (m.mRelease == ReleaseVersion.IFC2x3) throw new Exception(KeyWord + " only supported in IFC4!"); }
		internal new static IfcCivilElementType Parse(string strDef) { IfcCivilElementType t = new IfcCivilElementType(); int ipos = 0; parseFields(t, ParserSTEP.SplitLineFields(strDef), ref ipos); return t; }
		internal static void parseFields(IfcCivilElementType t, List<string> arrFields, ref int ipos) { IfcElementType.parseFields(t, arrFields, ref ipos); }
	}
	public partial class IfcCivilSheath : IfcCivilElementPart //IFC5
	{
		internal IfcCivilSheath() : base() { }
		internal IfcCivilSheath(DatabaseIfc db, IfcCivilSheath s) : base(db, s) { }
		public IfcCivilSheath(IfcObjectDefinition host, IfcObjectPlacement placement, IfcProductRepresentation representation) : base(host, placement, representation) { }
		internal static IfcCivilSheath Parse(string strDef) { IfcCivilSheath p = new IfcCivilSheath(); int ipos = 0; parseFields(p, ParserSTEP.SplitLineFields(strDef), ref ipos); return p; }
		internal static void parseFields(IfcCivilSheath a, List<string> arrFields, ref int ipos)
		{
			IfcCivilElementPart.parseFields(a, arrFields, ref ipos);
		}
	}
	public abstract partial class IfcCivilStructureElement : IfcSpatialStructureElement //IFC5
	{
		protected IfcCivilStructureElement() : base() { }
		protected IfcCivilStructureElement(IfcSpatialStructureElement host, string name) : base(host, name) { }
		protected IfcCivilStructureElement(DatabaseIfc db, IfcCivilStructureElement p, bool downStream) : base(db, p,downStream) { }
	}
	public partial class IfcCivilVoid : IfcCivilElementPart //IFC5
	{
		internal IfcCivilVoid() : base() { }
		internal IfcCivilVoid(DatabaseIfc db, IfcCivilVoid v) : base(db, v) { }
		public IfcCivilVoid(IfcObjectDefinition host, IfcObjectPlacement placement, IfcProductRepresentation representation) : base(host, placement, representation) { }
		internal static IfcCivilVoid Parse(string strDef) { IfcCivilVoid p = new IfcCivilVoid(); int ipos = 0; parseFields(p, ParserSTEP.SplitLineFields(strDef), ref ipos); return p; }
		internal static void parseFields(IfcCivilVoid a, List<string> arrFields, ref int ipos)
		{
			IfcCivilElementPart.parseFields(a, arrFields, ref ipos);
		}
	}
	public partial class IfcClassification : IfcExternalInformation, IfcClassificationReferenceSelect, IfcClassificationSelect //	SUBTYPE OF IfcExternalInformation;
	{
		internal string mSource = "$";//  : OPTIONAL IfcLabel;
		internal string mEdition = "$";//  : OPTIONAL IfcLabel;
		internal string mEditionDate = "$";// OPTIONAL IfcDate IFC4 change : OPTIONAL IfcCalendarDate;
		internal string mName;//  : IfcLabel;
		internal string mDescription = "$";//	 :	OPTIONAL IfcText; IFC4 Addition
		internal string mLocation = "$";//	 :	OPTIONAL IfcURIReference; IFC4 Addtion
		internal List<string> mReferenceTokens = new List<string>();//	 :	OPTIONAL LIST [1:?] OF IfcIdentifier; IFC4 Addition
		//INVERSE 
		internal List<IfcRelAssociatesClassification> mClassificationForObjects = new List<IfcRelAssociatesClassification>();//	 :	SET OF IfcRelAssociatesclassification FOR Relatingclassification;
		internal List<IfcClassificationReference> mHasReferences = new List<IfcClassificationReference>();//	 :	SET OF IfcClassificationReference FOR ReferencedSource;

		public override string Name { get { return (mName == "$" ? "" : ParserIfc.Decode(mName)); } set { if (!string.IsNullOrEmpty(value)) mName = ParserIfc.Encode(value); } }
		public List<IfcRelAssociatesClassification> ClassificationForObjects { get { return mClassificationForObjects; } }
		public List<IfcClassificationReference> HasReferences { get { return mHasReferences; } }

		internal IfcClassification() : base() { }
		internal IfcClassification(DatabaseIfc db, IfcClassification c) : base(db, c) { mSource = c.mSource; mEdition = c.mEdition; mEditionDate = c.mEditionDate; mName = c.mName; }
		internal IfcClassification(DatabaseIfc m, string source, string edition, DateTime editionDate, string name, string desc, string location, List<string> references)
			: base(m)
		{
			if (!string.IsNullOrEmpty(source))
				mSource = source.Replace("'", "");
			if (!string.IsNullOrEmpty(edition))
				mEdition = edition.Replace("'", "");
			if (editionDate != DateTime.MinValue)
				mEditionDate = IfcDate.convert(editionDate);
			Name = name;
			if (!string.IsNullOrEmpty(desc))
				mDescription = desc.Replace("'", "");
			if (!string.IsNullOrEmpty(location))
				mLocation = location.Replace("'", "");
			if (references != null)
				mReferenceTokens = references.ConvertAll(x => x.Replace("'", ""));
			mClassificationForObjects.Add(new IfcRelAssociatesClassification(this));
		}
		internal static IfcClassification Parse(string strDef, ReleaseVersion schema) { IfcClassification c = new IfcClassification(); int ipos = 0; parseFields(c, ParserSTEP.SplitLineFields(strDef), ref ipos, schema); return c; }
		internal static void parseFields(IfcClassification c, List<string> arrFields, ref int ipos, ReleaseVersion schema)
		{
			IfcExternalInformation.parseFields(c, arrFields, ref ipos);
			c.mSource = arrFields[ipos++].Replace("'", "");
			c.mEdition = arrFields[ipos++].Replace("'", "");
			c.mEditionDate = arrFields[ipos++].Replace("'", "");
			c.mName = arrFields[ipos++].Replace("'", "");
			if (schema != ReleaseVersion.IFC2x3)
			{
				c.mDescription = arrFields[ipos++].Replace("'", "");
				c.mLocation = arrFields[ipos++].Replace("'", "");
				c.mReferenceTokens = ParserSTEP.SplitListStrings(arrFields[ipos++]);
			}
		}
		protected override string BuildStringSTEP()
		{
			string tokens = "$";
			if (mReferenceTokens.Count > 0)
			{
				tokens = "('" + mReferenceTokens;
				for (int icounter = 1; icounter < mReferenceTokens.Count; icounter++)
					tokens += "','" + mReferenceTokens;
				tokens += "')";
			}
			return base.BuildStringSTEP() + (mSource == "$" ? (mDatabase.mRelease == ReleaseVersion.IFC2x3 ? ",'Unknown'," : ",$,") : ",'" + mSource + "',") + (mEdition == "$" ? (mDatabase.mRelease == ReleaseVersion.IFC2x3 ? "'Unknown'," : "$,") : "'" + mEdition + "',") + (mDatabase.mRelease == ReleaseVersion.IFC2x3 ? mEditionDate : (mEdition == "$" ? "$" : "'" + mEditionDate + "'")) +
				",'" + mName + (mDatabase.mRelease == ReleaseVersion.IFC2x3 ? "'" : (mDescription == "$" ? "',$," : "','" + mDescription + "',") + (mLocation == "$" ? "$," : "'" + mLocation + "',") + tokens);
		}
	}
	public partial class IfcClassificationItem : BaseClassIfc //DEPRECEATED IFC4
	{
		internal int mNotation;// : IfcClassificationNotationFacet;
		internal int mItemOf;//: OPTIONAL IfcClassification;
		internal string mTitle;// : IfcLabel; 

		internal IfcClassificationItem() : base() { }
		//internal IfcClassificationItem( IfcClassificationItem i) : base() { mNotation = i.mNotation; mItemOf = i.mItemOf; mTitle = i.mTitle; }
		internal static IfcClassificationItem Parse(string strDef) { IfcClassificationItem c = new IfcClassificationItem(); int ipos = 0; parseFields(c, ParserSTEP.SplitLineFields(strDef), ref ipos); return c; }
		internal static void parseFields(IfcClassificationItem c, List<string> arrFields, ref int ipos) { c.mNotation = ParserSTEP.ParseLink(arrFields[ipos++]); c.mItemOf = ParserSTEP.ParseLink(arrFields[ipos++]); c.mTitle = arrFields[ipos++]; }
		protected override string BuildStringSTEP() { return base.BuildStringSTEP() + "," + ParserSTEP.LinkToString(mNotation) + "," + ParserSTEP.LinkToString(mItemOf) + "," + mTitle; }
	}
	public partial class IfcClassificationItemRelationship : BaseClassIfc //DEPRECEATED IFC4
	{
		internal string mSource;// : IfcLabel;
		internal string mEdition;// : IfcLabel;
		internal int mEditionDate;// : OPTIONAL IfcCalendarDate;
		internal string mName;// : IfcLabel;
		internal IfcClassificationItemRelationship() : base() { }
		//internal IfcClassificationItemRelationship(IfcClassificationItemRelationship i) : base()
		//{
		//	mSource = i.mSource;
		//	mEdition = i.mEdition;
		//	mEditionDate = i.mEditionDate;
		//	mName = i.mName;
		//}
		internal static IfcClassificationItemRelationship Parse(string strDef) { IfcClassificationItemRelationship c = new IfcClassificationItemRelationship(); int ipos = 0; parseFields(c, ParserSTEP.SplitLineFields(strDef), ref ipos); return c; }
		internal static void parseFields(IfcClassificationItemRelationship c, List<string> arrFields, ref int ipos) { c.mSource = arrFields[ipos++]; c.mEdition = arrFields[ipos++]; c.mEditionDate = ParserSTEP.ParseLink(arrFields[ipos++]); c.mName = arrFields[ipos++]; }
		protected override string BuildStringSTEP() { return base.BuildStringSTEP() + "," + mSource + "," + mEdition + "," + ParserSTEP.LinkToString(mEditionDate) + "," + mName; }
	}
	public partial class IfcClassificationNotation : BaseClassIfc, IfcClassificationNotationSelect //DEPRECEATED IFC4
	{
		internal List<int> mNotationFacets = new List<int>();// : SET [1:?] OF IfcClassificationNotationFacet;

		internal IfcClassificationNotation() : base() { }
		//internal IfcClassificationNotation(IfcClassificationNotation i) : base() { mNotationFacets = new List<int>(i.mNotationFacets.ToArray()); }
		internal static IfcClassificationNotation Parse(string strDef) { IfcClassificationNotation c = new IfcClassificationNotation(); int ipos = 0; parseFields(c, ParserSTEP.SplitLineFields(strDef), ref ipos); return c; }
		internal static void parseFields(IfcClassificationNotation c, List<string> arrFields, ref int ipos) { c.mNotationFacets = ParserSTEP.SplitListLinks(arrFields[ipos++]); }
		protected override string BuildStringSTEP()
		{
			string str = base.BuildStringSTEP() + ",(";
			if (mNotationFacets.Count > 0)
			{
				str += ParserSTEP.LinkToString(mNotationFacets[0]);
				for (int icounter = 1; icounter < mNotationFacets.Count; icounter++)
					str += "," + ParserSTEP.LinkToString(mNotationFacets[icounter]);
			}
			return str + ")";
		}
	}
	public partial class IfcClassificationNotationFacet : BaseClassIfc  //DEPRECEATED IFC4
	{
		internal string mNotationValue;//  : IfcLabel;
		internal IfcClassificationNotationFacet() : base() { }
	//	internal IfcClassificationNotationFacet(IfcClassification i) : base() { mNotationValue = i.mSource; }
		internal static IfcClassificationNotationFacet Parse(string strDef) { IfcClassificationNotationFacet c = new IfcClassificationNotationFacet(); int ipos = 0; parseFields(c, ParserSTEP.SplitLineFields(strDef), ref ipos); return c; }
		internal static void parseFields(IfcClassificationNotationFacet c, List<string> arrFields, ref int ipos) { c.mNotationValue = arrFields[ipos++]; }
		protected override string BuildStringSTEP() { return base.BuildStringSTEP() + "," + mNotationValue; }
	}
	public interface IfcClassificationNotationSelect : IBaseClassIfc { } // List<IfcRelAssociatesclassification> classificationForObjects { get; } 	IfcClassificationNotation, IfcClassificationReference) 
	public partial class IfcClassificationReference : IfcExternalReference, IfcClassificationReferenceSelect, IfcClassificationSelect, IfcClassificationNotationSelect
	{
		internal int mReferencedSource;// : OPTIONAL IfcClassificationReferenceSelect; //IFC2x3 : 	OPTIONAL IfcClassification;
		internal string mDescription = "$";// :	OPTIONAL IfcText; IFC4
		internal string mSort = "$";//	 :	OPTIONAL IfcIdentifier;
		//INVERSE 
		internal List<IfcRelAssociatesClassification> mClassificationRefForObjects = new List<IfcRelAssociatesClassification>();//	 :	SET [0:?] OF IfcRelAssociatesclassification FOR Relatingclassification;
		internal List<IfcClassificationReference> mHasReferences = new List<IfcClassificationReference>();//	 :	SET [0:?] OF IfcClassificationReference FOR ReferencedSource;
		public List<IfcRelAssociatesClassification> ClassificationForObjects { get { return mClassificationRefForObjects; } }

		public IfcClassificationReferenceSelect ReferencedSource { get { return mDatabase[mReferencedSource] as IfcClassificationReferenceSelect; } set { mReferencedSource = (value == null ? 0 : value.Index); } }
		public List<IfcClassificationReference> HasReferences { get { return mHasReferences; } }

		internal IfcClassificationReference() : base() { }
		internal IfcClassificationReference(DatabaseIfc db) : base(db) {  }
		internal IfcClassificationReference(DatabaseIfc db, IfcClassificationReference r) : base(db,r)
		{
#warning todo
			ReferencedSource = db.Factory.Duplicate(r.mDatabase[ r.mReferencedSource]) as IfcClassificationReferenceSelect;
			mDescription = r.mDescription;
			mSort = r.mSort;
		}
		internal static IfcClassificationReference Parse(string strDef, ReleaseVersion schema) { IfcClassificationReference r = new IfcClassificationReference(); int ipos = 0; parseFields(r, ParserSTEP.SplitLineFields(strDef), ref ipos,schema); return r; }
		internal static void parseFields(IfcClassificationReference r, List<string> arrFields, ref int ipos, ReleaseVersion schema)
		{
			IfcExternalReference.parseFields(r, arrFields, ref ipos);
			r.mReferencedSource = ParserSTEP.ParseLink(arrFields[ipos++]);
			if (schema != ReleaseVersion.IFC2x3)
			{
				r.mDescription = arrFields[ipos++].Replace("'", "");
				r.mSort = arrFields[ipos++].Replace("'", "");
			}
		}
		protected override string BuildStringSTEP() { return base.BuildStringSTEP() + "," + ParserSTEP.LinkToString(mReferencedSource) + (mDatabase.mRelease == ReleaseVersion.IFC2x3 ? "" : (mDescription == "$" ? ",$" : ",'" + mDescription + "'") + (mSort == "$" ? ",$" : ",'" + mSort + "'")); }
		internal override void postParseRelate()
		{
			base.postParseRelate();
			if(mReferencedSource > 0)
				ReferencedSource.HasReferences.Add(this);
		}
	}
	public interface IfcClassificationReferenceSelect : IBaseClassIfc { List<IfcClassificationReference> HasReferences { get; } } // SELECT ( IfcClassificationReference, IfcClassification);
	public interface IfcClassificationSelect : IBaseClassIfc { List<IfcRelAssociatesClassification> ClassificationForObjects { get; } } // IFC4 rename IfcClassification,IfcClassificationReference 
	public partial class IfcClosedShell : IfcConnectedFaceSet, IfcShell
	{
		internal IfcClosedShell() : base() { }
		public IfcClosedShell(List<IfcFace> faces) : base(faces) { }
		internal IfcClosedShell(DatabaseIfc db, IfcClosedShell c) : base(db,c) { }
		internal new static IfcClosedShell Parse(string str) 
		{ 
			IfcClosedShell s = new IfcClosedShell(); 
			s.parse(str);
			return s; 
		}
	}
	public partial class IfcCoil : IfcEnergyConversionDevice //IFC4
	{
		internal IfcCoilTypeEnum mPredefinedType = IfcCoilTypeEnum.NOTDEFINED;// OPTIONAL : IfcCoilTypeEnum;
		public IfcCoilTypeEnum PredefinedType { get { return mPredefinedType; } set { mPredefinedType = value; } }

		internal IfcCoil() : base() { }
		internal IfcCoil(DatabaseIfc db, IfcCoil c) : base(db, c) { mPredefinedType = c.mPredefinedType; }
		public IfcCoil(IfcObjectDefinition host, IfcObjectPlacement placement, IfcProductRepresentation representation, IfcDistributionSystem system) : base(host, placement, representation, system) { }

		internal static void parseFields(IfcCoil s, List<string> arrFields, ref int ipos)
		{
			IfcEnergyConversionDevice.parseFields(s, arrFields, ref ipos);
			string str = arrFields[ipos++];
			if (str[0] == '.')
				s.mPredefinedType = (IfcCoilTypeEnum)Enum.Parse(typeof(IfcCoilTypeEnum), str);
		}
		internal new static IfcCoil Parse(string strDef) { IfcCoil s = new IfcCoil(); int ipos = 0; parseFields(s, ParserSTEP.SplitLineFields(strDef), ref ipos); return s; }
		protected override string BuildStringSTEP()
		{
			return base.BuildStringSTEP() + (mDatabase.mRelease == ReleaseVersion.IFC2x3 ? "" : (mPredefinedType == IfcCoilTypeEnum.NOTDEFINED ? ",$" : ",." + mPredefinedType.ToString() + "."));
		}
	}
	public partial class IfcCoilType : IfcEnergyConversionDeviceType
	{
		internal IfcCoilTypeEnum mPredefinedType = IfcCoilTypeEnum.NOTDEFINED;// : IfcCoilTypeEnum;
		public IfcCoilTypeEnum PredefinedType { get { return mPredefinedType; } set { mPredefinedType = value; } }

		internal IfcCoilType() : base() { }
		internal IfcCoilType(DatabaseIfc db, IfcCoilType t) : base(db, t) { mPredefinedType = t.mPredefinedType; }
		internal IfcCoilType(DatabaseIfc m, string name, IfcCoilTypeEnum t) : base(m) { Name = name; PredefinedType = t; }
		internal static void parseFields(IfcCoilType t,List<string> arrFields, ref int ipos) {  IfcEnergyConversionDeviceType.parseFields(t,arrFields, ref ipos); t.mPredefinedType = (IfcCoilTypeEnum)Enum.Parse(typeof(IfcCoilTypeEnum), arrFields[ipos++].Replace(".", "")); }
		internal new static IfcCoilType Parse(string strDef) { IfcCoilType t = new IfcCoilType(); int ipos = 0; parseFields(t, ParserSTEP.SplitLineFields(strDef), ref ipos); return t; }
		protected override string BuildStringSTEP() { return base.BuildStringSTEP() + ",." + mPredefinedType.ToString() + "."; }
	}
	public partial interface IfcColour : IBaseClassIfc { }// = SELECT (IfcColourSpecification ,IfcPreDefinedColour); 
	public interface IfcColourOrFactor { } // IfcNormalisedRatioMeasure, IfcColourRgb);
	public partial class IfcColourRgb : IfcColourSpecification, IfcColourOrFactor
	{
		internal double mRed, mGreen, mBlue;// : IfcNormalisedRatioMeasure; 
		
		internal IfcColourRgb() : base() { }
		internal IfcColourRgb(DatabaseIfc db, IfcColourRgb c) : base(db, c) { mRed = c.mRed; mGreen = c.mGreen; mBlue = c.mBlue; }
		public IfcColourRgb(DatabaseIfc db, double red, double green, double blue) : base(db) { mRed = red; mGreen = green; mBlue = blue; }		
		internal static IfcColourRgb Parse(string strDef) { IfcColourRgb c = new IfcColourRgb(); int ipos = 0; parseFields(c, ParserSTEP.SplitLineFields(strDef), ref ipos); return c; }
		internal static void parseFields(IfcColourRgb c, List<string> arrFields, ref int ipos) { IfcColourSpecification.parseFields(c, arrFields, ref ipos); c.mRed = ParserSTEP.ParseDouble(arrFields[ipos++]); c.mGreen = ParserSTEP.ParseDouble(arrFields[ipos++]); c.mBlue = ParserSTEP.ParseDouble(arrFields[ipos++]); }
		protected override string BuildStringSTEP() { return base.BuildStringSTEP() + "," + ParserSTEP.DoubleToString(mRed) + "," + ParserSTEP.DoubleToString(mGreen) + "," + ParserSTEP.DoubleToString(mBlue); }
	}
	public partial class IfcColourRgbList : IfcPresentationItem
	{
		internal Tuple<double, double, double>[] mColourList = new Tuple<double, double, double>[0];//	: LIST [1:?] OF LIST [3:3] OF IfcNormalisedRatioMeasure; 
		internal IfcColourRgbList() : base() { }
		internal IfcColourRgbList(DatabaseIfc db,IfcColourRgbList l) : base(db,l) { mColourList = l.mColourList; }
		
		internal static void parseFields(IfcColourRgbList s, List<string> arrFields, ref int ipos) { s.mColourList = ParserSTEP.SplitListDoubleTriple(arrFields[ipos++]); }
		internal static IfcColourRgbList Parse(string strDef) { IfcColourRgbList s = new IfcColourRgbList(); int ipos = 0; parseFields(s, ParserSTEP.SplitLineFields(strDef), ref ipos); return s; }
		protected override string BuildStringSTEP()
		{
			Tuple<double, double, double> t = mColourList[0];
			string result = base.BuildStringSTEP() + ",((" + ParserSTEP.DoubleToString(t.Item1) + "," + ParserSTEP.DoubleToString(t.Item2) + "," + ParserSTEP.DoubleToString(t.Item3);
			for (int icounter = 1; icounter < mColourList.Length; icounter++)
			{
				t = mColourList[icounter];
				result += "),(" + ParserSTEP.DoubleToString(t.Item1) + "," + ParserSTEP.DoubleToString(t.Item2) + "," + ParserSTEP.DoubleToString(t.Item3);
			}

			return result + "))";
		}
		
	}
	public abstract partial class IfcColourSpecification : IfcPresentationItem, IfcColour //	ABSTRACT SUPERTYPE OF(IfcColourRgb)
	{
		private string mName = "$";// : OPTIONAL IfcLabel
		public override string Name { get { return (mName == "$" ? "" : ParserIfc.Decode(mName)); } set { if (!string.IsNullOrEmpty(value)) mName = ParserIfc.Encode(value); } }

		protected IfcColourSpecification() : base() { }
		protected IfcColourSpecification(DatabaseIfc db, IfcColourSpecification s) : base(db, s) { mName = s.mName; }
		protected IfcColourSpecification(DatabaseIfc db) : base(db) { }
		protected static void parseFields(IfcColourSpecification c, List<string> arrFields, ref int ipos) { c.mName = arrFields[ipos++].Replace("'", ""); }
		protected override string BuildStringSTEP() { return base.BuildStringSTEP() + (mName == "$" ? ",$" : ",'" + mName + "'"); }
	}
	public partial class IfcColumn : IfcBuildingElement
	{
		internal IfcColumnTypeEnum mPredefinedType = IfcColumnTypeEnum.NOTDEFINED;//: OPTIONAL IfcColumnTypeEnum; 
		public IfcColumnTypeEnum PredefinedType { get { return mPredefinedType; } set { mPredefinedType = value; } }
		
		internal IfcColumn() : base()  { }
		internal IfcColumn(DatabaseIfc db, IfcColumn c) : base(db, c) { mPredefinedType = c.mPredefinedType; }
		public IfcColumn(IfcObjectDefinition host, IfcObjectPlacement placement, IfcProductRepresentation representation) : base(host, placement, representation) { }
		protected IfcColumn(IfcProduct host, IfcMaterialProfileSetUsage profile, IfcAxis2Placement3D placement, double length) : base(host, profile, placement,length) { }
	 
		internal static IfcColumn Parse(string str, ReleaseVersion schema) { IfcColumn c = new IfcColumn(); int pos = 0; c.Parse(str,ref pos, str.Length,schema); return c; }
		protected void Parse(string str, ref int pos, int len, ReleaseVersion schema)
		{
			base.Parse(str, ref pos, len);
			if (schema != ReleaseVersion.IFC2x3)
			{
				string s = ParserSTEP.StripField(str, ref pos, len);
				if (s[0] == '.')
					mPredefinedType = (IfcColumnTypeEnum)Enum.Parse(typeof(IfcColumnTypeEnum), s.Substring(1, s.Length - 2));
			}
		}
		protected override string BuildStringSTEP() { return base.BuildStringSTEP() + (mDatabase.mRelease == ReleaseVersion.IFC2x3 ? "" : (mPredefinedType == IfcColumnTypeEnum.NOTDEFINED ? ",$" : ",." + mPredefinedType.ToString() + ".")); }
	}
	public partial class IfcColumnStandardCase : IfcColumn
	{
		public override string KeyWord { get { return (mDatabase.mRelease == ReleaseVersion.IFC2x3 || mDatabase.mModelView == ModelView.Ifc4Reference ? "IfcColumn" : base.KeyWord); } }
		internal IfcColumnStandardCase() : base() { }
		internal IfcColumnStandardCase(DatabaseIfc db, IfcColumnStandardCase c) : base(db, c) { }
		public IfcColumnStandardCase(IfcProduct host, IfcMaterialProfileSetUsage profile, IfcAxis2Placement3D placement, double length) : base(host, profile, placement,length) { }

		internal new static IfcColumnStandardCase Parse(string str, ReleaseVersion schema) { IfcColumnStandardCase c = new IfcColumnStandardCase(); int pos = 0; c.Parse(str,ref pos, str.Length,schema); return c; }
	} 
	public partial class IfcColumnType : IfcBuildingElementType
	{
		internal IfcColumnTypeEnum mPredefinedType = IfcColumnTypeEnum.NOTDEFINED;
		public IfcColumnTypeEnum PredefinedType { get { return mPredefinedType; } set { mPredefinedType = value; } }

		public IfcColumnType() : base() { }
        public IfcColumnType(DatabaseIfc db, IfcColumnType t) : base(db,t) { mPredefinedType = t.mPredefinedType; }
		public IfcColumnType(DatabaseIfc m, string name, IfcColumnTypeEnum type) : base(m) { Name = name; mPredefinedType = type; }
		public IfcColumnType(string name, IfcMaterialProfile ps, IfcColumnTypeEnum type) : this(name,new IfcMaterialProfileSet(ps.Name, ps), type) { }
        public IfcColumnType(string name, IfcMaterialProfileSet ps, IfcColumnTypeEnum type) : base(ps.mDatabase)
		{
			Name = name;
			mPredefinedType = type;
			if (ps.mTaperEnd != null)
				mTapering = ps;
			else
				MaterialSelect = ps;
		}
		internal static void parseFields(IfcColumnType t, List<string> arrFields, ref int ipos) { IfcBuildingElementType.parseFields(t,arrFields, ref ipos); t.mPredefinedType = (IfcColumnTypeEnum)Enum.Parse(typeof(IfcColumnTypeEnum), arrFields[ipos++].Replace(".", ""));  }
		internal new static IfcColumnType Parse(string strDef) { IfcColumnType t = new IfcColumnType(); int ipos = 0; parseFields(t, ParserSTEP.SplitLineFields(strDef), ref ipos); return t; }
		protected override string BuildStringSTEP() { return base.BuildStringSTEP() + ",." + mPredefinedType.ToString() + "."; }

	}
	public partial class IfcComplexProperty : IfcProperty
	{
		internal string mUsageName;// : IfcIdentifier;
		internal List<int> mHasProperties = new List<int>();// : SET [1:?] OF IfcProperty;

		public List<IfcProperty> HasProperties { get { return mHasProperties.ConvertAll(x => mDatabase[x] as IfcProperty); } set { mHasProperties = value.ConvertAll(x => x.mIndex); } }

		internal IfcComplexProperty() : base() { }
		internal IfcComplexProperty(DatabaseIfc db, IfcComplexProperty p) : base(db, p) { mUsageName = p.mUsageName; HasProperties = p.HasProperties.ConvertAll(x => db.Factory.Duplicate(x) as IfcProperty); }
		internal IfcComplexProperty(DatabaseIfc m, string name, string desc, List<IfcProperty> props) : base(m, name, desc) { }
		internal static void parseFields(IfcComplexProperty p, List<string> arrFields, ref int ipos) { IfcProperty.parseFields(p, arrFields, ref ipos); p.mUsageName = arrFields[ipos++]; p.mHasProperties = ParserSTEP.SplitListLinks(arrFields[ipos++]); }
		internal static IfcComplexProperty Parse(string strDef) { IfcComplexProperty p = new IfcComplexProperty(); int ipos = 0; parseFields(p, ParserSTEP.SplitLineFields(strDef), ref ipos); return p; }
		protected override string BuildStringSTEP()
		{
			string str = base.BuildStringSTEP() + "," + mUsageName + ",(" + ParserSTEP.LinkToString(mHasProperties[0]);
			for (int icounter = 1; icounter < mHasProperties.Count; icounter++)
				str += "," + ParserSTEP.LinkToString(mHasProperties[icounter]);
			return str + ")";
		}
		internal override void postParseRelate()
		{
			base.postParseRelate();
			List<IfcProperty> props = HasProperties;
			for (int icounter = 0; icounter < props.Count; icounter++)
				props[icounter].mPartOfComplex.Add(this);
		}
	}
	//IfcComplexPropertyTemplate
	public partial class IfcCompositeCurve : IfcBoundedCurve
	{
		private List<int> mSegments = new List<int>();// : LIST [1:?] OF IfcCompositeCurveSegment;
		private IfcLogicalEnum mSelfIntersect = IfcLogicalEnum.UNKNOWN;// : LOGICAL;

		public List<IfcCompositeCurveSegment> Segments { get { return mSegments.ConvertAll(x => mDatabase[x] as IfcCompositeCurveSegment); } set { mSegments = value.ConvertAll(x => x.mIndex); } }
		public IfcLogicalEnum SelfIntersect { get { return mSelfIntersect; } }

		internal IfcCompositeCurve() : base() { }
		internal IfcCompositeCurve(DatabaseIfc db, IfcCompositeCurve c) : base(db,c) { Segments = c.Segments.ConvertAll(x=>db.Factory.Duplicate(x) as IfcCompositeCurveSegment); mSelfIntersect = c.mSelfIntersect; }
		public IfcCompositeCurve(List<IfcCompositeCurveSegment> segs) : base(segs[0].mDatabase) { mSegments = segs.ConvertAll(x => x.mIndex); }
		internal static IfcCompositeCurve Parse(string str) { IfcCompositeCurve c = new IfcCompositeCurve(); int pos = 0; c.Parse(str, ref pos, str.Length); return c; }
		protected virtual void Parse(string str,ref int pos,int len)
		{
			mSegments = ParserSTEP.StripListLink(str, ref pos, len);
			mSelfIntersect = ParserIfc.StripLogical(str, ref pos, len);
		}
		protected override string BuildStringSTEP()
		{
			string str = base.BuildStringSTEP() + ",(";
			if (mSegments.Count > 0)
				str += ParserSTEP.LinkToString(mSegments[0]);
			for (int icounter = 1; icounter < mSegments.Count; icounter++)
				str += "," + ParserSTEP.LinkToString(mSegments[icounter]);
			str += "),";
			str += ParserIfc.LogicalToString(mSelfIntersect);
			return base.BuildStringSTEP() + str;
		}
	}
	public partial class Ifc2dCompositeCurve : IfcCompositeCurve
	{
		internal Ifc2dCompositeCurve() : base() { }
		internal Ifc2dCompositeCurve(DatabaseIfc db, Ifc2dCompositeCurve c) : base(db,c) { }
		internal new static IfcCompositeCurve Parse(string str) { Ifc2dCompositeCurve c = new Ifc2dCompositeCurve(); int pos = 0; c.Parse(str, ref pos, str.Length); return c; }
	}
	public partial class IfcCompositeCurveOnSurface : IfcCompositeCurve
	{
		internal int mBasisSurface;// : IfcSurface;
		public IfcSurface BasisSurface { get { return mDatabase[mBasisSurface] as IfcSurface; } set { mBasisSurface = value.mIndex; } }

		internal IfcCompositeCurveOnSurface() : base() { }
		internal IfcCompositeCurveOnSurface(DatabaseIfc db, IfcCompositeCurveOnSurface c) : base(db,c) { BasisSurface = db.Factory.Duplicate(c.BasisSurface) as IfcSurface; }
		internal IfcCompositeCurveOnSurface(List<IfcCompositeCurveSegment> segs,IfcSurface surface) : base(segs) { BasisSurface = surface; }
		internal new static IfcCompositeCurveOnSurface Parse(string str) { IfcCompositeCurveOnSurface c = new IfcCompositeCurveOnSurface(); int pos = 0; c.Parse(str, ref pos, str.Length); return c; }
		protected override void Parse(string str, ref int pos, int len)
		{
			base.Parse(str, ref pos, len);
			mBasisSurface = ParserSTEP.StripLink(str, ref pos, len);
		}
		protected override string BuildStringSTEP() { return base.BuildStringSTEP() + ",#" + mBasisSurface; }
	}
	public partial class IfcCompositeCurveSegment : IfcGeometricRepresentationItem
	{
		private IfcTransitionCode mTransition;// : IfcTransitionCode;
		private bool mSameSense;// : BOOLEAN;
		private int mParentCurve;// : IfcCurve;  Really IfcBoundedCurve WR1

		public IfcTransitionCode Transition { get { return mTransition; } }
		public bool SameSense { get { return mSameSense; } }
		public IfcBoundedCurve ParentCurve { get { return mDatabase[mParentCurve] as IfcBoundedCurve; } set { mParentCurve = value.mIndex; } }

		internal IfcCompositeCurveSegment() : base() { }
		internal IfcCompositeCurveSegment(DatabaseIfc db, IfcCompositeCurveSegment s) : base(db,s) { mTransition = s.mTransition; mSameSense = s.mSameSense; ParentCurve = db.Factory.Duplicate(s.ParentCurve) as IfcBoundedCurve; }
		public IfcCompositeCurveSegment(IfcTransitionCode tc, bool sense, IfcBoundedCurve bc) : base(bc.mDatabase) { mSameSense = sense; mTransition = tc; ParentCurve = bc; }
		internal static IfcCompositeCurveSegment Parse(string str)
		{
			IfcCompositeCurveSegment s = new IfcCompositeCurveSegment();
			int pos = 0, len = str.Length;
			s.mTransition = (IfcTransitionCode)Enum.Parse(typeof(IfcTransitionCode), ParserSTEP.StripField(str, ref pos, str.Length).Replace(".", ""));
			s.mSameSense = ParserSTEP.StripBool(str, ref pos, len);
			s.mParentCurve = ParserSTEP.StripLink(str, ref pos, len);
			return s;
		}
		protected override string BuildStringSTEP() { return base.BuildStringSTEP() + ",." + mTransition.ToString() + ".," + ParserSTEP.BoolToString(mSameSense) + "," + ParserSTEP.LinkToString(mParentCurve); }

	}
	public partial class IfcCompositeProfileDef : IfcProfileDef
	{
		private List<int> mProfiles = new List<int>();// : SET [2:?] OF IfcProfileDef;
		private string mLabel = "$";// : OPTIONAL IfcLabel;

		public List<IfcProfileDef> Profiles { get { return mProfiles.ConvertAll(x => mDatabase[x] as IfcProfileDef); } set { mProfiles = value.ConvertAll(x => x.mIndex); } }
		public string Label { get { return (mLabel == "$" ? "" : ParserIfc.Decode(mLabel)); } set { mLabel = (string.IsNullOrEmpty(value) ? "$" : ParserIfc.Encode(value)); } }

		internal IfcCompositeProfileDef() : base() { }
		internal IfcCompositeProfileDef(DatabaseIfc db, IfcCompositeProfileDef p) : base(db, p)
		{
			Profiles = p.Profiles.ConvertAll(x => db.Factory.Duplicate(x) as IfcProfileDef);
			mLabel = p.mLabel;
		}
		private IfcCompositeProfileDef(DatabaseIfc m, string name) : base(m,name)
		{
			if (mDatabase.mModelView == ModelView.Ifc4Reference)
				throw new Exception("Invalid Model View for IfcCompositeProfileDef : " + m.ModelView.ToString());
		}
		public IfcCompositeProfileDef(string name, List<IfcProfileDef> defs) : this(defs[0].mDatabase, name) { mProfiles = defs.ConvertAll(x => x.mIndex); }
		public IfcCompositeProfileDef(string name, IfcProfileDef p1, IfcProfileDef p2) : this(p1.mDatabase, name) { mProfiles.Add(p1.mIndex); mProfiles.Add(p2.mIndex); }
		internal new static IfcCompositeProfileDef Parse(string strDef) { IfcCompositeProfileDef p = new IfcCompositeProfileDef(); int ipos = 0; parseFields(p, ParserSTEP.SplitLineFields(strDef), ref ipos); return p; }
		internal static void parseFields(IfcCompositeProfileDef p, List<string> arrFields, ref int ipos) { IfcProfileDef.parseFields(p, arrFields, ref ipos); p.mProfiles = ParserSTEP.SplitListLinks(arrFields[ipos++]); p.mLabel = arrFields[ipos++].Replace("'", ""); }
		protected override string BuildStringSTEP()
		{
			string str = base.BuildStringSTEP() + ",(" + ParserSTEP.LinkToString(mProfiles[0]);
			for (int icounter = 1; icounter < mProfiles.Count; icounter++)
				str += "," + ParserSTEP.LinkToString(mProfiles[icounter]);
			return str + (mLabel == "$" ? "),$" : "),'" + mLabel + "'");
		}
	}
	public partial class IfcCompoundPlaneAngleMeasure
	{
		internal int mDegrees = 0, mMinutes = 0, mSeconds = 0, mMicroSeconds = 0;
		internal IfcCompoundPlaneAngleMeasure(double angleDegrees)
		{
			double ang = Math.Abs(angleDegrees);
			int sign = angleDegrees < 0 ? -1 : 1;

			mDegrees = sign * (int)Math.Floor(ang);
			mMinutes = sign * (int)Math.Floor((ang - mDegrees) * 60.0);
			mSeconds = sign * (int)Math.Floor(((ang - mDegrees) * 60 - mMinutes) * 60);
			mMicroSeconds = sign * (int)Math.Floor((((ang - mDegrees) * 60 - mMinutes) * 60 - mSeconds) * 1e6);

		}
		internal IfcCompoundPlaneAngleMeasure(int degrees, int minutes, int seconds, int microSeconds)
		{
			mDegrees = degrees;
			mMinutes = minutes;
			mSeconds = seconds;
			mMicroSeconds = microSeconds;
		}
		
		public override string ToString() { return "(" + mDegrees + "," + mMinutes + "," + mSeconds + "," + mMicroSeconds + ")"; }
		internal double computeAngle()
		{
			double compound = Math.Abs(mMinutes) / 60.0 + Math.Abs(mSeconds) / 3600.0 + Math.Abs(mMicroSeconds) / 3600 * 1e-6;
			return mDegrees + (mDegrees == 0 ? (mMinutes == 0 ? (mSeconds == 0 ? (mMicroSeconds > 0 ? 1 : -1) : (mSeconds > 0 ? 1 : -1)) : (mMinutes > 0 ? 1 : -1)) : (mDegrees > 0 ? 1 : -1)) * compound;
		}

	}
	public partial class IfcCompressor : IfcFlowMovingDevice //IFC4
	{
		internal IfcCompressorTypeEnum mPredefinedType = IfcCompressorTypeEnum.NOTDEFINED;// OPTIONAL : IfcCompressorTypeEnum;
		public IfcCompressorTypeEnum PredefinedType { get { return mPredefinedType; } set { mPredefinedType = value; } }
		internal IfcCompressor() : base() { }
		internal IfcCompressor(DatabaseIfc db, IfcCompressor c) : base(db,c) { mPredefinedType = c.mPredefinedType; }
		public IfcCompressor(IfcObjectDefinition host, IfcObjectPlacement placement, IfcProductRepresentation representation, IfcDistributionSystem system) : base(host, placement, representation, system) { }

		internal static void parseFields(IfcCompressor s, List<string> arrFields, ref int ipos)
		{
			IfcEnergyConversionDevice.parseFields(s, arrFields, ref ipos);
			string str = arrFields[ipos++];
			if (str[0] == '.')
				s.mPredefinedType = (IfcCompressorTypeEnum)Enum.Parse(typeof(IfcCompressorTypeEnum), str);
		}
		internal new static IfcCompressor Parse(string strDef) { IfcCompressor s = new IfcCompressor(); int ipos = 0; parseFields(s, ParserSTEP.SplitLineFields(strDef), ref ipos); return s; }
		protected override string BuildStringSTEP()
		{
			return base.BuildStringSTEP() + (mDatabase.mRelease == ReleaseVersion.IFC2x3 ? "" : (mPredefinedType == IfcCompressorTypeEnum.NOTDEFINED ? ",$" : ",." + mPredefinedType.ToString() + "."));
		}
	}
	public partial class IfcCompressorType : IfcFlowMovingDeviceType
	{
		internal IfcCompressorTypeEnum mPredefinedType = IfcCompressorTypeEnum.NOTDEFINED;// : IfcCompressorTypeEnum;
		public IfcCompressorTypeEnum PredefinedType { get { return mPredefinedType; } set { mPredefinedType = value; } }
		internal IfcCompressorType() : base() { }
		internal IfcCompressorType(DatabaseIfc db, IfcCompressorType t) : base(db, t) { mPredefinedType = t.mPredefinedType; }
		internal IfcCompressorType(DatabaseIfc m, string name, IfcCompressorTypeEnum type) : base(m) { Name = name; mPredefinedType = type; }
		internal static void parseFields(IfcCompressorType t, List<string> arrFields, ref int ipos) { IfcFlowFittingType.parseFields(t, arrFields, ref ipos); t.mPredefinedType = (IfcCompressorTypeEnum)Enum.Parse(typeof(IfcCompressorTypeEnum), arrFields[ipos++].Replace(".", "")); }
		internal new static IfcCompressorType Parse(string strDef) { IfcCompressorType t = new IfcCompressorType(); int ipos = 0; parseFields(t, ParserSTEP.SplitLineFields(strDef), ref ipos); return t; }
		protected override string BuildStringSTEP() { return base.BuildStringSTEP() + ",." + mPredefinedType.ToString() + "."; }
	}
	public partial class IfcCommunicationsAppliance : IfcFlowTerminal //IFC4
	{
		internal IfcCommunicationsApplianceTypeEnum mPredefinedType = IfcCommunicationsApplianceTypeEnum.NOTDEFINED;// OPTIONAL : IfcCommunicationsApplianceTypeEnum;
		public IfcCommunicationsApplianceTypeEnum PredefinedType { get { return mPredefinedType; } set { mPredefinedType = value; } }

		internal IfcCommunicationsAppliance() : base() { }
		internal IfcCommunicationsAppliance(DatabaseIfc db, IfcCommunicationsAppliance a) : base(db,a) { mPredefinedType = a.mPredefinedType; }
		internal static void parseFields(IfcCommunicationsAppliance s, List<string> arrFields, ref int ipos)
		{
			IfcFlowTerminal.parseFields(s, arrFields, ref ipos);
			string str = arrFields[ipos++];
			if (str[0] == '.')
				s.mPredefinedType = (IfcCommunicationsApplianceTypeEnum)Enum.Parse(typeof(IfcCommunicationsApplianceTypeEnum), str.Substring(1, str.Length - 2));
		}
		internal new static IfcCommunicationsAppliance Parse(string strDef) { IfcCommunicationsAppliance s = new IfcCommunicationsAppliance(); int ipos = 0; parseFields(s, ParserSTEP.SplitLineFields(strDef), ref ipos); return s; }
		protected override string BuildStringSTEP() { return base.BuildStringSTEP() + (mDatabase.mRelease == ReleaseVersion.IFC2x3 ? "" : (mPredefinedType == IfcCommunicationsApplianceTypeEnum.NOTDEFINED ? ",$" : ",." + mPredefinedType.ToString() + ".")); }
	}
	public partial class IfcCommunicationsApplianceType : IfcFlowTerminalType
	{
		internal IfcCommunicationsApplianceTypeEnum mPredefinedType = IfcCommunicationsApplianceTypeEnum.NOTDEFINED;// : IfcCommunicationsApplianceBoxTypeEnum; 
		public IfcCommunicationsApplianceTypeEnum PredefinedType { get { return mPredefinedType; } set { mPredefinedType = value; } }
		internal IfcCommunicationsApplianceType() : base() { }
		internal IfcCommunicationsApplianceType(DatabaseIfc db, IfcCommunicationsApplianceType t) : base(db, t) { mPredefinedType = t.mPredefinedType; }
		internal IfcCommunicationsApplianceType(DatabaseIfc m, string name, IfcCommunicationsApplianceTypeEnum t) : base(m) { Name = name; mPredefinedType = t; }
		internal static void parseFields(IfcCommunicationsApplianceType t, List<string> arrFields, ref int ipos) { IfcFlowControllerType.parseFields(t, arrFields, ref ipos); t.mPredefinedType = (IfcCommunicationsApplianceTypeEnum)Enum.Parse(typeof(IfcCommunicationsApplianceTypeEnum), arrFields[ipos++].Replace(".", "")); }
		internal new static IfcCommunicationsApplianceType Parse(string strDef) { IfcCommunicationsApplianceType t = new IfcCommunicationsApplianceType(); int ipos = 0; parseFields(t, ParserSTEP.SplitLineFields(strDef), ref ipos); return t; }
		protected override string BuildStringSTEP() { return base.BuildStringSTEP() + ",." + mPredefinedType.ToString() + "."; }
	}
	public partial class IfcCondenser : IfcEnergyConversionDevice //IFC4
	{
		internal IfcCondenserTypeEnum mPredefinedType = IfcCondenserTypeEnum.NOTDEFINED;// OPTIONAL : IfcCCondenserTypeEnum;
		public IfcCondenserTypeEnum PredefinedType { get { return mPredefinedType; } set { mPredefinedType = value; } }

		internal IfcCondenser() : base() { }
		internal IfcCondenser(DatabaseIfc db, IfcCondenser c) : base(db, c) { mPredefinedType = c.mPredefinedType; }
		public IfcCondenser(IfcObjectDefinition host, IfcObjectPlacement placement, IfcProductRepresentation representation, IfcDistributionSystem system) : base(host, placement, representation, system) { }

		internal static void parseFields(IfcCondenser s, List<string> arrFields, ref int ipos)
		{
			IfcEnergyConversionDevice.parseFields(s, arrFields, ref ipos);
			string str = arrFields[ipos++];
			if (str[0] == '.')
				s.mPredefinedType = (IfcCondenserTypeEnum)Enum.Parse(typeof(IfcCondenserTypeEnum), str);
		}
		internal new static IfcCondenser Parse(string strDef) { IfcCondenser s = new IfcCondenser(); int ipos = 0; parseFields(s, ParserSTEP.SplitLineFields(strDef), ref ipos); return s; }
		protected override string BuildStringSTEP()
		{
			return base.BuildStringSTEP() + (mDatabase.mRelease == ReleaseVersion.IFC2x3 ? "" : (mPredefinedType == IfcCondenserTypeEnum.NOTDEFINED ? ",$" : ",." + mPredefinedType.ToString() + "."));
		}
	}
	public partial class IfcCondenserType : IfcEnergyConversionDeviceType
	{
		internal IfcCondenserTypeEnum mPredefinedType = IfcCondenserTypeEnum.NOTDEFINED;// : IfcCondenserTypeEnum;
		public IfcCondenserTypeEnum PredefinedType { get { return mPredefinedType; } set { mPredefinedType = value; } }
		internal IfcCondenserType() : base() { }
		internal IfcCondenserType(DatabaseIfc db, IfcCondenserType t) : base(db, t) { mPredefinedType = t.mPredefinedType; }
		internal IfcCondenserType(DatabaseIfc m, string name, IfcCondenserTypeEnum t) : base(m) { Name = name; mPredefinedType = t; }
		internal static void parseFields(IfcCondenserType t, List<string> arrFields, ref int ipos) { IfcEnergyConversionDeviceType.parseFields(t, arrFields, ref ipos); t.mPredefinedType = (IfcCondenserTypeEnum)Enum.Parse(typeof(IfcCondenserTypeEnum), arrFields[ipos++].Replace(".", "")); }
		internal new static IfcCondenserType Parse(string strDef) { IfcCondenserType t = new IfcCondenserType(); int ipos = 0; parseFields(t, ParserSTEP.SplitLineFields(strDef), ref ipos); return t; }
		protected override string BuildStringSTEP() { return base.BuildStringSTEP() + ",." + mPredefinedType.ToString() + "."; }
	}
	public partial class IfcCondition : IfcGroup //DEPRECEATED IFC4
	{
		internal IfcCondition() : base() { }
		internal IfcCondition(DatabaseIfc db, IfcCondition c) : base(db, c) { }
		internal new static IfcCondition Parse(string strDef) { IfcCondition c = new IfcCondition(); int ipos = 0; parseFields(c, ParserSTEP.SplitLineFields(strDef), ref ipos); return c; }
		internal static void parseFields(IfcCondition c, List<string> arrFields, ref int ipos) { IfcGroup.parseFields(c, arrFields, ref ipos); }
	}
	public partial class IfcConditionCriterion : IfcControl //DEPRECEATED IFC4
	{
		internal int mCriterion;// : IfcConditionCriterionSelect;
		internal int mCriterionDateTime;// : IfcDateTimeSelect; 
		internal IfcConditionCriterion() : base() { }
		internal IfcConditionCriterion(DatabaseIfc db, IfcConditionCriterion c) : base(db, c) { } // mCriterion = c.mCriterion; mCriterionDateTime = c.mCriterionDateTime; }
		internal static IfcConditionCriterion Parse(string strDef, ReleaseVersion schema) { IfcConditionCriterion c = new IfcConditionCriterion(); int ipos = 0; parseFields(c, ParserSTEP.SplitLineFields(strDef), ref ipos,schema); return c; }
		internal static void parseFields(IfcConditionCriterion c, List<string> arrFields, ref int ipos, ReleaseVersion schema) { IfcControl.parseFields(c, arrFields, ref ipos,schema); c.mCriterion = ParserSTEP.ParseLink(arrFields[ipos++]); c.mCriterionDateTime = ParserSTEP.ParseLink(arrFields[ipos++]); }
		protected override string BuildStringSTEP() { return base.BuildStringSTEP() + "," + ParserSTEP.LinkToString(mCriterion) + "," + ParserSTEP.LinkToString(mCriterionDateTime); }
	}
	public abstract partial class IfcConic : IfcCurve /*ABSTRACT SUPERTYPE OF (ONEOF (IfcCircle ,IfcEllipse))*/
	{
		private int mPosition;// : IfcAxis2Placement;
		public IfcAxis2Placement Position { get { return mDatabase[mPosition] as IfcAxis2Placement; } set { mPosition = value.Index; } }

		protected IfcConic() : base() { }
		protected IfcConic(IfcAxis2Placement ap) : base(ap.Database) { mPosition = ap.Index; }
		protected IfcConic(DatabaseIfc db, IfcConic c) : base(db,c) { Position = db.Factory.Duplicate( c.mDatabase[c.mPosition]) as IfcAxis2Placement; }
		internal virtual void Parse(string str, ref int pos, int len) { mPosition = ParserSTEP.StripLink(str, ref pos, len); }
		protected override string BuildStringSTEP() { return base.BuildStringSTEP() + "," + ParserSTEP.LinkToString(mPosition); }
	}
	public partial class IfcConnectedFaceSet : IfcTopologicalRepresentationItem //SUPERTYPE OF (ONEOF (IfcClosedShell ,IfcOpenShell))
	{
		private List<int> mCfsFaces = new List<int>();// : SET [1:?] OF IfcFace;
		public List<IfcFace> CfsFaces { get { return mCfsFaces.ConvertAll(x => mDatabase[x] as IfcFace); } set { mCfsFaces = value.ConvertAll(x => x.mIndex); } }

		internal IfcConnectedFaceSet() : base() { }
		internal IfcConnectedFaceSet(List<IfcFace> faces) : base(faces[0].mDatabase) { mCfsFaces = faces.ConvertAll(x => x.mIndex); }
		internal IfcConnectedFaceSet(DatabaseIfc db, IfcConnectedFaceSet c) : base(db,c) { CfsFaces = c.CfsFaces.ConvertAll(x=>db.Factory.Duplicate(x) as IfcFace); }
		protected override string BuildStringSTEP()
		{
			if (mCfsFaces.Count == 0)
				return "";
			string str = base.BuildStringSTEP() + ",(" + ParserSTEP.LinkToString(mCfsFaces[0]);
			if (mCfsFaces.Count > 100)
			{
				StringBuilder sb = new StringBuilder();
				for (int icounter = 1; icounter < mCfsFaces.Count; icounter++)
					sb.Append(",#" + mCfsFaces[icounter]);

				str += sb.ToString();
			}
			else
			{
				for (int icounter = 1; icounter < mCfsFaces.Count; icounter++)
					str += ",#" + mCfsFaces[icounter];
			}
			return str + ")";
		}
		protected void parse(string str) { mCfsFaces = ParserSTEP.SplitListLinks(str.Substring(1, str.Length - 2)); }
		internal static IfcConnectedFaceSet Parse(string str) { IfcConnectedFaceSet s = new IfcConnectedFaceSet(); s.parse(str); return s; }

	}
	public partial class IfcConnectionCurveGeometry : IfcConnectionGeometry
	{
		private int mCurveOnRelatingElement;// : IfcCurveOrEdgeCurve;
		private int mCurveOnRelatedElement;// : OPTIONAL IfcCurveOrEdgeCurve; 

		public IfcCurveOrEdgeCurve CurveOnRelatingElement { get { return mDatabase[mCurveOnRelatingElement] as IfcCurveOrEdgeCurve; } set { mCurveOnRelatingElement = value.Index; } }
		public IfcCurveOrEdgeCurve CurveOnRelatedElement { get { return mDatabase[mCurveOnRelatedElement] as IfcCurveOrEdgeCurve; } set { mCurveOnRelatedElement = value.Index; } }

		internal IfcConnectionCurveGeometry() : base() { }
		internal IfcConnectionCurveGeometry(DatabaseIfc db, IfcConnectionCurveGeometry g) : base(db, g) { CurveOnRelatingElement = db.Factory.Duplicate( g.mDatabase[ g.mCurveOnRelatingElement]) as IfcCurveOrEdgeCurve; CurveOnRelatedElement = db.Factory.Duplicate(g.mDatabase[ g.mCurveOnRelatedElement]) as IfcCurveOrEdgeCurve; }
		internal static IfcConnectionCurveGeometry Parse(string strDef) { IfcConnectionCurveGeometry c = new IfcConnectionCurveGeometry(); int ipos = 0; parseFields(c, ParserSTEP.SplitLineFields(strDef), ref ipos); return c; }
		internal static void parseFields(IfcConnectionCurveGeometry c, List<string> arrFields, ref int ipos) { IfcConnectionGeometry.parseFields(c, arrFields, ref ipos); c.mCurveOnRelatingElement = ParserSTEP.ParseLink(arrFields[ipos++]); c.mCurveOnRelatedElement = ParserSTEP.ParseLink(arrFields[ipos++]); }
		protected override string BuildStringSTEP() { return base.BuildStringSTEP() + "," + ParserSTEP.LinkToString(mCurveOnRelatingElement) + "," + ParserSTEP.LinkToString(mCurveOnRelatedElement); }
	}
	public abstract partial class IfcConnectionGeometry : BaseClassIfc /*ABSTRACT SUPERTYPE OF (ONEOF(IfcConnectionCurveGeometry,IfcConnectionPointGeometry,IfcConnectionPortGeometry,IfcConnectionSurfaceGeometry));*/
	{
		protected IfcConnectionGeometry() : base() { }
		protected IfcConnectionGeometry(DatabaseIfc db) : base(db) { }
		protected IfcConnectionGeometry(DatabaseIfc db, IfcConnectionGeometry c) : base(db) { }
		protected static void parseFields(IfcConnectionGeometry c, List<string> arrFields, ref int ipos) { }
	}
	public partial class IfcConnectionPointEccentricity : IfcConnectionPointGeometry
	{ 
		private double mEccentricityInX, mEccentricityInY, mEccentricityInZ;// : OPTIONAL IfcLengthMeasure;
		public double EccentricityInX { get { return mEccentricityInX; } set { mEccentricityInX = value; } }
		public double EccentricityInY { get { return mEccentricityInY; } set { mEccentricityInY = value; } }
		public double EccentricityInZ { get { return mEccentricityInZ; } set { mEccentricityInZ = value; } }

		internal IfcConnectionPointEccentricity() : base() { }
		internal IfcConnectionPointEccentricity(DatabaseIfc db, IfcConnectionPointEccentricity e) : base(db, e) { mEccentricityInX = e.mEccentricityInX; mEccentricityInY = e.mEccentricityInY; mEccentricityInZ = e.mEccentricityInZ; }
		public IfcConnectionPointEccentricity(IfcPointOrVertexPoint v, double x, double y, double z) : base(v) { mEccentricityInX = x; mEccentricityInY = y; mEccentricityInZ = z; }

		internal new static IfcConnectionPointEccentricity Parse(string strDef) { IfcConnectionPointEccentricity c = new IfcConnectionPointEccentricity(); int ipos = 0; parseFields(c, ParserSTEP.SplitLineFields(strDef), ref ipos); return c; }
		internal static void parseFields(IfcConnectionPointEccentricity c, List<string> arrFields, ref int ipos) { IfcConnectionPointGeometry.parseFields(c, arrFields, ref ipos); c.mEccentricityInX = ParserSTEP.ParseDouble(arrFields[ipos++]); c.mEccentricityInY = ParserSTEP.ParseDouble(arrFields[ipos++]); c.mEccentricityInZ = ParserSTEP.ParseDouble(arrFields[ipos++]); }
		protected override string BuildStringSTEP() { return base.BuildStringSTEP() + "," + ParserSTEP.DoubleOptionalToString(mEccentricityInX) + "," + ParserSTEP.DoubleOptionalToString(mEccentricityInY) + "," + ParserSTEP.DoubleOptionalToString(mEccentricityInZ); }
	}
	public partial class IfcConnectionPointGeometry : IfcConnectionGeometry
	{
		private int mPointOnRelatingElement;// : IfcPointOrVertexPoint;
		private int mPointOnRelatedElement;// : OPTIONAL IfcPointOrVertexPoint;

		public IfcPointOrVertexPoint PointOnRelatingElement { get { return mDatabase[mPointOnRelatingElement] as IfcPointOrVertexPoint; } set { mPointOnRelatingElement = value.Index; } }
		public IfcPointOrVertexPoint PointOnRelatedElement { get { return mDatabase[mPointOnRelatedElement] as IfcPointOrVertexPoint; } set { mPointOnRelatedElement = value.Index; } }

		internal IfcConnectionPointGeometry() : base() { }
		internal IfcConnectionPointGeometry(IfcPointOrVertexPoint v) : base(v.Database) { mPointOnRelatingElement = v.Index; }
		internal IfcConnectionPointGeometry(DatabaseIfc db, IfcConnectionPointGeometry g) : base(db,g) { PointOnRelatingElement = db.Factory.Duplicate(g.mDatabase[g.mPointOnRelatingElement]) as IfcPointOrVertexPoint;  PointOnRelatedElement = db.Factory.Duplicate(g.mDatabase[g.mPointOnRelatedElement]) as IfcPointOrVertexPoint; }
		internal static IfcConnectionPointGeometry Parse(string strDef) { IfcConnectionPointGeometry c = new IfcConnectionPointGeometry(); int ipos = 0; parseFields(c, ParserSTEP.SplitLineFields(strDef), ref ipos); return c; }
		internal static void parseFields(IfcConnectionPointGeometry c, List<string> arrFields, ref int ipos) { IfcConnectionGeometry.parseFields(c, arrFields, ref ipos); c.mPointOnRelatingElement = ParserSTEP.ParseLink(arrFields[ipos++]); c.mPointOnRelatedElement = ParserSTEP.ParseLink(arrFields[ipos++]); }
		protected override string BuildStringSTEP() { return base.BuildStringSTEP() + "," + ParserSTEP.LinkToString(mPointOnRelatingElement) + "," + ParserSTEP.LinkToString(mPointOnRelatedElement); }
	}
	//ENTITY IfcConnectionPortGeometry  // DEPRECEATED IFC4
	public partial class IfcConnectionSurfaceGeometry : IfcConnectionGeometry
	{
		internal int mSurfaceOnRelatingElement;// : IfcSurfaceOrFaceSurface;
		internal int mSurfaceOnRelatedElement;// : OPTIONAL IfcSurfaceOrFaceSurface;

		public IfcSurfaceOrFaceSurface SurfaceOnRelatingElement { get { return mDatabase[mSurfaceOnRelatingElement] as IfcSurfaceOrFaceSurface; } set { mSurfaceOnRelatingElement = value.Index; } }
		public IfcSurfaceOrFaceSurface SurfaceOnRelatedElement { get { return mDatabase[mSurfaceOnRelatedElement] as IfcSurfaceOrFaceSurface; } set { mSurfaceOnRelatedElement = value.Index; } }

		internal IfcConnectionSurfaceGeometry() : base() { }
		internal IfcConnectionSurfaceGeometry(DatabaseIfc db, IfcConnectionSurfaceGeometry g) : base(db,g) { SurfaceOnRelatingElement = db.Factory.Duplicate(g.mDatabase[g.mSurfaceOnRelatingElement]) as IfcSurfaceOrFaceSurface; SurfaceOnRelatedElement = db.Factory.Duplicate(g.mDatabase[g.mSurfaceOnRelatedElement]) as IfcSurfaceOrFaceSurface; }
		internal static IfcConnectionSurfaceGeometry Parse(string strDef) { IfcConnectionSurfaceGeometry c = new IfcConnectionSurfaceGeometry(); int ipos = 0; parseFields(c, ParserSTEP.SplitLineFields(strDef), ref ipos); return c; }
		internal static void parseFields(IfcConnectionSurfaceGeometry c, List<string> arrFields, ref int ipos) { IfcConnectionGeometry.parseFields(c, arrFields, ref ipos); c.mSurfaceOnRelatingElement = ParserSTEP.ParseLink(arrFields[ipos++]); c.mSurfaceOnRelatedElement = ParserSTEP.ParseLink(arrFields[ipos++]); }
		protected override string BuildStringSTEP() { return base.BuildStringSTEP() + "," + ParserSTEP.LinkToString(mSurfaceOnRelatingElement) + "," + ParserSTEP.LinkToString(mSurfaceOnRelatedElement); }
	}
	public abstract partial class IfcConstraint : BaseClassIfc, IfcResourceObjectSelect //IFC4Change ABSTRACT SUPERTYPE OF(ONEOF(IfcMetric, IfcObjective));
	{
		internal string mName = "NOTDEFINED";// :  IfcLabel;
		internal string mDescription = "$";// : OPTIONAL IfcText;
		internal IfcConstraintEnum mConstraintGrade;// : IfcConstraintEnum
		internal string mConstraintSource = "$";// : OPTIONAL IfcLabel;
		internal int mCreatingActor;// : OPTIONAL IfcActorSelect;
		internal string mCreationTime = "$";// : OPTIONAL IfcDateTimeSelect; IFC4 IfcDateTime 
		internal int mSSCreationTime;// : OPTIONAL IfcDateTimeSelect; IFC4 IfcDateTime 
		internal string mUserDefinedGrade = "$";// : OPTIONAL IfcLabel

		public override string Name { get { return ParserIfc.Decode(mName); } set { mName = (string.IsNullOrEmpty(value) ? "NOTDEFINED" : ParserIfc.Encode(value)); } }
		public string Description { get { return (mDescription == "$" ? "" : ParserIfc.Decode(mDescription)); } set { mDescription = (string.IsNullOrEmpty(value) ? "$" : ParserIfc.Encode(value)); } }
		public IfcConstraintEnum ConstraintGrade { get { return mConstraintGrade; } set { mConstraintGrade = value; } }
		public string ConstraintSource { get { return (mConstraintSource == "$" ? "" : ParserIfc.Decode(mConstraintSource)); } set { mConstraintSource = (string.IsNullOrEmpty(value) ? "$" : ParserIfc.Encode(value)); } }
		public IfcActorSelect CreatingActor { get { return mDatabase[mCreatingActor] as IfcActorSelect; } set { mCreatingActor = (value == null ? 0 : value.Index); } }
		//creationtime
		public string UserDefinedGrade { get { return (mUserDefinedGrade == "$" ? "" : ParserIfc.Decode(mUserDefinedGrade)); } set { mUserDefinedGrade = (string.IsNullOrEmpty(value) ? "$" : ParserIfc.Encode(value)); } }

		//	INVERSE
		internal List<IfcExternalReferenceRelationship> mHasExternalReferences = new List<IfcExternalReferenceRelationship>(); //IFC4
		internal List<IfcResourceConstraintRelationship> mPropertiesForConstraint = new List<IfcResourceConstraintRelationship>();//	 :	SET OF IfcResourceConstraintRelationship FOR RelatingConstraint;
		internal List<IfcResourceConstraintRelationship> mHasConstraintRelationships = new List<IfcResourceConstraintRelationship>(); //ggc
		internal List<IfcRelAssociatesConstraint> mConstraintForObjects = new List<IfcRelAssociatesConstraint>();// gg	 :	SET [0:?] OF IfcRelAssociatesConstraint FOR RelatedResourceObjects;
		public List<IfcExternalReferenceRelationship> HasExternalReferences { get { return mHasExternalReferences; } }
		public List<IfcResourceConstraintRelationship> HasConstraintRelationships { get { return mHasConstraintRelationships; } }

		protected IfcConstraint() : base() { }
		protected IfcConstraint(DatabaseIfc db, IfcConstraint c) : base(db,c)
		{
			mName = c.mName;
			mDescription = c.mDescription;
			mConstraintGrade = c.mConstraintGrade;
			mConstraintSource = c.mConstraintSource;
			if(mCreatingActor > 0)
				CreatingActor = db.Factory.Duplicate(c.mDatabase[c.mCreatingActor]) as IfcActorSelect;
			mCreationTime = c.mCreationTime;
			if(mSSCreationTime > 0)
				mSSCreationTime = db.Factory.Duplicate(c.mDatabase[ c.mSSCreationTime]).mIndex;
			mUserDefinedGrade = c.mUserDefinedGrade;
		}
		protected IfcConstraint(DatabaseIfc db, string name, IfcConstraintEnum constraint) : base(db) { Name = name; mConstraintGrade = constraint; }
		internal static void parseFields(IfcConstraint a, List<string> arrFields, ref int ipos, ReleaseVersion schema)
		{
			a.mName = arrFields[ipos++].Replace("'", "");
			a.mDescription = arrFields[ipos++].Replace("'", "");
			a.mConstraintGrade = (IfcConstraintEnum)Enum.Parse(typeof(IfcConstraintEnum), arrFields[ipos++].Replace(".", ""));
			a.mConstraintSource = arrFields[ipos++].Replace("'", "");
			a.mCreatingActor = ParserSTEP.ParseLink(arrFields[ipos++]);
			if (schema == ReleaseVersion.IFC2x3)
				a.mSSCreationTime = ParserSTEP.ParseLink(arrFields[ipos++]);
			else
				a.mCreationTime = arrFields[ipos++].Replace("'", "");
			a.mUserDefinedGrade = arrFields[ipos++].Replace("'", "");
		}
		protected override string BuildStringSTEP() { return base.BuildStringSTEP() + ",'" + mName + (mDescription == "$" ? "',$,." : "','" + mDescription + "',.") + mConstraintGrade.ToString() + (mConstraintSource == "$" ? ".,$," : ".,'" + mConstraintSource + "',") + ParserSTEP.LinkToString(mCreatingActor) + "," + (mDatabase.mRelease == ReleaseVersion.IFC2x3 ? ParserSTEP.LinkToString(mSSCreationTime) : (mCreationTime == "$" ? "$" : "'" + mCreationTime + "'")) + (mUserDefinedGrade == "$" ? ",$" : ",'" + mUserDefinedGrade + "'"); }

		public override bool Destruct(bool children)
		{
			foreach (IfcRelAssociatesConstraint rac in mConstraintForObjects)
				mDatabase[rac.mIndex] = null;
			List<IfcResourceConstraintRelationship> rcrs = mPropertiesForConstraint;
			for (int icounter = 0; icounter < rcrs.Count; icounter++)
				rcrs[icounter].Destruct(true);
			return base.Destruct(children);
		}
	}
	//ENTITY IfcConstraintAggregationRelationship; // DEPRECEATED IFC4
	//ENTITY IfcConstraintclassificationRelationship; // DEPRECEATED IFC4
	//ENTITY IfcConstraintRelationship; // DEPRECEATED IFC4
	//ENTITY IfcConstructionResource
	public partial class IfcConstructionEquipmentResource : IfcConstructionResource
	{
		internal IfcConstructionEquipmentResourceTypeEnum mPredefinedType = IfcConstructionEquipmentResourceTypeEnum.NOTDEFINED;// OPTIONAL : IfcRoofTypeEnum; 
		public IfcConstructionEquipmentResourceTypeEnum PredefinedType { get { return mPredefinedType; } set { mPredefinedType = value; } }

		internal IfcConstructionEquipmentResource() : base() { }
		internal IfcConstructionEquipmentResource(DatabaseIfc db, IfcConstructionEquipmentResource r) : base(db,r) { mPredefinedType = r.mPredefinedType; }
		internal IfcConstructionEquipmentResource(DatabaseIfc db) : base(db) { }
		internal static IfcConstructionEquipmentResource Parse(string strDef, ReleaseVersion schema) { IfcConstructionEquipmentResource r = new IfcConstructionEquipmentResource(); int ipos = 0; parseFields(r, ParserSTEP.SplitLineFields(strDef), ref ipos,schema); return r; }
		internal static void parseFields(IfcConstructionEquipmentResource r, List<string> arrFields, ref int ipos, ReleaseVersion schema)
		{
			IfcConstructionResource.parseFields(r, arrFields, ref ipos,schema);
			if (schema != ReleaseVersion.IFC2x3)
			{
				string str = arrFields[ipos++];
				if (str[0] == '.')
					r.mPredefinedType = (IfcConstructionEquipmentResourceTypeEnum)Enum.Parse(typeof(IfcConstructionEquipmentResourceTypeEnum), str.Substring(1, str.Length - 2));
			}
		}
		protected override string BuildStringSTEP() { return base.BuildStringSTEP() + ",." + mPredefinedType.ToString() + "."; }
	}
	public partial class IfcConstructionEquipmentResourceType : IfcConstructionResourceType //IFC4
	{
		internal IfcConstructionEquipmentResourceTypeEnum mPredefinedType = IfcConstructionEquipmentResourceTypeEnum.NOTDEFINED;
		public IfcConstructionEquipmentResourceTypeEnum PredefinedType { get { return mPredefinedType; } set { mPredefinedType = value; } }

		internal IfcConstructionEquipmentResourceType() : base() { }
		internal IfcConstructionEquipmentResourceType(DatabaseIfc db, IfcConstructionEquipmentResourceType t) : base(db, t) { mPredefinedType = t.mPredefinedType; }
		internal IfcConstructionEquipmentResourceType(DatabaseIfc m, string name, IfcConstructionEquipmentResourceTypeEnum type) : base(m) { Name = name; mPredefinedType = type; }
		internal static void parseFields(IfcConstructionEquipmentResourceType t, List<string> arrFields, ref int ipos) { IfcConstructionResourceType.parseFields(t, arrFields, ref ipos); t.mPredefinedType = (IfcConstructionEquipmentResourceTypeEnum)Enum.Parse(typeof(IfcConstructionEquipmentResourceTypeEnum), arrFields[ipos++].Replace(".", "")); }
		internal new static IfcConstructionEquipmentResourceType Parse(string strDef) { IfcConstructionEquipmentResourceType t = new IfcConstructionEquipmentResourceType(); int ipos = 0; parseFields(t, ParserSTEP.SplitLineFields(strDef), ref ipos); return t; }
		protected override string BuildStringSTEP() { return base.BuildStringSTEP() + ",." + mPredefinedType.ToString() + "."; }
	}
	public partial class IfcConstructionMaterialResource : IfcConstructionResource
	{
		internal IfcConstructionMaterialResourceTypeEnum mPredefinedType = IfcConstructionMaterialResourceTypeEnum.NOTDEFINED;// OPTIONAL : IfcRoofTypeEnum; 
		public IfcConstructionMaterialResourceTypeEnum PredefinedType { get { return mPredefinedType; } set { mPredefinedType = value; } }

		internal IfcConstructionMaterialResource() : base() { }
		internal IfcConstructionMaterialResource(DatabaseIfc db, IfcConstructionMaterialResource r) : base(db,r) { mPredefinedType = r.mPredefinedType; }
		internal IfcConstructionMaterialResource(DatabaseIfc db) : base(db) { }
		internal static IfcConstructionMaterialResource Parse(string strDef, ReleaseVersion schema) { IfcConstructionMaterialResource r = new IfcConstructionMaterialResource(); int ipos = 0; parseFields(r, ParserSTEP.SplitLineFields(strDef), ref ipos,schema); return r; }
		internal static void parseFields(IfcConstructionMaterialResource r, List<string> arrFields, ref int ipos, ReleaseVersion schema)
		{
			IfcConstructionResource.parseFields(r, arrFields, ref ipos,schema);
			if (schema != ReleaseVersion.IFC2x3)
			{
				string str = arrFields[ipos++];
				if (str[0] == '.')
					r.mPredefinedType = (IfcConstructionMaterialResourceTypeEnum)Enum.Parse(typeof(IfcConstructionMaterialResourceTypeEnum), str.Substring(1, str.Length - 2));
			}
		}
		protected override string BuildStringSTEP() { return base.BuildStringSTEP() + ",." + mPredefinedType.ToString() + "."; }
	}
	public partial class IfcConstructionMaterialResourceType : IfcConstructionResourceType //IFC4
	{
		internal IfcConstructionMaterialResourceTypeEnum mPredefinedType = IfcConstructionMaterialResourceTypeEnum.NOTDEFINED;
		public IfcConstructionMaterialResourceTypeEnum PredefinedType { get { return mPredefinedType; } set { mPredefinedType = value; } }

		internal IfcConstructionMaterialResourceType() : base() { }
		internal IfcConstructionMaterialResourceType(DatabaseIfc db, IfcConstructionMaterialResourceType t) : base(db, t) { mPredefinedType = t.mPredefinedType; }
		internal IfcConstructionMaterialResourceType(DatabaseIfc m, string name, IfcConstructionMaterialResourceTypeEnum type) : base(m) { Name = name; mPredefinedType = type; }
		internal static void parseFields(IfcConstructionMaterialResourceType t, List<string> arrFields, ref int ipos) { IfcConstructionResourceType.parseFields(t, arrFields, ref ipos); t.mPredefinedType = (IfcConstructionMaterialResourceTypeEnum)Enum.Parse(typeof(IfcConstructionMaterialResourceTypeEnum), arrFields[ipos++].Replace(".", "")); }
		internal new static IfcConstructionMaterialResourceType Parse(string strDef) { IfcConstructionMaterialResourceType t = new IfcConstructionMaterialResourceType(); int ipos = 0; parseFields(t, ParserSTEP.SplitLineFields(strDef), ref ipos); return t; }
		protected override string BuildStringSTEP() { return base.BuildStringSTEP() + ",." + mPredefinedType.ToString() + "."; }
	}
	public partial class IfcConstructionProductResource : IfcConstructionResource
	{
		internal IfcConstructionProductResourceTypeEnum mPredefinedType = IfcConstructionProductResourceTypeEnum.NOTDEFINED;// OPTIONAL : IfcRoofTypeEnum; 
		public IfcConstructionProductResourceTypeEnum PredefinedType { get { return mPredefinedType; } set { mPredefinedType = value; } }

		internal IfcConstructionProductResource() : base() { }
		internal IfcConstructionProductResource(DatabaseIfc db, IfcConstructionProductResource r) : base(db,r) { mPredefinedType = r.mPredefinedType; }
		internal IfcConstructionProductResource(DatabaseIfc db) : base(db) { }
		internal static IfcConstructionProductResource Parse(string strDef, ReleaseVersion schema) { IfcConstructionProductResource r = new IfcConstructionProductResource(); int ipos = 0; parseFields(r, ParserSTEP.SplitLineFields(strDef), ref ipos,schema); return r; }
		internal static void parseFields(IfcConstructionProductResource r, List<string> arrFields, ref int ipos, ReleaseVersion schema)
		{
			IfcConstructionResource.parseFields(r, arrFields, ref ipos,schema);
			if (schema != ReleaseVersion.IFC2x3)
			{
				string str = arrFields[ipos++];
				if (str[0] == '.')
					r.mPredefinedType = (IfcConstructionProductResourceTypeEnum)Enum.Parse(typeof(IfcConstructionProductResourceTypeEnum), str.Substring(1, str.Length - 2));
			}
		}
		protected override string BuildStringSTEP() { return base.BuildStringSTEP() + ",." + mPredefinedType.ToString() + "."; }
	}
	public class IfcConstructionProductResourceType : IfcConstructionResourceType //IFC4
	{
		internal IfcConstructionProductResourceTypeEnum mPredefinedType = IfcConstructionProductResourceTypeEnum.NOTDEFINED;
		public IfcConstructionProductResourceTypeEnum PredefinedType { get { return mPredefinedType; } set { mPredefinedType = value; } }

		internal IfcConstructionProductResourceType() : base() { }
		internal IfcConstructionProductResourceType(DatabaseIfc db, IfcConstructionProductResourceType t) : base(db, t) { mPredefinedType = t.mPredefinedType; }
		internal IfcConstructionProductResourceType(DatabaseIfc m, string name, IfcConstructionProductResourceTypeEnum type) : base(m) { Name = name; mPredefinedType = type; }
		internal static void parseFields(IfcConstructionProductResourceType t, List<string> arrFields, ref int ipos) { IfcConstructionResourceType.parseFields(t, arrFields, ref ipos); t.mPredefinedType = (IfcConstructionProductResourceTypeEnum)Enum.Parse(typeof(IfcConstructionProductResourceTypeEnum), arrFields[ipos++].Replace(".", "")); }
		internal new static IfcConstructionProductResourceType Parse(string strDef) { IfcConstructionProductResourceType t = new IfcConstructionProductResourceType(); int ipos = 0; parseFields(t, ParserSTEP.SplitLineFields(strDef), ref ipos); return t; }
		protected override string BuildStringSTEP() { return base.BuildStringSTEP() + ",." + mPredefinedType.ToString() + "."; }
	}
	public abstract partial class IfcConstructionResource : IfcResource //ABSTRACT SUPERTYPE OF (ONEOF(IfcConstructionEquipmentResource, IfcConstructionMaterialResource, IfcConstructionProductResource, IfcCrewResource, IfcLaborResource, IfcSubContractResource))
	{
		internal int mUsage; //:	OPTIONAL IfcResourceTime; IFC4
		internal List<int> mBaseCosts = new List<int>();//	 :	OPTIONAL LIST [1:?] OF IfcAppliedValue; IFC4
		internal int mBaseQuantity;//	 :	OPTIONAL IfcPhysicalQuantity; IFC4 

		public IfcResourceTime Usage { get { return mDatabase[mUsage] as IfcResourceTime; } set { mUsage = (value == null  ? 0 : value.mIndex); } }
		public List<IfcAppliedValue> BaseCosts { get { return mBaseCosts.ConvertAll(x => mDatabase[x] as IfcAppliedValue); } set { mBaseCosts = (value == null ? new List<int>() : value.ConvertAll(x => x.mIndex)); } }
		public IfcPhysicalQuantity BaseQuantity { get { return mDatabase[mBaseQuantity] as IfcPhysicalQuantity; } set { mBaseQuantity = value == null ? 0 : value.mIndex; } }
		protected IfcConstructionResource() : base() { }
		protected IfcConstructionResource(DatabaseIfc db, IfcConstructionResource r) : base(db,r)
		{
			if(r.mUsage > 0)
				Usage = db.Factory.Duplicate(r.Usage) as IfcResourceTime;
			if(r.mBaseCosts.Count > 0)
				BaseCosts = r.BaseCosts.ConvertAll(x=>db.Factory.Duplicate(x) as IfcAppliedValue);
			if(r.mBaseQuantity > 0)
				BaseQuantity = db.Factory.Duplicate(r.BaseQuantity) as IfcPhysicalQuantity;
		}
		protected IfcConstructionResource(DatabaseIfc db) : base(db) { }
		protected IfcConstructionResource(DatabaseIfc m, IfcResourceTime usage, List<IfcAppliedValue> baseCosts, IfcPhysicalQuantity baseQuantity)
			: base(m) { if (usage != null) mUsage = usage.mIndex; if (baseCosts != null && baseCosts.Count > 0) mBaseCosts = baseCosts.ConvertAll(x => x.mIndex); if (baseQuantity != null) mBaseQuantity = baseQuantity.mIndex; }
		protected static void parseFields(IfcConstructionResource c, List<string> arrFields, ref int ipos, ReleaseVersion schema)
		{
			IfcResource.parseFields(c, arrFields, ref ipos);
			if (schema != ReleaseVersion.IFC2x3)
			{
				c.mUsage = ParserSTEP.ParseLink(arrFields[ipos++]);
				c.mBaseCosts = ParserSTEP.SplitListLinks(arrFields[ipos++]);
				c.mBaseQuantity = ParserSTEP.ParseLink(arrFields[ipos++]);
			}
		}
		protected override string BuildStringSTEP() { return base.BuildStringSTEP() + (mDatabase.mRelease == ReleaseVersion.IFC2x3 ? "" : (mUsage == 0 ? ",$," : ",#" + mUsage + ",") + ParserSTEP.ListLinksToString(mBaseCosts) + (mBaseQuantity == 0 ? ",$" : ",#" + mBaseQuantity)); }
	}
	public abstract partial class IfcConstructionResourceType : IfcTypeResource //IFC4
	{
		internal List<int> mBaseCosts = new List<int>();//	 :	OPTIONAL LIST [1:?] OF IfcAppliedValue; 
		internal int mBaseQuantity;//	 :	OPTIONAL IfcPhysicalQuantity; 

		public List<IfcAppliedValue> BaseCosts { get { return mBaseCosts.ConvertAll(x => mDatabase[x] as IfcAppliedValue); } set { mBaseCosts = (value == null ? new List<int>() : value.ConvertAll(x => x.mIndex)); } }
		public IfcPhysicalQuantity BaseQuantity { get { return mDatabase[mBaseQuantity] as IfcPhysicalQuantity; } set { mBaseQuantity = (value == null ? 0 : value.mIndex); } }

		protected IfcConstructionResourceType() : base() { }
		protected IfcConstructionResourceType(DatabaseIfc db) : base(db) { }
		protected IfcConstructionResourceType(DatabaseIfc db, IfcConstructionResourceType t) : base(db, t) { mBaseCosts.AddRange(t.mBaseCosts); mBaseQuantity = t.mBaseQuantity; }
		internal static void parseFields(IfcConstructionResourceType t, List<string> arrFields, ref int ipos) { IfcTypeProcess.parseFields(t, arrFields, ref ipos); t.mBaseCosts = ParserSTEP.SplitListLinks(arrFields[ipos++]); t.mBaseQuantity = ParserSTEP.ParseLink(arrFields[ipos++]); }
		protected override string BuildStringSTEP() { return (mDatabase.mRelease == ReleaseVersion.IFC2x3 ? "" : base.BuildStringSTEP() + "," + ParserSTEP.ListLinksToString(mBaseCosts) + (mBaseQuantity == 0 ? ",$" : ",#" + mBaseQuantity)); }
	}
	public abstract partial class IfcContext : IfcObjectDefinition//(IfcProject, IfcProjectLibrary)
	{
		internal string mObjectType = "$";//	 :	OPTIONAL IfcLabel;
		private string mLongName = "$";// : OPTIONAL IfcLabel;
		private string mPhase = "$";// : OPTIONAL IfcLabel;
		internal List<int> mRepresentationContexts = new List<int>();// : 	OPTIONAL SET [1:?] OF IfcRepresentationContext;
		private int mUnitsInContext;// : OPTIONAL IfcUnitAssignment; IFC2x3 not Optional
		//INVERSE
		internal List<IfcRelDefinesByProperties> mIsDefinedBy = new List<IfcRelDefinesByProperties>();
		internal List<IfcRelDeclares> mDeclares = new List<IfcRelDeclares>();

		public string ObjectType { get { return mObjectType == "$" ? "" : ParserIfc.Decode(mObjectType); } set { mObjectType = (string.IsNullOrEmpty(value) ? "$" : ParserIfc.Encode(value)); } }
		public string LongName { get { return (mLongName == "$" ? "" : ParserIfc.Decode(mLongName)); } set { mLongName = (string.IsNullOrEmpty(value) ? "$" : ParserIfc.Encode(value)); } }
		public string Phase { get { return (mPhase == "$" ? "" : ParserIfc.Decode(mPhase)); } set { mPhase = (string.IsNullOrEmpty(value) ? "$" : ParserIfc.Encode(value)); } }
		public List<IfcRepresentationContext> RepresentationContexts
		{
			get { return mRepresentationContexts.ConvertAll(x => mDatabase[x] as IfcRepresentationContext); }
			set
			{
				if (value == null)
					mRepresentationContexts.Clear();
				else
					mRepresentationContexts = value.ConvertAll(x => x.mIndex);
			}
		}
		public IfcUnitAssignment UnitsInContext { get { return mDatabase[mUnitsInContext] as IfcUnitAssignment; } set { mUnitsInContext = (value == null ? 0 : value.mIndex); } }

		public List<IfcRelDefinesByProperties> IsDefinedBy { get { return mIsDefinedBy; } set { mIsDefinedBy = value; for (int icounter = 0; icounter < value.Count; icounter++) value[icounter].Assign(this); } }
		public List<IfcRelDeclares> Declares { get { return mDeclares; } set { mDeclares = value; for (int icounter = 0; icounter < value.Count; icounter++) value[icounter].RelatingContext = this; } }
	
		public DatabaseIfc Model { get { return mDatabase; } }

		protected IfcContext() : base() { }
		protected IfcContext(DatabaseIfc db, IfcContext c) : base(db, c,false)
		{
			if(db.mContext == null)
				db.mContext = this;
			mObjectType = c.mObjectType;
			mLongName = c.mLongName;
			mPhase = c.mPhase;
			RepresentationContexts = c.RepresentationContexts.ConvertAll(x => db.Factory.Duplicate(x) as IfcRepresentationContext);
			if (c.mUnitsInContext > 0)
				UnitsInContext = db.Factory.Duplicate(c.UnitsInContext) as IfcUnitAssignment;

			foreach (IfcRelDefinesByProperties rdp in c.mIsDefinedBy)
			{
				IfcRelDefinesByProperties drdp = db.Factory.Duplicate(rdp) as IfcRelDefinesByProperties;
				drdp.Assign(this);
			}
		}
		protected IfcContext(DatabaseIfc db, string name, IfcUnitAssignment.Length length) : base(db)
		{
			Name = name;
			if (db.Factory.mGeometricRepresentationContext != null)
				mRepresentationContexts.Add(db.Factory.mGeometricRepresentationContext.mIndex);
			IfcUnitAssignment u = new IfcUnitAssignment(db);
			u.SetUnits(length);
			UnitsInContext = u;
			mIsDecomposedBy.Clear(); //??? Jon to remove
			db.mContext = this;
		}
		protected IfcContext(DatabaseIfc m, string name) : base(m)
		{
			Name = name;
			if (m.Factory.mGeometricRepresentationContext != null)
				mRepresentationContexts.Add(m.Factory.mGeometricRepresentationContext.mIndex);
			mIsDecomposedBy.Clear(); //??? Jon
		}
		internal static void parseFields(IfcContext p, List<string> arrFields, ref int ipos)
		{
			IfcObjectDefinition.parseFields(p, arrFields, ref ipos);
			p.mObjectType = arrFields[ipos++].Replace("'", "");
			p.mLongName = arrFields[ipos++].Replace("'", "");
			p.mPhase = arrFields[ipos++].Replace("'", "");
			string s = arrFields[ipos++];
			if (s != "$")
				p.mRepresentationContexts = ParserSTEP.SplitListLinks(s);
			p.mUnitsInContext = ParserSTEP.ParseLink(arrFields[ipos++]);

		}
		protected override string BuildStringSTEP()
		{
			string str = base.BuildStringSTEP() + (mObjectType == "$" ? ",$" : ",'" + mObjectType + "'") + (mLongName == "$" ? ",$" : ",'" + mLongName + "'") + (mPhase == "$" ? ",$" : ",'" + mPhase + "'");
			if (mRepresentationContexts.Count == 0)
				return str + ",$," + (mUnitsInContext == 0 ? "$" : ParserSTEP.LinkToString(mUnitsInContext));
			{
				str += ",(" + ParserSTEP.LinkToString(mRepresentationContexts[0]);
				for (int icounter = 1; icounter < mRepresentationContexts.Count; icounter++)
					str += "," + ParserSTEP.LinkToString(mRepresentationContexts[icounter]);
			}
			return str + ")," + (mUnitsInContext == 0 ? "$" : ParserSTEP.LinkToString(mUnitsInContext));
		}

		internal void setStructuralUnits()
		{
			IfcUnitAssignment ua = UnitsInContext;
			if (ua != null)
				ua.setStructuralUnits();
		}
		internal double setSIScale()
		{
			IfcUnitAssignment ua = UnitsInContext;
			if (ua != null)
				return ua.LengthScaleSI;
			return 1;
		}
		internal void initializeUnitsAndScales()
		{
			if (mRepresentationContexts.Count > 0)
			{
				for (int icounter = 0; icounter < mRepresentationContexts.Count; icounter++)
				{
					IfcGeometricRepresentationContext c = mDatabase[mRepresentationContexts[icounter]] as IfcGeometricRepresentationContext;
					if (c != null)
					{
						if(!double.IsNaN(c.mPrecision))
							mDatabase.Tolerance = c.mPrecision;
						break;
					}
				}
			}
			setSIScale();
		}
		public void AddDeclared(IfcDefinitionSelect d)
		{
			if (mDeclares.Count == 0)
			{
				new IfcRelDeclares(this, d);
			}
			else
				mDeclares[0].AddDefinition(d);
		}
		internal void AddRepresentationContext(IfcRepresentationContext rc)
		{
			if(!mRepresentationContexts.Contains(rc.mIndex))
				mRepresentationContexts.Add(rc.mIndex);
		}

		public override List<T> Extract<T>()
		{
			List<T> result = base.Extract<T>();

			Type[] interfaces = typeof(T).GetInterfaces();
			if(interfaces.Contains(typeof(IfcDefinitionSelect)))
			{
				foreach(IfcRelDeclares rd in Declares)
				{
					List<IfcDefinitionSelect> ds = rd.RelatedDefinitions;
					foreach(IfcDefinitionSelect d in ds)
					{
						if (d is T && !result.Contains((T)d))
							result.Add((T)d);
						result.AddRange(d.Extract<T>());
					}
				}
			}
			foreach (IfcRelDefinesByProperties rdp in mIsDefinedBy)
				result.AddRange(rdp.Extract<T>());
			return result;
		}
		public List<IfcTypeProduct> DeclaredTypes
		{
			get
			{
				List<IfcTypeProduct> result = new List<IfcTypeProduct>();
				List<IfcRelDeclares> declares = Declares;
				foreach (IfcRelDeclares d in declares)
				{
					List<IfcDefinitionSelect> related = d.RelatedDefinitions;
					foreach (IfcDefinitionSelect ds in related)
					{
						IfcTypeProduct tp = ds as IfcTypeProduct;
						if (tp != null)
							result.Add(tp);
					}
				}
				if (result.Count == 0)
				{
					for (int icounter = 1; icounter < mDatabase.RecordCount; icounter++)
					{
						IfcTypeProduct tp = mDatabase[icounter] as IfcTypeProduct;
						if (tp != null)
							result.Add(tp);
					}
				}
				return result;
			}
		}

		public void ChangeSchemaWIP(ReleaseVersion release) { changeSchema(release); }
		internal override void changeSchema(ReleaseVersion schema)
		{
			mDatabase.mRelease = schema;
			base.changeSchema(schema);
		}
	}
	//ENTITY IfcContextDependentUnit, IfcResourceObjectSelect
	public abstract partial class IfcControl : IfcObject //ABSTRACT SUPERTYPE OF (ONEOF (IfcActionRequest ,IfcConditionCriterion ,IfcCostItem ,IfcCostSchedule,IfcEquipmentStandard ,IfcFurnitureStandard
	{ //  ,IfcPerformanceHistory ,IfcPermit ,IfcProjectOrder ,IfcProjectOrderRecord ,IfcScheduleTimeControl ,IfcServiceLife ,IfcSpaceProgram ,IfcTimeSeriesSchedule,IfcWorkControl))
		internal string mIdentification = "$"; // : OPTIONAL IfcIdentifier; IFC4
		//INVERSE
		internal List<IfcRelAssignsToControl> mControls = new List<IfcRelAssignsToControl>();/// : SET OF IfcRelAssignsToControl FOR RelatingControl;

		public string Identification { get { return (mIdentification == "$" ? "" : ParserIfc.Decode(mIdentification)); } set { mIdentification = (string.IsNullOrEmpty(value) ? "$" : ParserIfc.Encode(value)); } }

		protected IfcControl() : base() { }
		protected IfcControl(DatabaseIfc db, IfcControl c) : base(db,c,false) { mIdentification = c.mIdentification; }
		protected IfcControl(DatabaseIfc db) : base(db)
		{
			if (mDatabase.mModelView != ModelView.Ifc4NotAssigned && mDatabase.mModelView != ModelView.If2x3NotAssigned)
				throw new Exception("Invalid Model View for IfcActor : " + db.ModelView.ToString());
		}
		protected static void parseFields(IfcControl c, List<string> arrFields, ref int ipos,ReleaseVersion schema) { IfcObject.parseFields(c, arrFields, ref ipos); if (schema != ReleaseVersion.IFC2x3) c.mIdentification = arrFields[ipos++].Replace("'", ""); }
		protected override string BuildStringSTEP() { return base.BuildStringSTEP() + (mDatabase.mRelease == ReleaseVersion.IFC2x3 ? "" : (mIdentification == "$" ? ",$" : ",'" + mIdentification + "'")); }

		public void Assign(IfcObjectDefinition o) { if (mControls.Count == 0) mControls.Add(new IfcRelAssignsToControl(this, o)); else mControls[0].AddRelated(o); }

	}
	public partial class IfcController : IfcDistributionControlElement //IFC4  
	{
		internal IfcControllerTypeEnum mPredefinedType = IfcControllerTypeEnum.NOTDEFINED;
		public IfcControllerTypeEnum PredefinedType { get { return mPredefinedType; } set { mPredefinedType = value; } }

		internal IfcController() : base() { }
		internal IfcController(DatabaseIfc db, IfcController c) : base(db,c) { mPredefinedType = c.mPredefinedType; }
		public IfcController(IfcObjectDefinition host, IfcObjectPlacement placement, IfcProductRepresentation representation, IfcDistributionSystem system) : base(host, placement, representation, system) { }
		internal static void parseFields(IfcController c, List<string> arrFields, ref int ipos) 
		{ 
			IfcDistributionControlElement.parseFields(c, arrFields, ref ipos);
			string s = arrFields[ipos++];
			if (s.StartsWith("."))
				c.mPredefinedType = (IfcControllerTypeEnum)Enum.Parse(typeof(IfcControllerTypeEnum), s.Replace(".", ""));
		}
		internal new static IfcController Parse(string strDef) { IfcController d = new IfcController(); int ipos = 0; parseFields(d, ParserSTEP.SplitLineFields(strDef), ref ipos); return d; }
		protected override string BuildStringSTEP()
		{
			return base.BuildStringSTEP() + (mDatabase.mRelease == ReleaseVersion.IFC2x3 ? "" : (mPredefinedType == IfcControllerTypeEnum.NOTDEFINED ? ",$" : ",." + mPredefinedType.ToString() + "."));
		}
	}
	public partial class IfcControllerType : IfcDistributionControlElementType
	{
		internal IfcControllerTypeEnum mPredefinedType = IfcControllerTypeEnum.NOTDEFINED;// : IfcControllerTypeEnum;
		public IfcControllerTypeEnum PredefinedType { get { return mPredefinedType; } set { mPredefinedType = value; } }

		internal IfcControllerType() : base() { }
		internal IfcControllerType(DatabaseIfc db, IfcControllerType t) : base(db, t) { mPredefinedType = t.mPredefinedType; }
		internal IfcControllerType(DatabaseIfc m, string name, IfcControllerTypeEnum t) : base(m) { Name = name; mPredefinedType = t; }
		internal static void parseFields(IfcControllerType t,List<string> arrFields, ref int ipos) { IfcDistributionControlElementType.parseFields(t,arrFields, ref ipos); t.mPredefinedType = (IfcControllerTypeEnum)Enum.Parse(typeof(IfcControllerTypeEnum), arrFields[ipos++].Replace(".", "")); }
		internal new static IfcControllerType Parse(string strDef) { IfcControllerType t = new IfcControllerType(); int ipos = 0; parseFields(t, ParserSTEP.SplitLineFields(strDef), ref ipos); return t; }
		protected override string BuildStringSTEP() { return base.BuildStringSTEP() + ",." + mPredefinedType.ToString() + "."; }
	}
	public partial class IfcConversionBasedUnit : IfcNamedUnit, IfcResourceObjectSelect //	SUPERTYPE OF(IfcConversionBasedUnitWithOffset)
	{
		private string mName = "";// : IfcLabel;
		private int mConversionFactor;// : IfcMeasureWithUnit; 
		//INVERSE
		internal List<IfcExternalReferenceRelationship> mHasExternalReferences = new List<IfcExternalReferenceRelationship>(); //IFC4
		internal List<IfcResourceConstraintRelationship> mHasConstraintRelationships = new List<IfcResourceConstraintRelationship>(); //gg
		public List<IfcExternalReferenceRelationship> HasExternalReferences { get { return mHasExternalReferences; } }
		public List<IfcResourceConstraintRelationship> HasConstraintRelationships { get { return mHasConstraintRelationships; } }

		public override string Name { get { return ParserIfc.Decode(mName); } set { mName = ParserIfc.Encode(value); } }
		public IfcMeasureWithUnit ConversionFactor { get { return mDatabase[mConversionFactor] as IfcMeasureWithUnit; } set { mConversionFactor = value.mIndex; } }
		
		internal IfcConversionBasedUnit() : base() { }
		internal IfcConversionBasedUnit(DatabaseIfc db, IfcConversionBasedUnit u) : base(db,u) { mName = u.mName; ConversionFactor = db.Factory.Duplicate( u.ConversionFactor) as IfcMeasureWithUnit; }
		public IfcConversionBasedUnit(IfcUnitEnum unit, string name, IfcMeasureWithUnit mu)
			: base(mu.mDatabase, unit, true) { Name = name.Replace("'", ""); mConversionFactor = mu.mIndex; }
		internal static IfcConversionBasedUnit Parse(string strDef) { IfcConversionBasedUnit u = new IfcConversionBasedUnit(); int ipos = 0; parseFields(u, ParserSTEP.SplitLineFields(strDef), ref ipos); return u; }
		internal static void parseFields(IfcConversionBasedUnit u, List<string> arrFields, ref int ipos) { IfcNamedUnit.parseFields(u, arrFields, ref ipos); u.mName = arrFields[ipos++].Replace("'", ""); u.mConversionFactor = ParserSTEP.ParseLink(arrFields[ipos++]); }
		protected override string BuildStringSTEP() { return base.BuildStringSTEP() + ",'" + mName + "'," + ParserSTEP.LinkToString(mConversionFactor); }
		internal override double getSIFactor() { return ConversionFactor.getSIFactor(); }
	}
	public partial class IfcConversionBasedUnitWithOffset : IfcConversionBasedUnit //IFC4
	{
		internal double mConversionOffset = 0;//	 :	IfcReal
		public double ConversionOffset { get { return mConversionOffset; } set { mConversionOffset = value; } }
		
		internal IfcConversionBasedUnitWithOffset() : base() { }
		internal IfcConversionBasedUnitWithOffset(DatabaseIfc db, IfcConversionBasedUnitWithOffset u) : base(db,u) { mConversionOffset = u.mConversionOffset; }
		internal IfcConversionBasedUnitWithOffset(IfcUnitEnum unit, string name, IfcMeasureWithUnit mu, double offset)
			: base(unit, name, mu) { mConversionOffset = offset; }
		internal new static IfcConversionBasedUnitWithOffset Parse(string strDef) { IfcConversionBasedUnitWithOffset u = new IfcConversionBasedUnitWithOffset(); int ipos = 0; parseFields(u, ParserSTEP.SplitLineFields(strDef), ref ipos); return u; }
		internal static void parseFields(IfcConversionBasedUnitWithOffset u, List<string> arrFields, ref int ipos) { IfcConversionBasedUnit.parseFields(u, arrFields, ref ipos); u.mConversionOffset = ParserSTEP.ParseDouble(arrFields[ipos++]); }
		protected override string BuildStringSTEP() { return base.BuildStringSTEP() + "," + ParserSTEP.DoubleToString(mConversionOffset); }
	}
	public partial class IfcCooledBeam : IfcEnergyConversionDevice //IFC4
	{
		internal IfcCooledBeamTypeEnum mPredefinedType = IfcCooledBeamTypeEnum.NOTDEFINED;// OPTIONAL : IfcCooledBeamTypeEnum;
		public IfcCooledBeamTypeEnum PredefinedType { get { return mPredefinedType; } set { mPredefinedType = value; } }

		internal IfcCooledBeam() : base() { }
		internal IfcCooledBeam(DatabaseIfc db, IfcCooledBeam b) : base(db, b) { mPredefinedType = b.mPredefinedType; }
		public IfcCooledBeam(IfcObjectDefinition host, IfcObjectPlacement placement, IfcProductRepresentation representation, IfcDistributionSystem system) : base(host, placement, representation, system) { }

		internal static void parseFields(IfcCooledBeam s, List<string> arrFields, ref int ipos)
		{
			IfcEnergyConversionDevice.parseFields(s, arrFields, ref ipos);
			string str = arrFields[ipos++];
			if (str[0] == '.')
				s.mPredefinedType = (IfcCooledBeamTypeEnum)Enum.Parse(typeof(IfcCooledBeamTypeEnum), str);
		}
		internal new static IfcCooledBeam Parse(string strDef) { IfcCooledBeam s = new IfcCooledBeam(); int ipos = 0; parseFields(s, ParserSTEP.SplitLineFields(strDef), ref ipos); return s; }
		protected override string BuildStringSTEP()
		{
			return base.BuildStringSTEP() + (mDatabase.mRelease == ReleaseVersion.IFC2x3 ? "" : (mPredefinedType == IfcCooledBeamTypeEnum.NOTDEFINED ? ",$" : ",." + mPredefinedType.ToString() + "."));
		}
	}
	internal class IfcCooledBeamType : IfcEnergyConversionDeviceType
	{
		internal IfcCooledBeamTypeEnum mPredefinedType = IfcCooledBeamTypeEnum.NOTDEFINED;// : IfcCooledBeamTypeEnum
		public IfcCooledBeamTypeEnum PredefinedType { get { return mPredefinedType; } set { mPredefinedType = value; } }

		internal IfcCooledBeamType() : base() { }
		internal IfcCooledBeamType(DatabaseIfc db, IfcCooledBeamType t) : base(db, t) { mPredefinedType = t.mPredefinedType; }
		internal IfcCooledBeamType(DatabaseIfc m, string name, IfcCooledBeamTypeEnum type) : base(m) { Name = name; mPredefinedType = type; }
		internal static void parseFields(IfcCooledBeamType t,List<string> arrFields, ref int ipos) { IfcEnergyConversionDeviceType.parseFields(t,arrFields, ref ipos); t.mPredefinedType = (IfcCooledBeamTypeEnum)Enum.Parse(typeof(IfcCooledBeamTypeEnum), arrFields[ipos++].Replace(".", "")); }
		internal new static IfcCooledBeamType Parse(string strDef) { IfcCooledBeamType t = new IfcCooledBeamType(); int ipos = 0; parseFields(t, ParserSTEP.SplitLineFields(strDef), ref ipos); return t; }
		protected override string BuildStringSTEP() { return base.BuildStringSTEP() + ",." + mPredefinedType.ToString() + "."; }
	}
	public partial class IfcCoolingTower : IfcEnergyConversionDevice //IFC4
	{
		internal IfcCoolingTowerTypeEnum mPredefinedType = IfcCoolingTowerTypeEnum.NOTDEFINED;// OPTIONAL : IfcCoolingTowerTypeEnum;
		public IfcCoolingTowerTypeEnum PredefinedType { get { return mPredefinedType; } set { mPredefinedType = value; } }

		internal IfcCoolingTower() : base() { }
		internal IfcCoolingTower(DatabaseIfc db, IfcCoolingTower t) : base(db, t) { mPredefinedType = t.mPredefinedType; }
		public IfcCoolingTower(IfcObjectDefinition host, IfcObjectPlacement placement, IfcProductRepresentation representation, IfcDistributionSystem system) : base(host, placement, representation, system) { }

		internal static void parseFields(IfcCoolingTower s, List<string> arrFields, ref int ipos)
		{
			IfcEnergyConversionDevice.parseFields(s, arrFields, ref ipos);
			string str = arrFields[ipos++];
			if (str[0] == '.')
				s.mPredefinedType = (IfcCoolingTowerTypeEnum)Enum.Parse(typeof(IfcCoolingTowerTypeEnum), str);
		}
		internal new static IfcCoolingTower Parse(string strDef) { IfcCoolingTower s = new IfcCoolingTower(); int ipos = 0; parseFields(s, ParserSTEP.SplitLineFields(strDef), ref ipos); return s; }
		protected override string BuildStringSTEP()
		{
			return base.BuildStringSTEP() + (mDatabase.mRelease == ReleaseVersion.IFC2x3 ? "" : (mPredefinedType == IfcCoolingTowerTypeEnum.NOTDEFINED ? ",$" : ",." + mPredefinedType.ToString() + "."));
		}
	}
	public partial class IfcCoolingTowerType : IfcEnergyConversionDeviceType
	{
		internal IfcCoolingTowerTypeEnum mPredefinedType = IfcCoolingTowerTypeEnum.NOTDEFINED;// : IfcCoolingTowerTypeEnum
		public IfcCoolingTowerTypeEnum PredefinedType { get { return mPredefinedType; } set { mPredefinedType = value; } }

		internal IfcCoolingTowerType() : base() { }
		internal IfcCoolingTowerType(DatabaseIfc db, IfcCoolingTowerType t) : base(db, t) { mPredefinedType = t.mPredefinedType; }
		internal IfcCoolingTowerType(DatabaseIfc m, string name, IfcCoolingTowerTypeEnum type) : base(m) { Name = name; mPredefinedType = type; }
		internal static void parseFields(IfcCoolingTowerType t, List<string> arrFields, ref int ipos) { IfcEnergyConversionDeviceType.parseFields(t, arrFields, ref ipos); t.mPredefinedType = (IfcCoolingTowerTypeEnum)Enum.Parse(typeof(IfcCoolingTowerTypeEnum), arrFields[ipos++].Replace(".", "")); }
		internal new static IfcCoolingTowerType Parse(string strDef) { IfcCoolingTowerType t = new IfcCoolingTowerType(); int ipos = 0; parseFields(t,ParserSTEP.SplitLineFields(strDef), ref ipos); return t; }
		protected override string BuildStringSTEP() { return base.BuildStringSTEP() + ",." + mPredefinedType.ToString() + "."; }
	}
	public partial class IfcCoordinatedUniversalTimeOffset : BaseClassIfc //DEPRECEATED IFC4
	{
		internal int mHourOffset;// : IfcHourInDay;
		internal int mMinuteOffset;// : OPTIONAL IfcMinuteInHour;
		internal IfcAheadOrBehind mSense = IfcAheadOrBehind.AHEAD;// : IfcAheadOrBehind; 
		//internal IfcCoordinatedUniversalTimeOffset(IfcCoordinatedUniversalTimeOffset v) : base() { mHourOffset = v.mHourOffset; mMinuteOffset = v.mMinuteOffset; mSense = v.mSense; }
		internal IfcCoordinatedUniversalTimeOffset() : base() { }
		internal static void parseFields(IfcCoordinatedUniversalTimeOffset s,List<string> arrFields, ref int ipos) { s.mHourOffset = int.Parse(arrFields[ipos++]); s.mMinuteOffset = int.Parse(arrFields[ipos++]); s.mSense = (IfcAheadOrBehind)Enum.Parse(typeof(IfcAheadOrBehind),arrFields[ipos++].Replace(".",""));  }
		internal static IfcCoordinatedUniversalTimeOffset Parse(string strDef) { IfcCoordinatedUniversalTimeOffset t = new IfcCoordinatedUniversalTimeOffset(); int ipos = 0; parseFields(t, ParserSTEP.SplitLineFields(strDef), ref ipos); return t; }
		protected override string BuildStringSTEP() { return base.BuildStringSTEP() + "," + mHourOffset + "," + mMinuteOffset + ",." + mSense.ToString() + "."; }
	}
	public abstract partial class IfcCoordinateOperation : BaseClassIfc // IFC4 	ABSTRACT SUPERTYPE OF(IfcMapConversion);
	{
		internal int mSourceCRS;// :	IfcCoordinateReferenceSystemSelect;
		private int mTargetCRS;// :	IfcCoordinateReferenceSystem;

		public IfcCoordinateReferenceSystemSelect SourceCRS { get { return mDatabase[mSourceCRS] as IfcCoordinateReferenceSystemSelect; } set { mSourceCRS = value.Index; if(value.HasCoordinateOperation != this) value.HasCoordinateOperation = this; } }
		public IfcCoordinateReferenceSystem TargetCRS { get { return mDatabase[mTargetCRS] as IfcCoordinateReferenceSystem; } set { mTargetCRS = value.mIndex; } }

		protected IfcCoordinateOperation() : base() { }
		protected IfcCoordinateOperation(DatabaseIfc db, IfcCoordinateOperation p) : base(db,p) { SourceCRS = db.Factory.Duplicate(p.mDatabase[p.mSourceCRS]) as IfcCoordinateReferenceSystemSelect; TargetCRS = db.Factory.Duplicate(p.TargetCRS) as IfcCoordinateReferenceSystem; }
		protected IfcCoordinateOperation(IfcCoordinateReferenceSystemSelect source, IfcCoordinateReferenceSystem target) : base(source.Database) { SourceCRS = source; TargetCRS = target; }
		protected static void parseFields(IfcCoordinateOperation o, List<string> arrFields, ref int ipos)
		{
			o.mSourceCRS = ParserSTEP.ParseLink(arrFields[ipos++]);
			o.mTargetCRS = ParserSTEP.ParseLink(arrFields[ipos++]);
		}
		protected override string BuildStringSTEP() { return base.BuildStringSTEP() + "," + ParserSTEP.LinkToString(mSourceCRS) + "," + ParserSTEP.LinkToString(mTargetCRS); }
		internal override void postParseRelate()
		{
			base.postParseRelate();
			SourceCRS.HasCoordinateOperation = this;
		}
	}
	public abstract partial class IfcCoordinateReferenceSystem : BaseClassIfc, IfcCoordinateReferenceSystemSelect  // IFC4 	ABSTRACT SUPERTYPE OF(IfcProjectedCRS);
	{
		internal string mName = "$";//:	 IfcLabel;
		internal string mDescription = "$";//	:	OPTIONAL IfcText;
		internal string mGeodeticDatum; //	: OPTIONAL IfcIdentifier;
		internal string mVerticalDatum = "$";	//:	OPTIONAL IfcIdentifier;
		//INVERSE
		private IfcCoordinateOperation mHasCoordinateOperation = null;

		public override string Name { get { return (mName == "$" ? "" : ParserIfc.Decode(mName)); } set { mName = string.IsNullOrEmpty(value) ? "Unknown" :  ParserIfc.Encode(value); } }
		public string Description { get { return (mDescription == "$" ? "" : ParserIfc.Decode(mDescription)); } set { mDescription = (string.IsNullOrEmpty(value) ? "$" : ParserIfc.Encode(value)); } }
		public string GeodeticDatum { get { return  ParserIfc.Decode(mGeodeticDatum); } set { mGeodeticDatum = (string.IsNullOrEmpty(value) ? "$" : ParserIfc.Encode(value)); } }
		public string VerticalDatum { get { return (mVerticalDatum == "$" ? "" : ParserIfc.Decode(mVerticalDatum)); } set { mVerticalDatum = (string.IsNullOrEmpty(value) ? "$" : ParserIfc.Encode(value)); } }
		public IfcCoordinateOperation HasCoordinateOperation { get { return mHasCoordinateOperation; } set { mHasCoordinateOperation = value; if (value.mSourceCRS != mIndex) value.SourceCRS = this; } }

		protected IfcCoordinateReferenceSystem() : base() { }
		protected IfcCoordinateReferenceSystem(DatabaseIfc db, IfcCoordinateReferenceSystem p) : base(db,p) { mName = p.mName; mDescription = p.mDescription; mGeodeticDatum = p.mGeodeticDatum; mVerticalDatum = p.mVerticalDatum; }
		protected IfcCoordinateReferenceSystem(DatabaseIfc db, string name) : base(db) { Name = name; }
		protected static void parseFields(IfcCoordinateReferenceSystem o, List<string> arrFields, ref int ipos)
		{
			o.mName = arrFields[ipos++].Replace("'","");
			o.mDescription = arrFields[ipos++].Replace("'", "");
			o.mGeodeticDatum = arrFields[ipos++].Replace("'", "");
			o.mVerticalDatum = arrFields[ipos++].Replace("'", "");
		}
		protected override string BuildStringSTEP()
		{
			return base.BuildStringSTEP() + (mName == "$" ? ",$," : ",'" + mName + "',") + (mDescription == "$" ? "$,'" : "'" + mDescription + "','") +
				mGeodeticDatum + (mVerticalDatum == "$" ? "',$" : "','" + mVerticalDatum + "'");
		}
	}
	public interface IfcCoordinateReferenceSystemSelect : IBaseClassIfc { IfcCoordinateOperation HasCoordinateOperation { get; set; } } // IfcCoordinateReferenceSystem, IfcGeometricRepresentationContext
	public partial class IfcCostItem : IfcControl
	{
		internal IfcCostItemTypeEnum mPredefinedType = IfcCostItemTypeEnum.NOTDEFINED; // IFC4
		internal List<int> mCostValues = new List<int>();//	 : OPTIONAL LIST [1:?] OF IfcCostValue; IFC4
		internal List<int> mCostQuantities = new List<int>();//	 : OPTIONAL LIST [1:?] OF IfcPhysicalQuantity; IFC4

		public IfcCostItemTypeEnum PredefinedType { get { return mPredefinedType; } set { mPredefinedType = value; } }

		internal IfcCostItem() : base() { } 
		internal IfcCostItem(DatabaseIfc db, IfcCostItem i) : base(db,i) { mPredefinedType = i.mPredefinedType; }
		internal IfcCostItem( IfcCostSchedule s, List<IfcCostValue> values, List<IfcPhysicalQuantity> quants)
			: this(s.mDatabase, values, quants) { s.AddAggregated(this); }
		internal IfcCostItem(IfcCostItem i, List<IfcCostValue> values, List<IfcPhysicalQuantity> quants)
			: this(i.mDatabase, values, quants) { i.AddNested(this); }
		internal IfcCostItem(DatabaseIfc m, List<IfcCostValue> values, List<IfcPhysicalQuantity> quants) : base(m)
		{ 
			if (values != null && values.Count > 0)
				mCostValues = values.ConvertAll(x => x.mIndex);
			if (quants != null && quants.Count > 0)
				mCostQuantities = quants.ConvertAll(x => x.mIndex);
		}
		internal static IfcCostItem Parse(string strDef, ReleaseVersion schema) { IfcCostItem c = new IfcCostItem(); int ipos = 0; parseFields(c, ParserSTEP.SplitLineFields(strDef), ref ipos,schema); return c; }
		internal static void parseFields(IfcCostItem c, List<string> arrFields, ref int ipos, ReleaseVersion schema)  
		{ 
			IfcControl.parseFields(c, arrFields, ref ipos,schema);
			if (schema != ReleaseVersion.IFC2x3)
			{
				string s = arrFields[ipos++];
				if (s.StartsWith("."))
					c.mPredefinedType = (IfcCostItemTypeEnum)Enum.Parse(typeof(IfcCostItemTypeEnum), s.Replace(".", ""));
				s = arrFields[ipos++];
				if(s != "$")
					c.mCostValues = ParserSTEP.SplitListLinks(s);
				s = arrFields[ipos++];
				if(s != "$")
					c.mCostQuantities = ParserSTEP.SplitListLinks(s);
			}
		}
		protected override string BuildStringSTEP()
		{
			string s = base.BuildStringSTEP();
			if (mDatabase.mRelease != ReleaseVersion.IFC2x3)
			{
				s += ",." + mPredefinedType.ToString();
				if (mCostValues.Count == 0)
					s += ".,$,";
				else
				{
					s += ".,(" + ParserSTEP.LinkToString(mCostValues[0]);
					for (int icounter = 1; icounter < mCostValues.Count; icounter++)
						s += "," + ParserSTEP.LinkToString(mCostValues[icounter]);
					s += "),";
				}
				if (mCostQuantities.Count == 0)
					s += "$";
				else
				{
					s += "(" + ParserSTEP.LinkToString(mCostQuantities[0]);
					for (int icounter = 1; icounter < mCostQuantities.Count; icounter++)
						s += "," + ParserSTEP.LinkToString(mCostQuantities[icounter]);
					s += ")";
				}
			}
			return s;
		}
	}
	public partial class IfcCostSchedule : IfcControl
	{
		internal IfcCostScheduleTypeEnum mPredefinedType = IfcCostScheduleTypeEnum.NOTDEFINED;// :	OPTIONAL IfcCostScheduleTypeEnum; IFC4 relocated
		internal string mStatus = "$";// : OPTIONAL IfcLabel; IFC4 relocated
		internal string mSubmittedOn = "$";// : OPTIONAL IfcDateTime; IFC4 relocated  : 	OPTIONAL IfcDateTimeSelect in control
		internal string mUpdateDate = "$";// : OPTIONAL IfcDateTime; IFC4 relocated 
		private int mSubmittedBy;// : OPTIONAL IfcActorSelect; IFC4 DELETED 
		private int mPreparedBy;// : OPTIONAL IfcActorSelect; IFC4 DELETED 
		private List< int> mTargetUsers = new List<int>();// : OPTIONAL SET [1:?] OF IfcActorSelect; //IFC4 DELETED 
		//internal string mID;// : IfcIdentifier; IFC4 relocated 
		public IfcCostScheduleTypeEnum PredefinedType { get { return mPredefinedType; } set { mPredefinedType = value; } }
		public string Staus { get { return (mStatus == "$" ? "" : ParserIfc.Decode( mStatus)); } set { mStatus = (string.IsNullOrEmpty(value) ? "$" : ParserIfc.Encode( value.Replace("'",""))); } }

		internal IfcCostSchedule() : base() { }
		internal IfcCostSchedule(DatabaseIfc db, IfcCostSchedule s) : base(db,s)
		{
			mSubmittedBy = s.mSubmittedBy;
			mPreparedBy = s.mPreparedBy;
			mSubmittedBy = s.mSubmittedBy;
			mStatus = s.mStatus;
			//mTargetUsers = new List<int>( s.mTargetUsers.ToArray());
			mUpdateDate = s.mUpdateDate; 
			mPredefinedType = s.mPredefinedType;
		}
		internal IfcCostSchedule(DatabaseIfc m, IfcCostScheduleTypeEnum t, string status, DateTime submitted, IfcProject prj)
			: base(m) 
		{
			mPredefinedType = t;
			if (!string.IsNullOrEmpty(status)) 
				mStatus = status.Replace("'", "");
			if (submitted != DateTime.MinValue)
				mSubmittedOn = (m.mRelease == ReleaseVersion.IFC2x3 ? "#" + new IfcDateAndTime(new IfcCalendarDate(m,submitted.Day,submitted.Month,submitted.Year),new IfcLocalTime(m,submitted.Hour,submitted.Minute,submitted.Second)).mIndex : IfcDateTime.Convert(  submitted));// IfcDate.convert(submitted); 
			mUpdateDate = IfcDate.convert(DateTime.Now); 
			if (prj != null) 
				prj.AddDeclared(this);
		}
		internal static IfcCostSchedule Parse(string strDef) { IfcCostSchedule c = new IfcCostSchedule(); int ipos = 0; parseFields(c, ParserSTEP.SplitLineFields(strDef), ref ipos); return c; }
		internal static void parseFields(IfcCostSchedule c,List<string> arrFields, ref int ipos,ReleaseVersion schema)
		{  
			IfcControl.parseFields(c,arrFields, ref ipos,schema);
			if(schema == ReleaseVersion.IFC2x3)
			{
				c.mSubmittedBy = ParserSTEP.ParseLink(arrFields[ipos++]); 
				c.mPreparedBy = ParserSTEP.ParseLink(arrFields[ipos++]);
				c.mSubmittedOn = arrFields[ipos++]; 
				c.mStatus = arrFields[ipos++].Replace("'",""); 
				c.mTargetUsers = ParserSTEP.SplitListLinks(arrFields[ipos++]); 
				c.mUpdateDate = arrFields[ipos++]; 
				c.mIdentification = arrFields[ipos++].Replace("'", "");
				c.mPredefinedType = (IfcCostScheduleTypeEnum)Enum.Parse(typeof(IfcCostScheduleTypeEnum), arrFields[ipos++].Replace(".", ""));
			}
			else
			{
				c.mPredefinedType = (IfcCostScheduleTypeEnum)Enum.Parse(typeof(IfcCostScheduleTypeEnum), arrFields[ipos++].Replace(".", ""));
				c.mStatus = arrFields[ipos++].Replace("'", "");
				c.mSubmittedOn = arrFields[ipos++];
				c.mUpdateDate = arrFields[ipos++]; 
			}
		}
		protected override string BuildStringSTEP()
		{
			if (mDatabase.mRelease == ReleaseVersion.IFC2x3)
			{
				string str = base.BuildStringSTEP() + "," + ParserSTEP.LinkToString(mSubmittedBy) + "," + ParserSTEP.LinkToString(mPreparedBy) + "," + mSubmittedOn + "," + mStatus;
				if (mTargetUsers.Count > 0)
				{
					str += ",(" + ParserSTEP.LinkToString(mTargetUsers[0]);
					for (int icounter = 1; icounter < mTargetUsers.Count; icounter++)
						str += "," + ParserSTEP.LinkToString(mTargetUsers[icounter]);
					str += "),";
				}
				else
					str += ",$,";
				return str + mUpdateDate + (mIdentification == "$" ? ",$,." : ",'" + mIdentification + "',.") + mPredefinedType.ToString() + ".";
			}
			return base.BuildStringSTEP() + ",." + mPredefinedType.ToString() + (mStatus == "$" ? ".,$," : ".,'" + mStatus + "',") + mSubmittedOn + "," + mUpdateDate;
		}
	}
	public partial class IfcCostValue : IfcAppliedValue
	{
		//internal string mCostType;// : IfcLabel;  IFC4 renamed to category
		//internal string mCondition = "$";//  : OPTIONAL IfcText; IFC4 moved to condition
		internal IfcCostValue() : base() { }
		internal IfcCostValue(DatabaseIfc db, IfcCostValue v) : base(db,v) { }
		internal new static IfcCostValue Parse(string strDef, ReleaseVersion schema) { IfcCostValue v = new IfcCostValue(); int ipos = 0; parseFields(v, ParserSTEP.SplitLineFields(strDef), ref ipos, schema); return v; }
		internal static void parseFields(IfcCostValue v, List<string> arrFields, ref int ipos, ReleaseVersion schema) { IfcAppliedValue.parseFields(v, arrFields, ref ipos, schema); if (schema == ReleaseVersion.IFC2x3) { v.mCategory = arrFields[ipos++].Replace("'", ""); v.mCondition = arrFields[ipos++].Replace("'", ""); } }
		protected override string BuildStringSTEP() { return base.BuildStringSTEP() + (mDatabase.mRelease == ReleaseVersion.IFC2x3 ? (mCategory == "$" ? ",$," : ",'" + mCategory + "',") + (mCondition == "$" ? "$" : "'" + mCondition + "'") : ""); }
	}
	public partial class IfcCovering : IfcBuildingElement
	{
		internal IfcCoveringTypeEnum mPredefinedType = IfcCoveringTypeEnum.NOTDEFINED;// : OPTIONAL IfcCoveringTypeEnum;
		//INVERSE
		internal IfcRelCoversSpaces mCoversSpaces = null;//	 : 	SET [0:1] OF IfcRelCoversSpaces FOR RelatedCoverings;
		internal IfcRelCoversBldgElements mCoversElements = null;//	 : 	SET [0:1] OF IfcRelCoversBldgElements FOR RelatedCoverings;

		public IfcCoveringTypeEnum PredefinedType { get { return mPredefinedType; } set { mPredefinedType = value; } }
		
		internal IfcCovering() : base() { }
		internal IfcCovering(DatabaseIfc db, IfcCovering c) : base(db, c) { mPredefinedType = c.mPredefinedType; }
		public IfcCovering(IfcObjectDefinition host, IfcObjectPlacement placement, IfcProductRepresentation representation) : base(host, placement, representation) { }
		 
		internal static IfcCovering Parse(string str) { IfcCovering c = new IfcCovering(); int pos = 0; c.Parse(str,ref pos, str.Length); return c; }
		protected override void Parse(string str, ref int pos, int len)
		{
			base.Parse(str, ref pos, len);
			string s = ParserSTEP.StripField(str, ref pos, len);
			if (s.StartsWith("."))
			{
				try { mPredefinedType = (IfcCoveringTypeEnum)Enum.Parse(typeof(IfcCoveringTypeEnum), s.Replace(".", "")); } catch (Exception) { }
			}
		}
		protected override string BuildStringSTEP() { return base.BuildStringSTEP() + "," + (mPredefinedType == IfcCoveringTypeEnum.NOTDEFINED ? "$" : "." + mPredefinedType.ToString() + "."); }
	}
	public partial class IfcCoveringType : IfcBuildingElementType
	{
		internal IfcCoveringTypeEnum mPredefinedType = IfcCoveringTypeEnum.NOTDEFINED;
		public IfcCoveringTypeEnum PredefinedType { get { return mPredefinedType; } set { mPredefinedType = value; } }

		internal IfcCoveringType() : base() { }
		internal IfcCoveringType(DatabaseIfc db, IfcCoveringType t) : base(db,t) { mPredefinedType = t.mPredefinedType; }
		public IfcCoveringType(DatabaseIfc m, string name, IfcCoveringTypeEnum type) : base(m) { Name = name; mPredefinedType = type; } 

		internal static void parseFields(IfcCoveringType e, List<string> arrFields, ref int ipos) { IfcBuildingElementType.parseFields(e, arrFields, ref ipos); try { e.mPredefinedType = (IfcCoveringTypeEnum)Enum.Parse(typeof(IfcCoveringTypeEnum), arrFields[ipos++].Replace(".", "")); } catch (Exception) { } }
		internal new static IfcCoveringType Parse(string strDef) { IfcCoveringType t = new IfcCoveringType(); int ipos = 0; parseFields(t, ParserSTEP.SplitLineFields(strDef), ref ipos); return t; }
		protected override string BuildStringSTEP() { return base.BuildStringSTEP() + ",." + mPredefinedType.ToString() + "."; }
	}
	public partial class IfcCraneRailAShapeProfileDef : IfcParameterizedProfileDef
	{
		internal double mOverallHeight, mBaseWidth2;// : IfcPositiveLengthMeasure;
		internal double mRadius;// : OPTIONAL IfcPositiveLengthMeasure;
		internal double mHeadWidth, mHeadDepth2, mHeadDepth3, mWebThickness, mBaseWidth4, mBaseDepth1, mBaseDepth2, mBaseDepth3;// : IfcPositiveLengthMeasure;
		internal double mCentreOfGravityInY;// : OPTIONAL IfcPositiveLengthMeasure; 
		internal IfcCraneRailAShapeProfileDef() : base() { }
		internal IfcCraneRailAShapeProfileDef(DatabaseIfc db, IfcCraneRailAShapeProfileDef p) : base(db, p)
		{
			mOverallHeight = p.mOverallHeight; mBaseWidth2 = p.mBaseWidth2; mRadius = p.mRadius; mHeadWidth = p.mHeadWidth; mHeadDepth2 = p.mHeadDepth2;
			mHeadDepth3 = p.mHeadDepth3; mWebThickness = p.mWebThickness; mBaseWidth4 = p.mBaseWidth4; mBaseDepth1 = p.mBaseDepth1;
			mBaseDepth2 = p.mBaseDepth2; mBaseDepth3 = p.mBaseDepth3; mCentreOfGravityInY = p.mCentreOfGravityInY;
		}
		internal static void parseFields(IfcCraneRailAShapeProfileDef p, List<string> arrFields, ref int ipos)
		{
			IfcParameterizedProfileDef.parseFields(p, arrFields, ref ipos); p.mOverallHeight = ParserSTEP.ParseDouble(arrFields[ipos++]);
			p.mBaseWidth2 = ParserSTEP.ParseDouble(arrFields[ipos++]); p.mRadius = ParserSTEP.ParseDouble(arrFields[ipos++]);
			p.mHeadWidth = ParserSTEP.ParseDouble(arrFields[ipos++]); p.mHeadDepth2 = ParserSTEP.ParseDouble(arrFields[ipos++]);
			p.mHeadDepth3 = ParserSTEP.ParseDouble(arrFields[ipos++]); p.mWebThickness = ParserSTEP.ParseDouble(arrFields[ipos++]);
			p.mBaseWidth4 = ParserSTEP.ParseDouble(arrFields[ipos++]); p.mBaseDepth1 = ParserSTEP.ParseDouble(arrFields[ipos++]);
			p.mBaseDepth2 = ParserSTEP.ParseDouble(arrFields[ipos++]); p.mBaseDepth3 = ParserSTEP.ParseDouble(arrFields[ipos++]);
			p.mCentreOfGravityInY = ParserSTEP.ParseDouble(arrFields[ipos++]);
		}
		internal new static IfcCraneRailAShapeProfileDef Parse(string strDef) { IfcCraneRailAShapeProfileDef p = new IfcCraneRailAShapeProfileDef(); int ipos = 0; parseFields(p, ParserSTEP.SplitLineFields(strDef), ref ipos); return p; }
		protected override string BuildStringSTEP() { return base.BuildStringSTEP() + "," + ParserSTEP.DoubleToString(mOverallHeight) + "," + ParserSTEP.DoubleToString(mBaseWidth2) + "," + ParserSTEP.DoubleOptionalToString(mRadius) + "," + ParserSTEP.DoubleToString(mHeadWidth) + "," + ParserSTEP.DoubleToString(mHeadDepth2) + "," + ParserSTEP.DoubleToString(mHeadDepth3) + "," + ParserSTEP.DoubleToString(mWebThickness) + "," + ParserSTEP.DoubleToString(mBaseDepth1) + "," + ParserSTEP.DoubleToString(mBaseDepth2) + "," + ParserSTEP.DoubleToString(mBaseDepth3) + "," + ParserSTEP.DoubleOptionalToString(mCentreOfGravityInY); }
	}
	public partial class IfcCraneRailFShapeProfileDef : IfcParameterizedProfileDef
	{
		internal double mOverallHeight, mHeadWidth;// : IfcPositiveLengthMeasure;
		internal double mRadius;// : OPTIONAL IfcPositiveLengthMeasure;
		internal double mHeadDepth2, mHeadDepth3, mWebThickness, mBaseDepth1, mBaseDepth2;// : IfcPositiveLengthMeasure;
		internal double mCentreOfGravityInY;// : OPTIONAL IfcPositiveLengthMeasure; 
		internal IfcCraneRailFShapeProfileDef() : base() { }
		internal IfcCraneRailFShapeProfileDef(DatabaseIfc db, IfcCraneRailFShapeProfileDef p)
			: base(db, p)
		{
			mOverallHeight = p.mOverallHeight; mHeadWidth = p.mHeadWidth; mRadius = p.mRadius; mHeadDepth2 = p.mHeadDepth2; mHeadDepth3 = p.mHeadDepth3;
			mWebThickness = p.mWebThickness; mBaseDepth1 = p.mBaseDepth1; mBaseDepth2 = p.mBaseDepth2; mCentreOfGravityInY = p.mCentreOfGravityInY;
		}
		internal static void parseFields(IfcCraneRailFShapeProfileDef p, List<string> arrFields, ref int ipos)
		{
			IfcParameterizedProfileDef.parseFields(p, arrFields, ref ipos); p.mOverallHeight = ParserSTEP.ParseDouble(arrFields[ipos++]);
			p.mHeadWidth = ParserSTEP.ParseDouble(arrFields[ipos++]); p.mRadius = ParserSTEP.ParseDouble(arrFields[ipos++]);
			p.mHeadDepth2 = ParserSTEP.ParseDouble(arrFields[ipos++]); p.mHeadDepth3 = ParserSTEP.ParseDouble(arrFields[ipos++]);
			p.mWebThickness = ParserSTEP.ParseDouble(arrFields[ipos++]); p.mBaseDepth1 = ParserSTEP.ParseDouble(arrFields[ipos++]);
			p.mBaseDepth2 = ParserSTEP.ParseDouble(arrFields[ipos++]); p.mCentreOfGravityInY = ParserSTEP.ParseDouble(arrFields[ipos++]);
		}
		internal new static IfcCraneRailFShapeProfileDef Parse(string strDef) { IfcCraneRailFShapeProfileDef p = new IfcCraneRailFShapeProfileDef(); int ipos = 0; parseFields(p, ParserSTEP.SplitLineFields(strDef), ref ipos); return p; }
		protected override string BuildStringSTEP() { return base.BuildStringSTEP() + "," + ParserSTEP.DoubleToString(mOverallHeight) + "," + ParserSTEP.DoubleToString(mHeadWidth) + "," + ParserSTEP.DoubleOptionalToString(mRadius) + "," + ParserSTEP.DoubleToString(mHeadDepth2) + "," + ParserSTEP.DoubleToString(mHeadDepth3) + "," + ParserSTEP.DoubleToString(mWebThickness) + "," + ParserSTEP.DoubleToString(mBaseDepth1) + "," + ParserSTEP.DoubleToString(mBaseDepth2) + "," + ParserSTEP.DoubleOptionalToString(mCentreOfGravityInY); }
	} 
	public partial class IfcCrewResource : IfcConstructionResource
	{
		internal IfcCrewResourceTypeEnum mPredefinedType = IfcCrewResourceTypeEnum.NOTDEFINED;// OPTIONAL : IfcCrewResourceTypeEnum; 
		public IfcCrewResourceTypeEnum PredefinedType { get { return mPredefinedType; } set { mPredefinedType = value; } }

		internal IfcCrewResource() : base() { }
		internal IfcCrewResource(DatabaseIfc db, IfcCrewResource r) : base(db,r) { mPredefinedType = r.mPredefinedType; }
		internal IfcCrewResource(DatabaseIfc db) : base(db) { }
		internal static IfcCrewResource Parse(string strDef, ReleaseVersion schema) { IfcCrewResource r = new IfcCrewResource(); int ipos = 0; parseFields(r, ParserSTEP.SplitLineFields(strDef), ref ipos,schema); return r; }
		internal static void parseFields(IfcCrewResource r, List<string> arrFields, ref int ipos,ReleaseVersion schema)
		{
			IfcConstructionResource.parseFields(r, arrFields, ref ipos,schema);
			if (schema != ReleaseVersion.IFC2x3)
			{
				string str = arrFields[ipos++];
				if (str[0] == '.')
					r.mPredefinedType = (IfcCrewResourceTypeEnum)Enum.Parse(typeof(IfcCrewResourceTypeEnum), str.Substring(1, str.Length - 2));
			}
		}
		protected override string BuildStringSTEP() { return base.BuildStringSTEP() + ",." + mPredefinedType.ToString() + "."; }
	}
	public partial class IfcCrewResourceType : IfcConstructionResourceType //IFC4
	{
		internal IfcCrewResourceTypeEnum mPredefinedType = IfcCrewResourceTypeEnum.NOTDEFINED;
		public IfcCrewResourceTypeEnum PredefinedType { get { return mPredefinedType; } set { mPredefinedType = value; } }

		internal IfcCrewResourceType() : base() { }
		internal IfcCrewResourceType(DatabaseIfc db, IfcCrewResourceType t) : base(db, t) { mPredefinedType = t.mPredefinedType; }
		internal IfcCrewResourceType(DatabaseIfc m, string name, IfcCrewResourceTypeEnum type) : base(m) { Name = name; mPredefinedType = type; }
		internal static void parseFields(IfcCrewResourceType t, List<string> arrFields, ref int ipos) { IfcCrewResourceType.parseFields(t, arrFields, ref ipos); t.mPredefinedType = (IfcCrewResourceTypeEnum)Enum.Parse(typeof(IfcCrewResourceTypeEnum), arrFields[ipos++].Replace(".", "")); }
		internal new static IfcCrewResourceType Parse(string strDef) { IfcCrewResourceType t = new IfcCrewResourceType(); int ipos = 0; parseFields(t, ParserSTEP.SplitLineFields(strDef), ref ipos); return t; }
		protected override string BuildStringSTEP() { return base.BuildStringSTEP() + ",." + mPredefinedType.ToString() + "."; }
	}
	public abstract partial class IfcCsgPrimitive3D : IfcGeometricRepresentationItem, IfcBooleanOperand, IfcCsgSelect /*ABSTRACT SUPERTYPE OF (ONEOF (IfcBlock ,IfcRectangularPyramid ,IfcRightCircularCone ,IfcRightCircularCylinder ,IfcSphere))*/
	{
		private int mPosition;// : IfcAxis2Placement3D;
		public IfcAxis2Placement3D Position { get { return mDatabase[mPosition] as IfcAxis2Placement3D; } set { mPosition = value.mIndex; } }

		protected IfcCsgPrimitive3D() : base() { }
		protected IfcCsgPrimitive3D(IfcAxis2Placement3D position) :base (position.mDatabase) { Position = position; }
		protected IfcCsgPrimitive3D(DatabaseIfc db, IfcCsgPrimitive3D p) : base(db,p) { Position = db.Factory.Duplicate(p.Position) as IfcAxis2Placement3D; }
		protected virtual void Parse(string str, ref int pos, int len) { mPosition = ParserSTEP.StripLink(str, ref pos, len); }
		protected override string BuildStringSTEP() { return base.BuildStringSTEP() + "," + ParserSTEP.LinkToString(mPosition); }
	}
	public partial interface IfcCsgSelect : IBaseClassIfc { } //	IfcBooleanResult, IfcCsgPrimitive3D
	public partial class IfcCsgSolid : IfcSolidModel
	{
		private int mTreeRootExpression;// : IfcCsgSelect

		public IfcCsgSelect TreeRootExpression { get { return mDatabase[mTreeRootExpression] as IfcCsgSelect; } set { mTreeRootExpression = value.Index; } }

		internal IfcCsgSolid() : base() { }
		internal IfcCsgSolid(DatabaseIfc db, IfcCsgSolid p) : base(db,p) { TreeRootExpression = db.Factory.Duplicate(p.mDatabase[ p.mTreeRootExpression]) as IfcCsgSelect; }
		public IfcCsgSolid(IfcCsgSelect csg)
			: base(csg.Database)
		{
			if (mDatabase.mModelView != ModelView.Ifc4NotAssigned && mDatabase.mModelView != ModelView.If2x3NotAssigned && mDatabase.mModelView != ModelView.Ifc4DesignTransfer)
				throw new Exception("Invalid Model View for IfcCsgSolid : " + mDatabase.ModelView.ToString());
			TreeRootExpression = csg;
		}
		internal static IfcCsgSolid Parse(string str) { IfcCsgSolid s = new IfcCsgSolid(); int pos = 0; s.mTreeRootExpression = ParserSTEP.StripLink(str, ref pos, str.Length); return s; }
		protected override string BuildStringSTEP() { return base.BuildStringSTEP() + "," + ParserSTEP.LinkToString(mTreeRootExpression); }
	}
	public partial class IfcCShapeProfileDef : IfcParameterizedProfileDef
	{
		internal double mDepth, mWidth, mWallThickness, mGirth;// : IfcPositiveLengthMeasure;
		internal double mInternalFilletRadius = double.NaN;// : OPTIONAL IfcPositiveLengthMeasure;
		internal double mCentreOfGravityInX = double.NaN;// : OPTIONAL IfcPositiveLengthMeasure // DELETED IFC4 	Superseded by respective attribute of IfcStructuralProfileProperties 

		public double Depth { get { return mDepth; } set { mDepth = value; } }
		public double Width { get { return mWidth; } set { mWidth = value; } }
		public double WallThickness { get { return mWallThickness; } set { mWallThickness = value; } }
		public double Girth { get { return mGirth; } set { mGirth = value; } }
		public double InternalFilletRadius { get { return mInternalFilletRadius; } set { mInternalFilletRadius = (value < mDatabase.Tolerance ? double.NaN : value); } }
		
		internal IfcCShapeProfileDef() : base() { }
		internal IfcCShapeProfileDef(DatabaseIfc db, IfcCShapeProfileDef c) : base(db, c)
		{
			mDepth = c.mDepth;
			mWidth = c.mWidth;
			mWallThickness = c.mWallThickness;
			mGirth = c.mGirth;
			mInternalFilletRadius = c.mInternalFilletRadius;
			mCentreOfGravityInX = c.mCentreOfGravityInX;
		}
		public IfcCShapeProfileDef(DatabaseIfc db, string name, double depth, double width, double wallThickness, double girth)
			: base(db,name) { mDepth = depth; mWidth = width; mWallThickness = wallThickness; mGirth = girth; }
		
		internal static void parseFields(IfcCShapeProfileDef p, List<string> arrFields, ref int ipos, ReleaseVersion schema)
		{
			IfcParameterizedProfileDef.parseFields(p, arrFields, ref ipos);
			p.mDepth = ParserSTEP.ParseDouble(arrFields[ipos++]);
			p.mWidth = ParserSTEP.ParseDouble(arrFields[ipos++]);
			p.mWallThickness = ParserSTEP.ParseDouble(arrFields[ipos++]);
			p.mGirth = ParserSTEP.ParseDouble(arrFields[ipos++]);
			p.mInternalFilletRadius = ParserSTEP.ParseDouble(arrFields[ipos++]);
			if(schema == ReleaseVersion.IFC2x3)
				p.mCentreOfGravityInX = ParserSTEP.ParseDouble(arrFields[ipos++]);
		}
		internal static IfcCShapeProfileDef Parse(string strDef, ReleaseVersion schema) { IfcCShapeProfileDef p = new IfcCShapeProfileDef(); int ipos = 0; parseFields(p, ParserSTEP.SplitLineFields(strDef), ref ipos, schema); return p; }
		protected override string BuildStringSTEP() { return base.BuildStringSTEP() + "," + ParserSTEP.DoubleToString(mDepth) + "," + ParserSTEP.DoubleToString(mWidth) + "," + ParserSTEP.DoubleToString(mWallThickness) + "," + ParserSTEP.DoubleToString(mGirth) + "," + ParserSTEP.DoubleOptionalToString(mInternalFilletRadius) + (mDatabase.mRelease == ReleaseVersion.IFC2x3 ? "," + ParserSTEP.DoubleOptionalToString(mCentreOfGravityInX) : ""); }
	}
	//ENTITY IfcCurrencyRelationship; 
	public partial class IfcCurtainWall : IfcBuildingElement
	{
		internal IfcCurtainWallTypeEnum mPredefinedType = IfcCurtainWallTypeEnum.NOTDEFINED;//: OPTIONAL IfcCurtainWallTypeEnum; 
		public IfcCurtainWallTypeEnum PredefinedType { get { return mPredefinedType; } set { mPredefinedType = value; } }

		internal IfcCurtainWall() : base() { }
		internal IfcCurtainWall(DatabaseIfc db, IfcCurtainWall w) : base(db, w) { mPredefinedType = w.mPredefinedType; }
		public IfcCurtainWall(IfcObjectDefinition host, IfcObjectPlacement placement, IfcProductRepresentation representation) : base(host, placement, representation) { }
		 
		internal static IfcCurtainWall Parse(string str, ReleaseVersion schema) { IfcCurtainWall w = new IfcCurtainWall(); int pos = 0; w.Parse(str, ref pos, str.Length, schema); return w; }
		protected void Parse(string str, ref int pos, int len, ReleaseVersion schema)
		{
			base.Parse(str, ref pos, len);
			if (schema != ReleaseVersion.IFC2x3)
			{
				string s = ParserSTEP.StripField(str, ref pos, len);
				if (s[0] == '.')
					mPredefinedType = (IfcCurtainWallTypeEnum)Enum.Parse(typeof(IfcCurtainWallTypeEnum), s.Substring(1, s.Length - 2));
			}
		}
		protected override string BuildStringSTEP() { return (mDatabase.mRelease == ReleaseVersion.IFC2x3 ? base.BuildStringSTEP() : base.BuildStringSTEP() + ",." + mPredefinedType.ToString() + "."); }
	}
	public partial class IfcCurtainWallType : IfcBuildingElementType
	{
		internal IfcCurtainWallTypeEnum mPredefinedType = IfcCurtainWallTypeEnum.NOTDEFINED;
		public IfcCurtainWallTypeEnum PredefinedType { get { return mPredefinedType; } set { mPredefinedType = value; } }

		internal IfcCurtainWallType() : base() { }
		internal IfcCurtainWallType(DatabaseIfc db, IfcCurtainWallType t) : base(db,t) { mPredefinedType = t.mPredefinedType; }
		public IfcCurtainWallType(DatabaseIfc m, string name, IfcCurtainWallTypeEnum type) : base(m) { Name = name; mPredefinedType = type; }
		internal static void parseFields(IfcCurtainWallType t, List<string> arrFields, ref int ipos) { IfcBuildingElementType.parseFields(t, arrFields, ref ipos); t.mPredefinedType = (IfcCurtainWallTypeEnum)Enum.Parse(typeof(IfcCurtainWallTypeEnum), arrFields[ipos++].Replace(".", "")); }
		internal new static IfcCurtainWallType Parse(string strDef) { IfcCurtainWallType t = new IfcCurtainWallType(); int ipos = 0; parseFields(t, ParserSTEP.SplitLineFields(strDef), ref ipos); return t; }
		protected override string BuildStringSTEP() { return base.BuildStringSTEP() + ",." + mPredefinedType.ToString() + "."; }
	}
	public abstract partial class IfcCurve : IfcGeometricRepresentationItem, IfcGeometricSetSelect /*ABSTRACT SUPERTYPE OF (ONEOF (IfcBoundedCurve ,IfcConic ,IfcLine ,IfcOffsetCurve2D ,IfcOffsetCurve3D,IfcPcurve,IfcClothoid))*/
	{   //INVERSE GeomGym
		internal IfcEdgeCurve mEdge = null;

		protected IfcCurve() : base() { }
		protected IfcCurve(DatabaseIfc db) : base(db) { }
		protected IfcCurve(DatabaseIfc db, IfcCurve c) : base(db,c) { }
	}
	public partial class IfcCurveBoundedPlane : IfcBoundedSurface
	{
		internal int mBasisSurface;// : IfcPlane;
		internal int mOuterBoundary;// : IfcCurve;
		internal List<int> mInnerBoundaries = new List<int>();//: SET OF IfcCurve;

		public IfcPlane BasisSurface { get { return mDatabase[mBasisSurface] as IfcPlane; } set { mBasisSurface = value.mIndex; } }
		public IfcCurve OuterBoundary { get { return mDatabase[mOuterBoundary] as IfcCurve; } set { mOuterBoundary = value.mIndex; } }
		public List<IfcCurve> InnerBoundaries { get { return mInnerBoundaries.ConvertAll(x => mDatabase[x] as IfcCurve); } set { mInnerBoundaries = (value == null ? new List<int>() : value.ConvertAll(x => x.mIndex)); } }

		internal IfcCurveBoundedPlane() : base() { }
		internal IfcCurveBoundedPlane(DatabaseIfc db, IfcCurveBoundedPlane p) : base(db,p) { BasisSurface = db.Factory.Duplicate( p.BasisSurface) as IfcPlane; OuterBoundary = db.Factory.Duplicate(p.OuterBoundary) as IfcCurve; InnerBoundaries = p.InnerBoundaries.ConvertAll(x=>db.Factory.Duplicate(x) as IfcCurve); }
		public IfcCurveBoundedPlane(IfcPlane p, IfcCurve outer) : base(p.mDatabase) { BasisSurface = p; OuterBoundary = outer;  }
		public IfcCurveBoundedPlane(IfcPlane p, IfcCurve outer, List<IfcCurve> inner)
			: this(p, outer) { InnerBoundaries = inner; }
		internal static IfcCurveBoundedPlane Parse(string str)
		{
			IfcCurveBoundedPlane p = new IfcCurveBoundedPlane();
			int pos = 0, len = str.Length;
			p.mBasisSurface = ParserSTEP.StripLink(str, ref pos, len);
			p.mOuterBoundary = ParserSTEP.StripLink(str, ref pos, len);
			p.mInnerBoundaries = ParserSTEP.StripListLink(str, ref pos, len);
			return p;
		}
		protected override string BuildStringSTEP()
		{
			string str = ",(";
			if (mInnerBoundaries.Count > 0)
			{
				str += "#" + mInnerBoundaries[0];
				for (int icounter = 1; icounter < mInnerBoundaries.Count; icounter++)
					str += ",#" + mInnerBoundaries[icounter];
			}
			return base.BuildStringSTEP() + "," + ParserSTEP.LinkToString(mBasisSurface) + "," + ParserSTEP.LinkToString(mOuterBoundary) + (mInnerBoundaries.Count > 0 || mDatabase.mRelease == ReleaseVersion.IFC2x3 ? str + ")" : ",$" );
		}
	}
	public partial class IfcCurveBoundedSurface : IfcBoundedSurface //IFC4
	{
		private int mBasisSurface;// : IfcSurface; 
		private List<int> mBoundaries = new List<int>();//: SET [1:?] OF IfcBoundaryCurve;
		private bool mImplicitOuter = false;//	 :	BOOLEAN; 

		public IfcSurface BasisSurface { get { return mDatabase[mBasisSurface] as IfcSurface; } set { mBasisSurface = value.mIndex; } }
		public List<IfcBoundaryCurve> Boundaries { get { return mBoundaries.ConvertAll(x => mDatabase[x] as IfcBoundaryCurve); } set { mBoundaries = value.ConvertAll(x => x.mIndex); } }
		public bool ImplicitOuter { get { return mImplicitOuter; } }

		internal IfcCurveBoundedSurface() : base() { }
		internal IfcCurveBoundedSurface(DatabaseIfc db, IfcCurveBoundedSurface s) : base(db,s) { BasisSurface = db.Factory.Duplicate( s.BasisSurface) as IfcSurface; Boundaries = s.Boundaries.ConvertAll(x => db.Factory.Duplicate(x) as IfcBoundaryCurve); mImplicitOuter = s.mImplicitOuter; }
		internal IfcCurveBoundedSurface(DatabaseIfc m, IfcSurface s, List<IfcBoundaryCurve> bounds)
			: base(m) { mBasisSurface = s.mIndex; mBoundaries = bounds.ConvertAll(x => x.mIndex); mImplicitOuter = false; }

		internal static IfcCurveBoundedSurface Parse(string str)
		{
			IfcCurveBoundedSurface p = new IfcCurveBoundedSurface();
			int pos = 0, len = str.Length;
			p.mBasisSurface = ParserSTEP.StripLink(str, ref pos, len);
			p.mBoundaries = ParserSTEP.StripListLink(str, ref pos, len);
			p.mImplicitOuter = ParserSTEP.StripBool(str,ref pos,len);
			return p;
		}
		protected override string BuildStringSTEP() { return base.BuildStringSTEP() + "," + ParserSTEP.LinkToString(mBasisSurface) + "," + ParserSTEP.ListLinksToString(mBoundaries) + (mImplicitOuter ? ",.T." : ",.F."); }
	}
	public interface IfcCurveOrEdgeCurve : IBaseClassIfc { }  // = SELECT (	IfcBoundedCurve, IfcEdgeCurve);
	public partial class IfcCurveStyle : IfcPresentationStyle, IfcPresentationStyleSelect
	{
		internal int mCurveFont;// : OPTIONAL IfcCurveFontOrScaledCurveFontSelect;
		internal IfcSizeSelect mCurveWidth = null;// : OPTIONAL IfcSizeSelect; 
		internal int mCurveColour;// : OPTIONAL IfcColour;
		internal IfcLogicalEnum mModelOrDraughting = IfcLogicalEnum.UNKNOWN;//	:	OPTIONAL BOOLEAN; IFC4 

		public IfcCurveFontOrScaledCurveFontSelect CurveFont { get { return mDatabase[mCurveFont] as IfcCurveFontOrScaledCurveFontSelect; } set { mCurveFont = (value == null ? 0 : value.Index); } }
		public IfcSizeSelect CurveWidth { get { return mCurveWidth; } set { mCurveWidth = value; } }
		public IfcColour CurveColour { get { return mDatabase[mCurveColour] as IfcColour; } set { mCurveColour = (value == null ? 0 : value.Index); } }
		public bool ModelOrDraughting { get { return mModelOrDraughting == IfcLogicalEnum.TRUE; } set { mModelOrDraughting = value ? IfcLogicalEnum.TRUE : IfcLogicalEnum.FALSE; } }
		internal IfcCurveStyle() : base() { }
		internal IfcCurveStyle(DatabaseIfc db, IfcCurveStyle s) : base(db,s)
		{
			CurveFont = db.Factory.Duplicate(s.mDatabase[s.mCurveFont]) as IfcCurveFontOrScaledCurveFontSelect;
			mCurveWidth = s.mCurveWidth;
			CurveColour = db.Factory.Duplicate(s.mDatabase[s.mCurveColour]) as IfcColour;
			mModelOrDraughting = s.mModelOrDraughting;
		}
		internal IfcCurveStyle(DatabaseIfc m, string name, IfcCurveFontOrScaledCurveFontSelect font, IfcSizeSelect width, IfcColour col)
			: base(m, name) { if (font != null) mCurveFont = font.Index; mCurveWidth = width; if (col != null) mCurveColour = col.Index; }
		internal static void parseFields(IfcCurveStyle s, List<string> arrFields, ref int ipos, ReleaseVersion schema)
		{
			IfcPresentationStyle.parseFields(s, arrFields, ref ipos);
			s.mCurveFont = ParserSTEP.ParseLink(arrFields[ipos++]);
			string str = arrFields[ipos++];
			if(str != "$")
				s.mCurveWidth = ParserIfc.parseValue(str) as IfcSizeSelect;
			s.mCurveColour = ParserSTEP.ParseLink(arrFields[ipos++]);
			if (schema != ReleaseVersion.IFC2x3)
				s.mModelOrDraughting =  ParserIfc.ParseIFCLogical(arrFields[ipos++]);
		}
		internal static IfcCurveStyle Parse(string strDef, ReleaseVersion schema) { IfcCurveStyle s = new IfcCurveStyle(); int ipos = 0; parseFields(s, ParserSTEP.SplitLineFields(strDef), ref ipos, schema); return s; }
		protected override string BuildStringSTEP()
		{
			return base.BuildStringSTEP() + "," + ParserSTEP.LinkToString(mCurveFont) + (mCurveWidth == null ? ",$," : "," + mCurveWidth.ToString() + ",") + ParserSTEP.LinkToString(mCurveColour) + (mDatabase.mRelease != ReleaseVersion.IFC2x3 ? (mModelOrDraughting == IfcLogicalEnum.UNKNOWN ? ",$" : ","+ ParserIfc.LogicalToString(mModelOrDraughting)) :"") ;
		}

	}
	public partial class IfcCurveStyleFont : IfcPresentationItem, IfcCurveStyleFontSelect
	{
		internal string mName = "$";// : OPTIONAL IfcLabel;
		internal List<int> mPatternList = new List<int>();// :  LIST [1:?] OF IfcCurveStyleFontPattern;

		public override string Name { get { return (mName == "$" ? "" : ParserIfc.Decode(mName)); } set { if (!string.IsNullOrEmpty(value)) mName = ParserIfc.Encode(value); } }

		internal IfcCurveStyleFont() : base() { }
		//internal IfcCurveStyleFont(DatabaseIfc db, IfcCurveStyleFont v) : base(db,v) { mName = v.mName; mPatternList = new List<int>(v.mPatternList.ToArray()); }
		internal static void parseFields(IfcCurveStyleFont s, List<string> arrFields, ref int ipos) { s.mName = arrFields[ipos++]; s.mPatternList = ParserSTEP.SplitListLinks(arrFields[ipos++]); }
		internal static IfcCurveStyleFont Parse(string strDef) { IfcCurveStyleFont s = new IfcCurveStyleFont(); int ipos = 0; parseFields(s, ParserSTEP.SplitLineFields(strDef), ref ipos); return s; }
		protected override string BuildStringSTEP()
		{
			string str = base.BuildStringSTEP() + "," + mName + ",(" + ParserSTEP.LinkToString(mPatternList[0]);
			for (int icounter = 0; icounter < mPatternList.Count; icounter++)
				str += "," + ParserSTEP.LinkToString(mPatternList[icounter]);
			return str + ")";
		}
	}
	public partial class IfcCurveStyleFontAndScaling : IfcPresentationItem, IfcCurveFontOrScaledCurveFontSelect
	{
		internal string mName; // : 	OPTIONAL IfcLabel;
		internal int mCurveFont;// : 	IfcCurveStyleFontSelect;
		internal IfcPositiveRatioMeasure mCurveFontScaling;//: 	IfcPositiveRatioMeasure;
		internal IfcCurveStyleFontAndScaling() : base() { }
	//	internal IfcCurveStyleFontAndScaling(IfcCurveStyleFontAndScaling i) : base() { mName = i.mName; mCurveFont = i.mCurveFont; mCurveFontScaling = i.mCurveFontScaling; }
		internal static IfcCurveStyleFontAndScaling Parse(string strDef) { IfcCurveStyleFontAndScaling s = new IfcCurveStyleFontAndScaling(); int ipos = 0; parseFields(s, ParserSTEP.SplitLineFields(strDef), ref ipos); return s; }
		internal static void parseFields(IfcCurveStyleFontAndScaling s, List<string> arrFields, ref int ipos) { s.mName = arrFields[ipos++].Replace("'", ""); s.mCurveFont = ParserSTEP.ParseLink(arrFields[ipos++]); s.mCurveFontScaling = new IfcPositiveRatioMeasure(arrFields[ipos++]); }
		protected override string BuildStringSTEP() { return ",'" + mName + "'," + ParserSTEP.LinkToString(mCurveFont) + "," + mCurveFontScaling.ToString(); }
	}
	public interface IfcCurveFontOrScaledCurveFontSelect : IBaseClassIfc { } //SELECT (IfcCurveStyleFontAndScaling ,IfcCurveStyleFontSelect);
	public partial class IfcCurveStyleFontPattern : IfcPresentationItem
	{
		internal double mVisibleSegmentLength;// : IfcLengthMeasure;
		internal double mInvisibleSegmentLength;//: IfcPositiveLengthMeasure;	
		internal IfcCurveStyleFontPattern() : base() { }
	//	internal IfcCurveStyleFontPattern(IfcCurveStyleFontPattern i) : base() { mVisibleSegmentLength = i.mVisibleSegmentLength; mInvisibleSegmentLength = i.mInvisibleSegmentLength; }
		internal static IfcCurveStyleFontPattern Parse(string strDef) { IfcCurveStyleFontPattern c = new IfcCurveStyleFontPattern(); int ipos = 0; parseFields(c, ParserSTEP.SplitLineFields(strDef), ref ipos); return c; }
		internal static void parseFields(IfcCurveStyleFontPattern c, List<string> arrFields, ref int ipos) { c.mVisibleSegmentLength = ParserSTEP.ParseDouble(arrFields[ipos++]); c.mInvisibleSegmentLength = ParserSTEP.ParseDouble(arrFields[ipos++]); }
		protected override string BuildStringSTEP() { return base.BuildStringSTEP() + "," + ParserSTEP.DoubleToString(mVisibleSegmentLength) + "," + ParserSTEP.DoubleToString(mInvisibleSegmentLength); }
	}
	public interface IfcCurveStyleFontSelect : IfcCurveFontOrScaledCurveFontSelect { } //SELECT (IfcCurveStyleFont ,IfcPreDefinedCurveFont);
	public partial class IfcCylindricalSurface : IfcElementarySurface //IFC4
	{
		private double mRadius;// : IfcPositiveLengthMeasure;
		public double Radius { get { return mRadius; } set { mRadius = value; } }

		internal IfcCylindricalSurface() : base() { }
		internal IfcCylindricalSurface(DatabaseIfc db, IfcCylindricalSurface s) : base(db,s) { mRadius = s.mRadius; }
		public IfcCylindricalSurface(IfcAxis2Placement3D placement) : base(placement) { }
		internal static IfcCylindricalSurface Parse(string str) { IfcCylindricalSurface s = new IfcCylindricalSurface(); int pos = 0; s.Parse(str,ref pos, str.Length); return s; }
		protected override void Parse(string str, ref int pos, int len)
		{
			base.Parse(str, ref pos, len);
			mRadius = ParserSTEP.StripDouble(str, ref pos, len);
		}

		protected override string BuildStringSTEP() { return  base.BuildStringSTEP() + "," + ParserSTEP.DoubleToString(mRadius); }
	}
}
