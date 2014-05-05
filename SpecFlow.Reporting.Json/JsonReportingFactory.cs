﻿namespace SpecFlow.Reporting.Json
{
	public class JsonReportingFactory : ReportingFactory
	{
		public override string Name
		{
			get { return "SpecFlow.Reporting.Json"; }
		}

		public override IReport DoCreateReport()
		{
			return new JsonReport();
		}
	}
}