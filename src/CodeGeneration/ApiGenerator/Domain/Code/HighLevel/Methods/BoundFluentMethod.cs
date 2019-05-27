using System.Collections.Generic;
using System.Linq;

namespace ApiGenerator.Domain 
{
	public class BoundFluentMethod : FluentSyntaxBase
	{
		public BoundFluentMethod(CsharpNames names, IReadOnlyCollection<UrlPart> parts, bool selectorIsOptional) : base(names, parts, selectorIsOptional) { }

		private string DescriptorTypeParams => string.Join(", ", CsharpNames.DescriptorGenerics
			.Select(e => CsharpNames.DescriptorBoundDocumentGeneric));
		
		private string RequestTypeParams => string.Join(", ", CsharpNames.SplitGeneric(CsharpNames.GenericsDeclaredOnRequest)
			.Select(e => CsharpNames.DescriptorBoundDocumentGeneric));

		private string SelectorReturn => string.IsNullOrWhiteSpace(CsharpNames.GenericsDeclaredOnRequest)
			|| !CodeConfiguration.GenericOnlyInterfaces.Contains(CsharpNames.RequestInterfaceName)
				? CsharpNames.RequestInterfaceName
				: $"{CsharpNames.RequestInterfaceName}<{RequestTypeParams}>";
		
		public override string DescriptorName => $"{CsharpNames.DescriptorName}<{DescriptorTypeParams}>";
		public override string GenericWhereClause => $"where {CsharpNames.DescriptorBoundDocumentGeneric} : class";
		public override string MethodGenerics => $"<{CsharpNames.DescriptorBoundDocumentGeneric}>";
		
		public override string RequestMethodGenerics => !string.IsNullOrWhiteSpace(RequestTypeParams) 
			? $"<{RequestTypeParams}>"
			: base.RequestMethodGenerics;
		
		public override string Selector => $"Func<{DescriptorName}, {SelectorReturn}>";
		

	}
}