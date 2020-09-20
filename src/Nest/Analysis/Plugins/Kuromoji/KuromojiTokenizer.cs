// Licensed to Elasticsearch B.V under one or more agreements.
// Elasticsearch B.V licenses this file to you under the Apache 2.0 License.
// See the LICENSE file in the project root for more information

using System.Collections.Generic;
using System.Runtime.Serialization;
using Elastic.Transport.Utf8Json;
using Elasticsearch.Net.Utf8Json;

namespace Nest
{
	/// <summary>
	/// A tokenizer of type pattern that can flexibly separate text into terms via a regular expression.
	/// Part of the `analysis-kuromoji` plugin: https://www.elastic.co/guide/en/elasticsearch/plugins/current/analysis-kuromoji.html
	/// </summary>
	public interface IKuromojiTokenizer : ITokenizer
	{
		/// <summary>
		/// Whether punctuation should be discarded from the output. Defaults to true.
		/// </summary>
		[DataMember(Name ="discard_punctuation")]
		[JsonFormatter(typeof(NullableStringBooleanFormatter))]
		bool? DiscardPunctuation { get; set; }

		/// <summary>
		/// Whether original compound tokens should be discarded from the output with
		/// <see cref="KuromojiTokenizationMode.Search"/> <see cref="Mode"/>. Defaults to `false`.
		/// <para />
		/// Valid in Elasticsearch 7.9.0+
		/// </summary>
		[DataMember(Name ="discard_compound_token")]
		[JsonFormatter(typeof(NullableStringBooleanFormatter))]
		bool? DiscardCompoundToken { get; set; }

		/// <summary>
		/// The tokenization mode determines how the tokenizer handles compound and unknown words.
		/// </summary>
		[DataMember(Name ="mode")]
		KuromojiTokenizationMode? Mode { get; set; }

		/// <summary>
		/// The nbest_cost parameter specifies an additional Viterbi cost. The KuromojiTokenizer will include all tokens in
		/// Viterbi paths that are within the nbest_cost value of the best path.
		/// </summary>
		[DataMember(Name ="nbest_cost")]
		[JsonFormatter(typeof(NullableStringIntFormatter))]
		int? NBestCost { get; set; }

		/// <summary>
		/// The nbest_examples can be used to find a nbest_cost value based on examples. For example,
		///  a value of /箱根山-箱根/成田空港-成田/ indicates that in the texts, 箱根山 (Mt. Hakone) and 成田空港 (Narita Airport)
		///  we’d like a cost that gives is us 箱根 (Hakone) and 成田 (Narita).
		/// </summary>
		[DataMember(Name ="nbest_examples")]
		string NBestExamples { get; set; }

		/// <summary>
		/// The Kuromoji tokenizer uses the MeCab-IPADIC dictionary by default. A user_dictionary may be
		/// appended to the default dictionary.
		/// </summary>
		[DataMember(Name ="user_dictionary")]
		string UserDictionary { get; set; }

		/// <summary> Inline rule version of <see cref="UserDictionary"/> </summary>
		[DataMember(Name ="user_dictionary_rules")]
		IEnumerable<string> UserDictionaryRules { get; set; }

	}

	/// <inheritdoc />
	public class KuromojiTokenizer : TokenizerBase, IKuromojiTokenizer
	{
		public KuromojiTokenizer() => Type = "kuromoji_tokenizer";

		/// <inheritdoc />
		public bool? DiscardPunctuation { get; set; }

		/// <inheritdoc />
		public bool? DiscardCompoundToken { get; set; }

		/// <inheritdoc />
		public KuromojiTokenizationMode? Mode { get; set; }

		/// <inheritdoc />
		public int? NBestCost { get; set; }

		/// <inheritdoc />
		public string NBestExamples { get; set; }

		/// <inheritdoc />
		public string UserDictionary { get; set; }

		/// <inheritdoc />
		public IEnumerable<string> UserDictionaryRules { get; set; }
	}

	/// <inheritdoc />
	public class KuromojiTokenizerDescriptor
		: TokenizerDescriptorBase<KuromojiTokenizerDescriptor, IKuromojiTokenizer>, IKuromojiTokenizer
	{
		protected override string Type => "kuromoji_tokenizer";
		bool? IKuromojiTokenizer.DiscardPunctuation { get; set; }
		bool? IKuromojiTokenizer.DiscardCompoundToken { get; set; }
		KuromojiTokenizationMode? IKuromojiTokenizer.Mode { get; set; }
		int? IKuromojiTokenizer.NBestCost { get; set; }
		string IKuromojiTokenizer.NBestExamples { get; set; }
		string IKuromojiTokenizer.UserDictionary { get; set; }
		IEnumerable<string> IKuromojiTokenizer.UserDictionaryRules { get; set; }

		/// <inheritdoc cref="IKuromojiTokenizer.Mode" />
		public KuromojiTokenizerDescriptor Mode(KuromojiTokenizationMode? mode) => Assign(mode, (a, v) => a.Mode = v);

		/// <inheritdoc cref="IKuromojiTokenizer.DiscardPunctuation" />
		public KuromojiTokenizerDescriptor DiscardPunctuation(bool? discard = true) => Assign(discard, (a, v) => a.DiscardPunctuation = v);

		/// <inheritdoc cref="IKuromojiTokenizer.DiscardCompoundToken" />
		public KuromojiTokenizerDescriptor DiscardCompoundToken(bool? discard = true) => Assign(discard, (a, v) => a.DiscardCompoundToken = v);

		/// <inheritdoc cref="IKuromojiTokenizer.UserDictionary" />
		public KuromojiTokenizerDescriptor UserDictionary(string userDictionary) => Assign(userDictionary, (a, v) => a.UserDictionary = v);

		/// <inheritdoc cref="IKuromojiTokenizer.NBestExamples" />
		public KuromojiTokenizerDescriptor NBestExamples(string examples) => Assign(examples, (a, v) => a.NBestExamples = v);

		/// <inheritdoc cref="IKuromojiTokenizer.NBestCost" />
		public KuromojiTokenizerDescriptor NBestCost(int? cost) => Assign(cost, (a, v) => a.NBestCost = v);

		/// <inheritdoc cref="IKuromojiTokenizer.UserDictionaryRules" />
		public KuromojiTokenizerDescriptor UserDictionaryRules(IEnumerable<string> rules) => Assign(rules, (a, v) => a.UserDictionaryRules = rules);

		/// <inheritdoc cref="IKuromojiTokenizer.UserDictionaryRules" />
		public KuromojiTokenizerDescriptor UserDictionaryRules(params string[] rules) => Assign(rules, (a, v) => a.UserDictionaryRules = rules);
	}
}
