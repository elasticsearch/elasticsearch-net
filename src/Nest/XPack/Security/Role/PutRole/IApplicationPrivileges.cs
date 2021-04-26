/*
 * Licensed to Elasticsearch B.V. under one or more contributor
 * license agreements. See the NOTICE file distributed with
 * this work for additional information regarding copyright
 * ownership. Elasticsearch B.V. licenses this file to you under
 * the Apache License, Version 2.0 (the "License"); you may
 * not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *    http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing,
 * software distributed under the License is distributed on an
 * "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY
 * KIND, either express or implied.  See the License for the
 * specific language governing permissions and limitations
 * under the License.
 */

using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Nest
{
	/// <summary>
	/// Privileges for an application
	/// </summary>
	[ReadAs(typeof(ApplicationPrivileges))]
	public interface IApplicationPrivileges
	{
		/// <summary>
		/// The name of the application to which this entry applies
		/// </summary>
		[DataMember(Name ="application")]
		string Application { get; set; }

		/// <summary>
		/// A list of strings, where each element is the name of an application privilege or action.
		/// </summary>
		[DataMember(Name ="privileges")]
		IEnumerable<string> Privileges { get; set; }

		/// <summary>
		/// A list resources to which the privileges are applied.
		/// </summary>
		[DataMember(Name ="resources")]
		IEnumerable<string> Resources { get; set; }
	}

	/// <inheritdoc />
	public class ApplicationPrivileges : IApplicationPrivileges
	{
		/// <inheritdoc />
		public string Application { get; set; }

		/// <inheritdoc />
		public IEnumerable<string> Privileges { get; set; }

		/// <inheritdoc />
		public IEnumerable<string> Resources { get; set; }
	}

	public class ApplicationPrivilegesListDescriptor : DescriptorPromiseBase<ApplicationPrivilegesListDescriptor, IList<IApplicationPrivileges>>
	{
		public ApplicationPrivilegesListDescriptor() : base(new List<IApplicationPrivileges>()) { }

		/// <summary>
		/// Adds an application privilege
		/// </summary>
		public ApplicationPrivilegesListDescriptor Add(Func<ApplicationPrivilegesDescriptor, IApplicationPrivileges> selector) =>
			Assign(selector, (a, v) => a.AddIfNotNull(v?.Invoke(new ApplicationPrivilegesDescriptor())));
	}

	/// <inheritdoc cref="IApplicationPrivileges" />
	public class ApplicationPrivilegesDescriptor
		: DescriptorBase<ApplicationPrivilegesDescriptor, IApplicationPrivileges>, IApplicationPrivileges
	{
		/// <inheritdoc />
		string IApplicationPrivileges.Application { get; set; }

		/// <inheritdoc />
		IEnumerable<string> IApplicationPrivileges.Privileges { get; set; }

		/// <inheritdoc />
		IEnumerable<string> IApplicationPrivileges.Resources { get; set; }

		/// <inheritdoc cref="IApplicationPrivileges.Application" />
		public ApplicationPrivilegesDescriptor Application(string application) => Assign(application, (a, v) => a.Application = v);

		/// <inheritdoc cref="IApplicationPrivileges.Privileges" />
		public ApplicationPrivilegesDescriptor Privileges(params string[] privileges) => Assign(privileges, (a, v) => a.Privileges = v);

		/// <inheritdoc cref="IApplicationPrivileges.Privileges" />
		public ApplicationPrivilegesDescriptor Privileges(IEnumerable<string> privileges) => Assign(privileges, (a, v) => a.Privileges = v);

		/// <inheritdoc cref="IApplicationPrivileges.Resources" />
		public ApplicationPrivilegesDescriptor Resources(params string[] resources) => Assign(resources, (a, v) => a.Resources = v);

		/// <inheritdoc cref="IApplicationPrivileges.Resources" />
		public ApplicationPrivilegesDescriptor Resources(IEnumerable<string> resources) => Assign(resources, (a, v) => a.Resources = v);
	}
}
