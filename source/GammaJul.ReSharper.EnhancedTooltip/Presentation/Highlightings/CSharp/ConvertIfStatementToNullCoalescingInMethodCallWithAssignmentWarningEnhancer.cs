using GammaJul.ReSharper.EnhancedTooltip.DocumentMarkup;
using JetBrains.Application.Parts;
using JetBrains.ProjectModel;
using JetBrains.ReSharper.Daemon.CSharp.Errors;
using JetBrains.ReSharper.Psi.CodeAnnotations;

namespace GammaJul.ReSharper.EnhancedTooltip.Presentation.Highlightings.CSharp {

	[SolutionComponent(Instantiation.ContainerAsyncAnyThreadUnsafe)]
	internal sealed class ConvertIfStatementToNullCoalescingInMethodCallWithAssignmentWarningEnhancer : CSharpHighlightingEnhancer<ConvertIfStatementToNullCoalescingInMethodCallWithAssignmentWarning> {

		protected override void AppendTooltip(ConvertIfStatementToNullCoalescingInMethodCallWithAssignmentWarning highlighting, CSharpColorizer colorizer) {
			colorizer.AppendPlainText("Convert to method call with '");
			colorizer.AppendOperator("??");
			colorizer.AppendPlainText("' expression inside");
		}
		
		public ConvertIfStatementToNullCoalescingInMethodCallWithAssignmentWarningEnhancer(
			TextStyleHighlighterManager textStyleHighlighterManager,
			CodeAnnotationsConfiguration codeAnnotationsConfiguration,
			HighlighterIdProviderFactory highlighterIdProviderFactory)
			: base(textStyleHighlighterManager, codeAnnotationsConfiguration, highlighterIdProviderFactory) {
		}

	}

}