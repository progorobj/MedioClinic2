using CMS.Helpers;
using Microsoft.AspNetCore.Html;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MedioClinic1.Extensions
{
    public static class HtmlHelperExtensions
    {

		public static IHtmlContent FileInput(this IHtmlHelper htmlHelper,
									 string buttonResourceKey,
									 string formFieldName,
									 IDictionary<string, object> fileInputHtmlAttributes,
									 IDictionary<string, object> textInputHtmlAttributes,
									 string buttonCssClasses)
		{
			if (htmlHelper is null)
			{
				throw new ArgumentNullException(nameof(htmlHelper));
			}

			var htmlPattern = @"<div class=""file-field input-field"">
    <div class=""{0}"">
        <span>{1}</span>
        {2}
    </div>
    <div class=""file-path-wrapper"">
        {3}
    </div>
</div>";

			var fileInputTagBuilder = new TagBuilder("input");
			fileInputTagBuilder.MergeAttributes(fileInputHtmlAttributes);
			fileInputTagBuilder.MergeAttribute("type", "file");
			fileInputTagBuilder.MergeAttribute("name", formFieldName);
			string inputId = htmlHelper.GenerateIdFromName(formFieldName);
			fileInputTagBuilder.MergeAttribute("id", inputId);
			var renderedFileInput = fileInputTagBuilder.RenderSelfClosingTag();
			var buttonTitle = ResHelper.GetString(buttonResourceKey);
			var textInputTagBuilder = new TagBuilder("input");
			textInputTagBuilder.MergeAttribute("type", "text");
			textInputTagBuilder.AddCssClass("file-path");
			textInputTagBuilder.AddCssClass("validate");
			textInputTagBuilder.MergeAttributes(textInputHtmlAttributes);
			var start = textInputTagBuilder.RenderStartTag();
			var end = textInputTagBuilder.RenderEndTag();
			var renderedTextInput = new HtmlContentBuilder().AppendHtml(start).AppendHtml(end);

			var html = new HtmlContentBuilder()
				.AppendFormat(htmlPattern, buttonCssClasses, buttonTitle, renderedFileInput, renderedTextInput);

			return html;
		}


		public static IHtmlContent Button(this IHtmlHelper htmlHelper, string buttonResourceKey, IDictionary<string, object> htmlAttributes)
		{
			string attributes = default;

			using (var stringWriter = new System.IO.StringWriter())
			{
				foreach (var attribute in htmlAttributes)
				{
					stringWriter.Write($@"{attribute.Key}=""{attribute.Value}"" ");
				}

				attributes = stringWriter.ToString();
			}

			var startTag = $@"<button type=""button"" {attributes}>";
			var body = ResHelper.GetString(buttonResourceKey);
			var endTag = "</button>";

			var result = htmlHelper.Raw($"{startTag}{body}{endTag}");

			return result;
		}
	}
}
