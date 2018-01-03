﻿using System;
using System.Diagnostics;
using Elasticsearch.Net;
using Newtonsoft.Json;

namespace Nest
{
	[JsonConverter(typeof(IdJsonConverter))]
	[DebuggerDisplay("{DebugDisplay,nq}")]
	public class Routing : IEquatable<Routing>, IUrlParameter
	{
		internal object Value { get; set; }
		internal object Document { get; }
		internal Func<object> DocumentGetter { get; }

		public Routing(Func<object> documentGetter) { DocumentGetter = documentGetter; }
		public Routing(string id) { Value = id; }
		public Routing(long id) { Value = id; }
		public Routing(object document) { Document = document; }

		public static implicit operator Routing(string id) => new Routing(id);
		public static implicit operator Routing(long id) => new Routing(id);
		public static implicit operator Routing(Guid id) => new Routing(id.ToString("D"));

		public static Routing From<T>(T document) where T : class => new Routing(document);

		private string DebugDisplay => Value?.ToString() ?? "Routing from instance typeof: " + Document?.GetType().Name;

		string IUrlParameter.GetString(IConnectionConfigurationValues settings)
		{
			var nestSettings = settings as IConnectionSettingsValues;
			return GetString(nestSettings);
		}

		private string GetString(IConnectionSettingsValues nestSettings)
		{
			if (this.Document != null)
				Value = nestSettings.Inferrer.JoinRouting(this.Document);

			var s = Value as string;
			return s ?? this.Value?.ToString();
		}

		public bool Equals(Routing other)
		{
			if (ReferenceEquals(null, other)) return false;
			if (ReferenceEquals(this, other)) return true;
			return Equals(Value, other.Value) && Equals(Document, other.Document);
		}

		public override bool Equals(object obj)
		{
			if (ReferenceEquals(null, obj)) return false;
			if (ReferenceEquals(this, obj)) return true;
			return obj.GetType() == this.GetType() && Equals((Routing)obj);
		}

		public override int GetHashCode()
		{
			unchecked
			{
				return ((Value?.GetHashCode() ?? 0) * 397) ^ (Document?.GetHashCode() ?? 0);
			}
		}

		public static bool operator ==(Routing left, Routing right)
		{
			return Equals(left, right);
		}

		public static bool operator !=(Routing left, Routing right)
		{
			return !Equals(left, right);
		}
	}
}
