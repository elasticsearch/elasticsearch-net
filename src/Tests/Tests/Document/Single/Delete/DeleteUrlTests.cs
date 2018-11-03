﻿using System.Threading.Tasks;
using Elastic.Xunit.XunitPlumbing;
using Nest;
using Tests.Domain;
using Tests.Framework;
using static Tests.Framework.UrlTester;

namespace Tests.Document.Single.Delete
{
	public class DeleteUrlTests
	{
		[U] public async Task Urls() => await DELETE("/project/doc/1")
			.Fluent(c => c.Delete<Project>(1))
			.Request(c => c.Delete(new DeleteRequest<Project>(1)))
			.FluentAsync(c => c.DeleteAsync<Project>(1))
			.RequestAsync(c => c.DeleteAsync(new DeleteRequest<Project>(1)));
	}
}
