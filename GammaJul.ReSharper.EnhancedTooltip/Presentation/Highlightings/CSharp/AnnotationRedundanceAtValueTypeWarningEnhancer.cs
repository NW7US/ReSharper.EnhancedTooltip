using GammaJul.ReSharper.EnhancedTooltip.DocumentMarkup;
using JetBrains.Annotations;
using JetBrains.ProjectModel;
using JetBrains.ReSharper.Daemon.CSharp.Errors;
using JetBrains.ReSharper.Psi.CodeAnnotations;

namespace GammaJul.ReSharper.EnhancedTooltip.Presentation.Highlightings.CSharp {

	[SolutionComponent]
	internal sealed class AnnotationRedundanceAtValueTypeWarningEnhancer : CSharpHighlightingEnhancer<AnnotationRedundanceAtValueTypeWarning> {

		protected override void AppendTooltip(AnnotationRedundanceAtValueTypeWarning highlighting, CSharpColorizer colorizer) {
			colorizer.AppendPlainText("Applying nullness annotation to ");
			if (highlighting.IsVoid)
				colorizer.AppendKeyword("void");
			else
				colorizer.AppendPlainText("value");
			colorizer.AppendPlainText(" type is meaningless");
		}
		
		public AnnotationRedundanceAtValueTypeWarningEnhancer([NotNull] TextStyleHighlighterManager textStyleHighlighterManager, [NotNull] CodeAnnotationsCache codeAnnotationsCache)
			: base(textStyleHighlighterManager, codeAnnotationsCache) {
		}

	}

}