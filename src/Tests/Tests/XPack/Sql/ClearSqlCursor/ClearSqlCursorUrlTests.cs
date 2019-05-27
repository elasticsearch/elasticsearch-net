﻿using System.Threading.Tasks;
using Elastic.Xunit.XunitPlumbing;
using Nest;
using Tests.Framework;

namespace Tests.XPack.Sql.ClearSqlCursor
{
	public class ClearSqlCursorUrlTests : UrlTestsBase
	{
		[U] public override async Task Urls() => await UrlTester.POST("_sql/close")
			.Fluent(c => c.Sql.ClearCursor(d => d))
			.Request(c => c.Sql.ClearCursor(new ClearSqlCursorRequest()))
			.FluentAsync(c => c.Sql.ClearCursorAsync(d => d))
			.RequestAsync(c => c.Sql.ClearCursorAsync(new ClearSqlCursorRequest()));
	}
}
