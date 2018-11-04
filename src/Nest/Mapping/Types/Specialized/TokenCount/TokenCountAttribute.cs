﻿namespace Nest
{
	public class TokenCountAttribute : ElasticsearchDocValuesPropertyAttributeBase, ITokenCountProperty
	{
		public TokenCountAttribute() : base(FieldType.TokenCount) { }

		public string Analyzer
		{
			get => Self.Analyzer;
			set => Self.Analyzer = value;
		}

		public double Boost
		{
			get => Self.Boost.GetValueOrDefault();
			set => Self.Boost = value;
		}

		/// <remarks>Removed in 6.x</remarks>
		public bool IncludeInAll
		{
			get => Self.IncludeInAll.GetValueOrDefault();
			set => Self.IncludeInAll = value;
		}

		public bool Index
		{
			get => Self.Index.GetValueOrDefault();
			set => Self.Index = value;
		}

		public double NullValue
		{
			get => Self.NullValue.GetValueOrDefault();
			set => Self.NullValue = value;
		}

		string ITokenCountProperty.Analyzer { get; set; }
		double? ITokenCountProperty.Boost { get; set; }

		/// <remarks>Removed in 6.x</remarks>
		bool? ITokenCountProperty.IncludeInAll { get; set; }

		bool? ITokenCountProperty.Index { get; set; }
		double? ITokenCountProperty.NullValue { get; set; }
		private ITokenCountProperty Self => this;
	}
}
