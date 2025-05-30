using GammaJul.ReSharper.EnhancedTooltip.DocumentMarkup;
using JetBrains.Application.Parts;
using JetBrains.ProjectModel;
using JetBrains.ReSharper.Daemon.CSharp.Errors;
using JetBrains.ReSharper.Psi;
using JetBrains.ReSharper.Psi.CodeAnnotations;

namespace GammaJul.ReSharper.EnhancedTooltip.Presentation.Highlightings.CSharp {

	[SolutionComponent(Instantiation.ContainerAsyncAnyThreadUnsafe)]
	internal sealed class PossibleNullReferenceExceptionWarningEnhancer : CSharpHighlightingEnhancer<PossibleNullReferenceExceptionWarning> {

		protected override void AppendTooltip(PossibleNullReferenceExceptionWarning highlighting, CSharpColorizer colorizer) {
			colorizer.AppendPlainText("Possible '");
			colorizer.AppendNamespaceName("System");
			colorizer.AppendPlainText(".");
			colorizer.AppendClassName("NullReferenceException");
			colorizer.AppendPlainText("'");
		}
		
		public PossibleNullReferenceExceptionWarningEnhancer(
			TextStyleHighlighterManager textStyleHighlighterManager,
			CodeAnnotationsConfiguration codeAnnotationsConfiguration,
			HighlighterIdProviderFactory highlighterIdProviderFactory)
			: base(textStyleHighlighterManager, codeAnnotationsConfiguration, highlighterIdProviderFactory) {
		}

	}

}