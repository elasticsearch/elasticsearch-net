﻿namespace Nest
{
	public class TextAttribute : ElasticsearchCorePropertyAttributeBase, ITextProperty
	{
		public TextAttribute() : base(FieldType.Text) { }

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

		public bool EagerGlobalOrdinals
		{
			get => Self.EagerGlobalOrdinals.GetValueOrDefault();
			set => Self.EagerGlobalOrdinals = value;
		}

		public bool Fielddata
		{
			get => Self.Fielddata.GetValueOrDefault();
			set => Self.Fielddata = value;
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

		public IndexOptions IndexOptions
		{
			get => Self.IndexOptions.GetValueOrDefault();
			set => Self.IndexOptions = value;
		}

		public bool Norms
		{
			get => Self.Norms.GetValueOrDefault(true);
			set => Self.Norms = value;
		}

		public int PositionIncrementGap
		{
			get => Self.PositionIncrementGap.GetValueOrDefault();
			set => Self.PositionIncrementGap = value;
		}

		public string SearchAnalyzer
		{
			get => Self.SearchAnalyzer;
			set => Self.SearchAnalyzer = value;
		}

		public string SearchQuoteAnalyzer
		{
			get => Self.SearchQuoteAnalyzer;
			set => Self.SearchQuoteAnalyzer = value;
		}

		public TermVectorOption TermVector
		{
			get => Self.TermVector.GetValueOrDefault();
			set => Self.TermVector = value;
		}

		string ITextProperty.Analyzer { get; set; }
		double? ITextProperty.Boost { get; set; }
		bool? ITextProperty.EagerGlobalOrdinals { get; set; }
		bool? ITextProperty.Fielddata { get; set; }
		IFielddataFrequencyFilter ITextProperty.FielddataFrequencyFilter { get; set; }

		/// <remarks>Removed in 6.x</remarks>
		bool? ITextProperty.IncludeInAll { get; set; }

		bool? ITextProperty.Index { get; set; }
		IndexOptions? ITextProperty.IndexOptions { get; set; }
		bool? ITextProperty.Norms { get; set; }
		int? ITextProperty.PositionIncrementGap { get; set; }
		string ITextProperty.SearchAnalyzer { get; set; }
		string ITextProperty.SearchQuoteAnalyzer { get; set; }
		private ITextProperty Self => this;
		TermVectorOption? ITextProperty.TermVector { get; set; }
	}
}
