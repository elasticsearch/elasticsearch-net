// Licensed to Elasticsearch B.V under one or more agreements.
// Elasticsearch B.V licenses this file to you under the Apache 2.0 License.
// See the LICENSE file in the project root for more information.
//
// ███╗   ██╗ ██████╗ ████████╗██╗ ██████╗███████╗
// ████╗  ██║██╔═══██╗╚══██╔══╝██║██╔════╝██╔════╝
// ██╔██╗ ██║██║   ██║   ██║   ██║██║     █████╗
// ██║╚██╗██║██║   ██║   ██║   ██║██║     ██╔══╝
// ██║ ╚████║╚██████╔╝   ██║   ██║╚██████╗███████╗
// ╚═╝  ╚═══╝ ╚═════╝    ╚═╝   ╚═╝ ╚═════╝╚══════╝
// ------------------------------------------------
//
// This file is automatically generated.
// Please do not edit these files manually.
// Run the following in the root of the repository:
//
// ------------------------------------------------

using System;
using System.Text.Json.Serialization;
using Elastic.Transport;

#nullable restore
namespace Nest
{
	[JsonConverter(typeof(StringAliasConverter<AggregateName>))]
	public readonly partial struct AggregateName : IComparable<AggregateName>, IEquatable<AggregateName>
	{
		public AggregateName(string aggregateName) => Value = aggregateName;
		public string Value { get; }

		public override int GetHashCode() => Value.GetHashCode();
		public override string ToString() => Value;
		public override bool Equals(object obj) => ReferenceEquals(null, obj) ? false : obj is AggregateName other && Equals(other);
		public bool Equals(AggregateName other) => this.Value.Equals(other.Value);
		public int CompareTo(AggregateName other) => Value.CompareTo(other.Value);
		public static bool operator ==(AggregateName a, AggregateName b) => a.CompareTo(b) == 0;
		public static bool operator !=(AggregateName a, AggregateName b) => !(a == b);
		public static implicit operator string(AggregateName aggregateName) => aggregateName.Value;
		public static implicit operator AggregateName(string aggregateName) => new(aggregateName);
		public static bool TryParse(string value, out AggregateName aggregateName)
		{
			aggregateName = default;
			if (string.IsNullOrWhiteSpace(value))
				return false;
			aggregateName = new AggregateName(value.Trim());
			return true;
		}
	}

	[JsonConverter(typeof(StringAliasConverter<CategoryId>))]
	public readonly partial struct CategoryId : IComparable<CategoryId>, IEquatable<CategoryId>
	{
		public CategoryId(string categoryId) => Value = categoryId;
		public string Value { get; }

		public override int GetHashCode() => Value.GetHashCode();
		public override string ToString() => Value;
		public override bool Equals(object obj) => ReferenceEquals(null, obj) ? false : obj is CategoryId other && Equals(other);
		public bool Equals(CategoryId other) => this.Value.Equals(other.Value);
		public int CompareTo(CategoryId other) => Value.CompareTo(other.Value);
		public static bool operator ==(CategoryId a, CategoryId b) => a.CompareTo(b) == 0;
		public static bool operator !=(CategoryId a, CategoryId b) => !(a == b);
		public static implicit operator string(CategoryId categoryId) => categoryId.Value;
		public static implicit operator CategoryId(string categoryId) => new(categoryId);
		public static bool TryParse(string value, out CategoryId categoryId)
		{
			categoryId = default;
			if (string.IsNullOrWhiteSpace(value))
				return false;
			categoryId = new CategoryId(value.Trim());
			return true;
		}
	}

	[JsonConverter(typeof(StringAliasConverter<DataStreamName>))]
	public readonly partial struct DataStreamName : IComparable<DataStreamName>, IEquatable<DataStreamName>, IUrlParameter
	{
		public DataStreamName(string dataStreamName) => Value = dataStreamName;
		public string Value { get; }

		public override int GetHashCode() => Value.GetHashCode();
		public override string ToString() => Value;
		public override bool Equals(object obj) => ReferenceEquals(null, obj) ? false : obj is DataStreamName other && Equals(other);
		public bool Equals(DataStreamName other) => this.Value.Equals(other.Value);
		public int CompareTo(DataStreamName other) => Value.CompareTo(other.Value);
		public static bool operator ==(DataStreamName a, DataStreamName b) => a.CompareTo(b) == 0;
		public static bool operator !=(DataStreamName a, DataStreamName b) => !(a == b);
		public static implicit operator string(DataStreamName dataStreamName) => dataStreamName.Value;
		public static implicit operator DataStreamName(string dataStreamName) => new(dataStreamName);
		public static bool TryParse(string value, out DataStreamName dataStreamName)
		{
			dataStreamName = default;
			if (string.IsNullOrWhiteSpace(value))
				return false;
			dataStreamName = new DataStreamName(value.Trim());
			return true;
		}

		public string GetString(ITransportConfiguration settings) => Value;
	}

	[JsonConverter(typeof(StringAliasConverter<DateFormat>))]
	public readonly partial struct DateFormat : IComparable<DateFormat>, IEquatable<DateFormat>
	{
		public DateFormat(string dateFormat) => Value = dateFormat;
		public string Value { get; }

		public override int GetHashCode() => Value.GetHashCode();
		public override string ToString() => Value;
		public override bool Equals(object obj) => ReferenceEquals(null, obj) ? false : obj is DateFormat other && Equals(other);
		public bool Equals(DateFormat other) => this.Value.Equals(other.Value);
		public int CompareTo(DateFormat other) => Value.CompareTo(other.Value);
		public static bool operator ==(DateFormat a, DateFormat b) => a.CompareTo(b) == 0;
		public static bool operator !=(DateFormat a, DateFormat b) => !(a == b);
		public static implicit operator string(DateFormat dateFormat) => dateFormat.Value;
		public static implicit operator DateFormat(string dateFormat) => new(dateFormat);
		public static bool TryParse(string value, out DateFormat dateFormat)
		{
			dateFormat = default;
			if (string.IsNullOrWhiteSpace(value))
				return false;
			dateFormat = new DateFormat(value.Trim());
			return true;
		}
	}

	[JsonConverter(typeof(StringAliasConverter<DateMath>))]
	public readonly partial struct DateMath : IComparable<DateMath>, IEquatable<DateMath>
	{
		public DateMath(string dateMath) => Value = dateMath;
		public string Value { get; }

		public override int GetHashCode() => Value.GetHashCode();
		public override string ToString() => Value;
		public override bool Equals(object obj) => ReferenceEquals(null, obj) ? false : obj is DateMath other && Equals(other);
		public bool Equals(DateMath other) => this.Value.Equals(other.Value);
		public int CompareTo(DateMath other) => Value.CompareTo(other.Value);
		public static bool operator ==(DateMath a, DateMath b) => a.CompareTo(b) == 0;
		public static bool operator !=(DateMath a, DateMath b) => !(a == b);
		public static implicit operator string(DateMath dateMath) => dateMath.Value;
		public static implicit operator DateMath(string dateMath) => new(dateMath);
		public static bool TryParse(string value, out DateMath dateMath)
		{
			dateMath = default;
			if (string.IsNullOrWhiteSpace(value))
				return false;
			dateMath = new DateMath(value.Trim());
			return true;
		}
	}

	[JsonConverter(typeof(StringAliasConverter<DateMathTime>))]
	public readonly partial struct DateMathTime : IComparable<DateMathTime>, IEquatable<DateMathTime>
	{
		public DateMathTime(string dateMathTime) => Value = dateMathTime;
		public string Value { get; }

		public override int GetHashCode() => Value.GetHashCode();
		public override string ToString() => Value;
		public override bool Equals(object obj) => ReferenceEquals(null, obj) ? false : obj is DateMathTime other && Equals(other);
		public bool Equals(DateMathTime other) => this.Value.Equals(other.Value);
		public int CompareTo(DateMathTime other) => Value.CompareTo(other.Value);
		public static bool operator ==(DateMathTime a, DateMathTime b) => a.CompareTo(b) == 0;
		public static bool operator !=(DateMathTime a, DateMathTime b) => !(a == b);
		public static implicit operator string(DateMathTime dateMathTime) => dateMathTime.Value;
		public static implicit operator DateMathTime(string dateMathTime) => new(dateMathTime);
		public static bool TryParse(string value, out DateMathTime dateMathTime)
		{
			dateMathTime = default;
			if (string.IsNullOrWhiteSpace(value))
				return false;
			dateMathTime = new DateMathTime(value.Trim());
			return true;
		}
	}

	[JsonConverter(typeof(StringAliasConverter<DateString>))]
	public readonly partial struct DateString : IComparable<DateString>, IEquatable<DateString>
	{
		public DateString(string dateString) => Value = dateString;
		public string Value { get; }

		public override int GetHashCode() => Value.GetHashCode();
		public override string ToString() => Value;
		public override bool Equals(object obj) => ReferenceEquals(null, obj) ? false : obj is DateString other && Equals(other);
		public bool Equals(DateString other) => this.Value.Equals(other.Value);
		public int CompareTo(DateString other) => Value.CompareTo(other.Value);
		public static bool operator ==(DateString a, DateString b) => a.CompareTo(b) == 0;
		public static bool operator !=(DateString a, DateString b) => !(a == b);
		public static implicit operator string(DateString dateString) => dateString.Value;
		public static implicit operator DateString(string dateString) => new(dateString);
		public static bool TryParse(string value, out DateString dateString)
		{
			dateString = default;
			if (string.IsNullOrWhiteSpace(value))
				return false;
			dateString = new DateString(value.Trim());
			return true;
		}
	}

	[JsonConverter(typeof(StringAliasConverter<Distance>))]
	public readonly partial struct Distance : IComparable<Distance>, IEquatable<Distance>
	{
		public Distance(string distance) => Value = distance;
		public string Value { get; }

		public override int GetHashCode() => Value.GetHashCode();
		public override string ToString() => Value;
		public override bool Equals(object obj) => ReferenceEquals(null, obj) ? false : obj is Distance other && Equals(other);
		public bool Equals(Distance other) => this.Value.Equals(other.Value);
		public int CompareTo(Distance other) => Value.CompareTo(other.Value);
		public static bool operator ==(Distance a, Distance b) => a.CompareTo(b) == 0;
		public static bool operator !=(Distance a, Distance b) => !(a == b);
		public static implicit operator string(Distance distance) => distance.Value;
		public static implicit operator Distance(string distance) => new(distance);
		public static bool TryParse(string value, out Distance distance)
		{
			distance = default;
			if (string.IsNullOrWhiteSpace(value))
				return false;
			distance = new Distance(value.Trim());
			return true;
		}
	}

	[JsonConverter(typeof(StringAliasConverter<Host>))]
	public readonly partial struct Host : IComparable<Host>, IEquatable<Host>
	{
		public Host(string host) => Value = host;
		public string Value { get; }

		public override int GetHashCode() => Value.GetHashCode();
		public override string ToString() => Value;
		public override bool Equals(object obj) => ReferenceEquals(null, obj) ? false : obj is Host other && Equals(other);
		public bool Equals(Host other) => this.Value.Equals(other.Value);
		public int CompareTo(Host other) => Value.CompareTo(other.Value);
		public static bool operator ==(Host a, Host b) => a.CompareTo(b) == 0;
		public static bool operator !=(Host a, Host b) => !(a == b);
		public static implicit operator string(Host host) => host.Value;
		public static implicit operator Host(string host) => new(host);
		public static bool TryParse(string value, out Host host)
		{
			host = default;
			if (string.IsNullOrWhiteSpace(value))
				return false;
			host = new Host(value.Trim());
			return true;
		}
	}

	[JsonConverter(typeof(StringAliasConverter<IndexAlias>))]
	public readonly partial struct IndexAlias : IComparable<IndexAlias>, IEquatable<IndexAlias>
	{
		public IndexAlias(string indexAlias) => Value = indexAlias;
		public string Value { get; }

		public override int GetHashCode() => Value.GetHashCode();
		public override string ToString() => Value;
		public override bool Equals(object obj) => ReferenceEquals(null, obj) ? false : obj is IndexAlias other && Equals(other);
		public bool Equals(IndexAlias other) => this.Value.Equals(other.Value);
		public int CompareTo(IndexAlias other) => Value.CompareTo(other.Value);
		public static bool operator ==(IndexAlias a, IndexAlias b) => a.CompareTo(b) == 0;
		public static bool operator !=(IndexAlias a, IndexAlias b) => !(a == b);
		public static implicit operator string(IndexAlias indexAlias) => indexAlias.Value;
		public static implicit operator IndexAlias(string indexAlias) => new(indexAlias);
		public static bool TryParse(string value, out IndexAlias indexAlias)
		{
			indexAlias = default;
			if (string.IsNullOrWhiteSpace(value))
				return false;
			indexAlias = new IndexAlias(value.Trim());
			return true;
		}
	}

	[JsonConverter(typeof(StringAliasConverter<IndexPattern>))]
	public readonly partial struct IndexPattern : IComparable<IndexPattern>, IEquatable<IndexPattern>
	{
		public IndexPattern(string indexPattern) => Value = indexPattern;
		public string Value { get; }

		public override int GetHashCode() => Value.GetHashCode();
		public override string ToString() => Value;
		public override bool Equals(object obj) => ReferenceEquals(null, obj) ? false : obj is IndexPattern other && Equals(other);
		public bool Equals(IndexPattern other) => this.Value.Equals(other.Value);
		public int CompareTo(IndexPattern other) => Value.CompareTo(other.Value);
		public static bool operator ==(IndexPattern a, IndexPattern b) => a.CompareTo(b) == 0;
		public static bool operator !=(IndexPattern a, IndexPattern b) => !(a == b);
		public static implicit operator string(IndexPattern indexPattern) => indexPattern.Value;
		public static implicit operator IndexPattern(string indexPattern) => new(indexPattern);
		public static bool TryParse(string value, out IndexPattern indexPattern)
		{
			indexPattern = default;
			if (string.IsNullOrWhiteSpace(value))
				return false;
			indexPattern = new IndexPattern(value.Trim());
			return true;
		}
	}

	[JsonConverter(typeof(StringAliasConverter<Ip>))]
	public readonly partial struct Ip : IComparable<Ip>, IEquatable<Ip>
	{
		public Ip(string ip) => Value = ip;
		public string Value { get; }

		public override int GetHashCode() => Value.GetHashCode();
		public override string ToString() => Value;
		public override bool Equals(object obj) => ReferenceEquals(null, obj) ? false : obj is Ip other && Equals(other);
		public bool Equals(Ip other) => this.Value.Equals(other.Value);
		public int CompareTo(Ip other) => Value.CompareTo(other.Value);
		public static bool operator ==(Ip a, Ip b) => a.CompareTo(b) == 0;
		public static bool operator !=(Ip a, Ip b) => !(a == b);
		public static implicit operator string(Ip ip) => ip.Value;
		public static implicit operator Ip(string ip) => new(ip);
		public static bool TryParse(string value, out Ip ip)
		{
			ip = default;
			if (string.IsNullOrWhiteSpace(value))
				return false;
			ip = new Ip(value.Trim());
			return true;
		}
	}

	[JsonConverter(typeof(StringAliasConverter<MultiTermQueryRewrite>))]
	public readonly partial struct MultiTermQueryRewrite : IComparable<MultiTermQueryRewrite>, IEquatable<MultiTermQueryRewrite>
	{
		public MultiTermQueryRewrite(string multiTermQueryRewrite) => Value = multiTermQueryRewrite;
		public string Value { get; }

		public override int GetHashCode() => Value.GetHashCode();
		public override string ToString() => Value;
		public override bool Equals(object obj) => ReferenceEquals(null, obj) ? false : obj is MultiTermQueryRewrite other && Equals(other);
		public bool Equals(MultiTermQueryRewrite other) => this.Value.Equals(other.Value);
		public int CompareTo(MultiTermQueryRewrite other) => Value.CompareTo(other.Value);
		public static bool operator ==(MultiTermQueryRewrite a, MultiTermQueryRewrite b) => a.CompareTo(b) == 0;
		public static bool operator !=(MultiTermQueryRewrite a, MultiTermQueryRewrite b) => !(a == b);
		public static implicit operator string(MultiTermQueryRewrite multiTermQueryRewrite) => multiTermQueryRewrite.Value;
		public static implicit operator MultiTermQueryRewrite(string multiTermQueryRewrite) => new(multiTermQueryRewrite);
		public static bool TryParse(string value, out MultiTermQueryRewrite multiTermQueryRewrite)
		{
			multiTermQueryRewrite = default;
			if (string.IsNullOrWhiteSpace(value))
				return false;
			multiTermQueryRewrite = new MultiTermQueryRewrite(value.Trim());
			return true;
		}
	}

	[JsonConverter(typeof(StringAliasConverter<Name>))]
	public readonly partial struct Name : IComparable<Name>, IEquatable<Name>, IUrlParameter
	{
		public Name(string name) => Value = name;
		public string Value { get; }

		public override int GetHashCode() => Value.GetHashCode();
		public override string ToString() => Value;
		public override bool Equals(object obj) => ReferenceEquals(null, obj) ? false : obj is Name other && Equals(other);
		public bool Equals(Name other) => this.Value.Equals(other.Value);
		public int CompareTo(Name other) => Value.CompareTo(other.Value);
		public static bool operator ==(Name a, Name b) => a.CompareTo(b) == 0;
		public static bool operator !=(Name a, Name b) => !(a == b);
		public static implicit operator string(Name name) => name.Value;
		public static implicit operator Name(string name) => new(name);
		public static bool TryParse(string value, out Name name)
		{
			name = default;
			if (string.IsNullOrWhiteSpace(value))
				return false;
			name = new Name(value.Trim());
			return true;
		}

		public string GetString(ITransportConfiguration settings) => Value;
	}

	[JsonConverter(typeof(StringAliasConverter<Namespace>))]
	public readonly partial struct Namespace : IComparable<Namespace>, IEquatable<Namespace>
	{
		public Namespace(string ns) => Value = ns;
		public string Value { get; }

		public override int GetHashCode() => Value.GetHashCode();
		public override string ToString() => Value;
		public override bool Equals(object obj) => ReferenceEquals(null, obj) ? false : obj is Namespace other && Equals(other);
		public bool Equals(Namespace other) => this.Value.Equals(other.Value);
		public int CompareTo(Namespace other) => Value.CompareTo(other.Value);
		public static bool operator ==(Namespace a, Namespace b) => a.CompareTo(b) == 0;
		public static bool operator !=(Namespace a, Namespace b) => !(a == b);
		public static implicit operator string(Namespace ns) => ns.Value;
		public static implicit operator Namespace(string ns) => new(ns);
		public static bool TryParse(string value, out Namespace ns)
		{
			ns = default;
			if (string.IsNullOrWhiteSpace(value))
				return false;
			ns = new Namespace(value.Trim());
			return true;
		}
	}

	[JsonConverter(typeof(StringAliasConverter<NodeId>))]
	public readonly partial struct NodeId : IComparable<NodeId>, IEquatable<NodeId>
	{
		public NodeId(string nodeId) => Value = nodeId;
		public string Value { get; }

		public override int GetHashCode() => Value.GetHashCode();
		public override string ToString() => Value;
		public override bool Equals(object obj) => ReferenceEquals(null, obj) ? false : obj is NodeId other && Equals(other);
		public bool Equals(NodeId other) => this.Value.Equals(other.Value);
		public int CompareTo(NodeId other) => Value.CompareTo(other.Value);
		public static bool operator ==(NodeId a, NodeId b) => a.CompareTo(b) == 0;
		public static bool operator !=(NodeId a, NodeId b) => !(a == b);
		public static implicit operator string(NodeId nodeId) => nodeId.Value;
		public static implicit operator NodeId(string nodeId) => new(nodeId);
		public static bool TryParse(string value, out NodeId nodeId)
		{
			nodeId = default;
			if (string.IsNullOrWhiteSpace(value))
				return false;
			nodeId = new NodeId(value.Trim());
			return true;
		}
	}

	[JsonConverter(typeof(StringAliasConverter<NodeName>))]
	public readonly partial struct NodeName : IComparable<NodeName>, IEquatable<NodeName>
	{
		public NodeName(string nodeName) => Value = nodeName;
		public string Value { get; }

		public override int GetHashCode() => Value.GetHashCode();
		public override string ToString() => Value;
		public override bool Equals(object obj) => ReferenceEquals(null, obj) ? false : obj is NodeName other && Equals(other);
		public bool Equals(NodeName other) => this.Value.Equals(other.Value);
		public int CompareTo(NodeName other) => Value.CompareTo(other.Value);
		public static bool operator ==(NodeName a, NodeName b) => a.CompareTo(b) == 0;
		public static bool operator !=(NodeName a, NodeName b) => !(a == b);
		public static implicit operator string(NodeName nodeName) => nodeName.Value;
		public static implicit operator NodeName(string nodeName) => new(nodeName);
		public static bool TryParse(string value, out NodeName nodeName)
		{
			nodeName = default;
			if (string.IsNullOrWhiteSpace(value))
				return false;
			nodeName = new NodeName(value.Trim());
			return true;
		}
	}

	[JsonConverter(typeof(StringAliasConverter<Password>))]
	public readonly partial struct Password : IComparable<Password>, IEquatable<Password>
	{
		public Password(string password) => Value = password;
		public string Value { get; }

		public override int GetHashCode() => Value.GetHashCode();
		public override string ToString() => Value;
		public override bool Equals(object obj) => ReferenceEquals(null, obj) ? false : obj is Password other && Equals(other);
		public bool Equals(Password other) => this.Value.Equals(other.Value);
		public int CompareTo(Password other) => Value.CompareTo(other.Value);
		public static bool operator ==(Password a, Password b) => a.CompareTo(b) == 0;
		public static bool operator !=(Password a, Password b) => !(a == b);
		public static implicit operator string(Password password) => password.Value;
		public static implicit operator Password(string password) => new(password);
		public static bool TryParse(string value, out Password password)
		{
			password = default;
			if (string.IsNullOrWhiteSpace(value))
				return false;
			password = new Password(value.Trim());
			return true;
		}
	}

	[JsonConverter(typeof(StringAliasConverter<PipelineName>))]
	public readonly partial struct PipelineName : IComparable<PipelineName>, IEquatable<PipelineName>
	{
		public PipelineName(string pipelineName) => Value = pipelineName;
		public string Value { get; }

		public override int GetHashCode() => Value.GetHashCode();
		public override string ToString() => Value;
		public override bool Equals(object obj) => ReferenceEquals(null, obj) ? false : obj is PipelineName other && Equals(other);
		public bool Equals(PipelineName other) => this.Value.Equals(other.Value);
		public int CompareTo(PipelineName other) => Value.CompareTo(other.Value);
		public static bool operator ==(PipelineName a, PipelineName b) => a.CompareTo(b) == 0;
		public static bool operator !=(PipelineName a, PipelineName b) => !(a == b);
		public static implicit operator string(PipelineName pipelineName) => pipelineName.Value;
		public static implicit operator PipelineName(string pipelineName) => new(pipelineName);
		public static bool TryParse(string value, out PipelineName pipelineName)
		{
			pipelineName = default;
			if (string.IsNullOrWhiteSpace(value))
				return false;
			pipelineName = new PipelineName(value.Trim());
			return true;
		}
	}

	[JsonConverter(typeof(StringAliasConverter<ScrollId>))]
	public readonly partial struct ScrollId : IComparable<ScrollId>, IEquatable<ScrollId>
	{
		public ScrollId(string scrollId) => Value = scrollId;
		public string Value { get; }

		public override int GetHashCode() => Value.GetHashCode();
		public override string ToString() => Value;
		public override bool Equals(object obj) => ReferenceEquals(null, obj) ? false : obj is ScrollId other && Equals(other);
		public bool Equals(ScrollId other) => this.Value.Equals(other.Value);
		public int CompareTo(ScrollId other) => Value.CompareTo(other.Value);
		public static bool operator ==(ScrollId a, ScrollId b) => a.CompareTo(b) == 0;
		public static bool operator !=(ScrollId a, ScrollId b) => !(a == b);
		public static implicit operator string(ScrollId scrollId) => scrollId.Value;
		public static implicit operator ScrollId(string scrollId) => new(scrollId);
		public static bool TryParse(string value, out ScrollId scrollId)
		{
			scrollId = default;
			if (string.IsNullOrWhiteSpace(value))
				return false;
			scrollId = new ScrollId(value.Trim());
			return true;
		}
	}

	[JsonConverter(typeof(StringAliasConverter<Service>))]
	public readonly partial struct Service : IComparable<Service>, IEquatable<Service>
	{
		public Service(string service) => Value = service;
		public string Value { get; }

		public override int GetHashCode() => Value.GetHashCode();
		public override string ToString() => Value;
		public override bool Equals(object obj) => ReferenceEquals(null, obj) ? false : obj is Service other && Equals(other);
		public bool Equals(Service other) => this.Value.Equals(other.Value);
		public int CompareTo(Service other) => Value.CompareTo(other.Value);
		public static bool operator ==(Service a, Service b) => a.CompareTo(b) == 0;
		public static bool operator !=(Service a, Service b) => !(a == b);
		public static implicit operator string(Service service) => service.Value;
		public static implicit operator Service(string service) => new(service);
		public static bool TryParse(string value, out Service service)
		{
			service = default;
			if (string.IsNullOrWhiteSpace(value))
				return false;
			service = new Service(value.Trim());
			return true;
		}
	}

	[JsonConverter(typeof(StringAliasConverter<SuggestionName>))]
	public readonly partial struct SuggestionName : IComparable<SuggestionName>, IEquatable<SuggestionName>
	{
		public SuggestionName(string suggestionName) => Value = suggestionName;
		public string Value { get; }

		public override int GetHashCode() => Value.GetHashCode();
		public override string ToString() => Value;
		public override bool Equals(object obj) => ReferenceEquals(null, obj) ? false : obj is SuggestionName other && Equals(other);
		public bool Equals(SuggestionName other) => this.Value.Equals(other.Value);
		public int CompareTo(SuggestionName other) => Value.CompareTo(other.Value);
		public static bool operator ==(SuggestionName a, SuggestionName b) => a.CompareTo(b) == 0;
		public static bool operator !=(SuggestionName a, SuggestionName b) => !(a == b);
		public static implicit operator string(SuggestionName suggestionName) => suggestionName.Value;
		public static implicit operator SuggestionName(string suggestionName) => new(suggestionName);
		public static bool TryParse(string value, out SuggestionName suggestionName)
		{
			suggestionName = default;
			if (string.IsNullOrWhiteSpace(value))
				return false;
			suggestionName = new SuggestionName(value.Trim());
			return true;
		}
	}

	[JsonConverter(typeof(StringAliasConverter<TimeZone>))]
	public readonly partial struct TimeZone : IComparable<TimeZone>, IEquatable<TimeZone>
	{
		public TimeZone(string timeZone) => Value = timeZone;
		public string Value { get; }

		public override int GetHashCode() => Value.GetHashCode();
		public override string ToString() => Value;
		public override bool Equals(object obj) => ReferenceEquals(null, obj) ? false : obj is TimeZone other && Equals(other);
		public bool Equals(TimeZone other) => this.Value.Equals(other.Value);
		public int CompareTo(TimeZone other) => Value.CompareTo(other.Value);
		public static bool operator ==(TimeZone a, TimeZone b) => a.CompareTo(b) == 0;
		public static bool operator !=(TimeZone a, TimeZone b) => !(a == b);
		public static implicit operator string(TimeZone timeZone) => timeZone.Value;
		public static implicit operator TimeZone(string timeZone) => new(timeZone);
		public static bool TryParse(string value, out TimeZone timeZone)
		{
			timeZone = default;
			if (string.IsNullOrWhiteSpace(value))
				return false;
			timeZone = new TimeZone(value.Trim());
			return true;
		}
	}

	[JsonConverter(typeof(StringAliasConverter<TransportAddress>))]
	public readonly partial struct TransportAddress : IComparable<TransportAddress>, IEquatable<TransportAddress>
	{
		public TransportAddress(string transportAddress) => Value = transportAddress;
		public string Value { get; }

		public override int GetHashCode() => Value.GetHashCode();
		public override string ToString() => Value;
		public override bool Equals(object obj) => ReferenceEquals(null, obj) ? false : obj is TransportAddress other && Equals(other);
		public bool Equals(TransportAddress other) => this.Value.Equals(other.Value);
		public int CompareTo(TransportAddress other) => Value.CompareTo(other.Value);
		public static bool operator ==(TransportAddress a, TransportAddress b) => a.CompareTo(b) == 0;
		public static bool operator !=(TransportAddress a, TransportAddress b) => !(a == b);
		public static implicit operator string(TransportAddress transportAddress) => transportAddress.Value;
		public static implicit operator TransportAddress(string transportAddress) => new(transportAddress);
		public static bool TryParse(string value, out TransportAddress transportAddress)
		{
			transportAddress = default;
			if (string.IsNullOrWhiteSpace(value))
				return false;
			transportAddress = new TransportAddress(value.Trim());
			return true;
		}
	}

	[JsonConverter(typeof(StringAliasConverter<DocType>))]
	public readonly partial struct DocType : IComparable<DocType>, IEquatable<DocType>
	{
		public DocType(string docType) => Value = docType;
		public string Value { get; }

		public override int GetHashCode() => Value.GetHashCode();
		public override string ToString() => Value;
		public override bool Equals(object obj) => ReferenceEquals(null, obj) ? false : obj is DocType other && Equals(other);
		public bool Equals(DocType other) => this.Value.Equals(other.Value);
		public int CompareTo(DocType other) => Value.CompareTo(other.Value);
		public static bool operator ==(DocType a, DocType b) => a.CompareTo(b) == 0;
		public static bool operator !=(DocType a, DocType b) => !(a == b);
		public static implicit operator string(DocType docType) => docType.Value;
		public static implicit operator DocType(string docType) => new(docType);
		public static bool TryParse(string value, out DocType docType)
		{
			docType = default;
			if (string.IsNullOrWhiteSpace(value))
				return false;
			docType = new DocType(value.Trim());
			return true;
		}
	}

	[JsonConverter(typeof(StringAliasConverter<Username>))]
	public readonly partial struct Username : IComparable<Username>, IEquatable<Username>
	{
		public Username(string username) => Value = username;
		public string Value { get; }

		public override int GetHashCode() => Value.GetHashCode();
		public override string ToString() => Value;
		public override bool Equals(object obj) => ReferenceEquals(null, obj) ? false : obj is Username other && Equals(other);
		public bool Equals(Username other) => this.Value.Equals(other.Value);
		public int CompareTo(Username other) => Value.CompareTo(other.Value);
		public static bool operator ==(Username a, Username b) => a.CompareTo(b) == 0;
		public static bool operator !=(Username a, Username b) => !(a == b);
		public static implicit operator string(Username username) => username.Value;
		public static implicit operator Username(string username) => new(username);
		public static bool TryParse(string value, out Username username)
		{
			username = default;
			if (string.IsNullOrWhiteSpace(value))
				return false;
			username = new Username(value.Trim());
			return true;
		}
	}

	[JsonConverter(typeof(StringAliasConverter<Uuid>))]
	public readonly partial struct Uuid : IComparable<Uuid>, IEquatable<Uuid>
	{
		public Uuid(string uuid) => Value = uuid;
		public string Value { get; }

		public override int GetHashCode() => Value.GetHashCode();
		public override string ToString() => Value;
		public override bool Equals(object obj) => ReferenceEquals(null, obj) ? false : obj is Uuid other && Equals(other);
		public bool Equals(Uuid other) => this.Value.Equals(other.Value);
		public int CompareTo(Uuid other) => Value.CompareTo(other.Value);
		public static bool operator ==(Uuid a, Uuid b) => a.CompareTo(b) == 0;
		public static bool operator !=(Uuid a, Uuid b) => !(a == b);
		public static implicit operator string(Uuid uuid) => uuid.Value;
		public static implicit operator Uuid(string uuid) => new(uuid);
		public static bool TryParse(string value, out Uuid uuid)
		{
			uuid = default;
			if (string.IsNullOrWhiteSpace(value))
				return false;
			uuid = new Uuid(value.Trim());
			return true;
		}
	}

	[JsonConverter(typeof(StringAliasConverter<VersionString>))]
	public readonly partial struct VersionString : IComparable<VersionString>, IEquatable<VersionString>
	{
		public VersionString(string versionString) => Value = versionString;
		public string Value { get; }

		public override int GetHashCode() => Value.GetHashCode();
		public override string ToString() => Value;
		public override bool Equals(object obj) => ReferenceEquals(null, obj) ? false : obj is VersionString other && Equals(other);
		public bool Equals(VersionString other) => this.Value.Equals(other.Value);
		public int CompareTo(VersionString other) => Value.CompareTo(other.Value);
		public static bool operator ==(VersionString a, VersionString b) => a.CompareTo(b) == 0;
		public static bool operator !=(VersionString a, VersionString b) => !(a == b);
		public static implicit operator string(VersionString versionString) => versionString.Value;
		public static implicit operator VersionString(string versionString) => new(versionString);
		public static bool TryParse(string value, out VersionString versionString)
		{
			versionString = default;
			if (string.IsNullOrWhiteSpace(value))
				return false;
			versionString = new VersionString(value.Trim());
			return true;
		}
	}
}