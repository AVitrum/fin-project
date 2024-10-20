using Microsoft.AspNetCore.Html;

namespace FInProject.Helpers;

public static class HtmlHelperExtensions {
    public static IHtmlContent RenderAssetProperty(string expressionStart, string expressionEnd, string displayName, object valueStart, object valueEnd) 
    {
        HtmlContentBuilder builder = new HtmlContentBuilder();

        builder.AppendHtml($@"
                <div class='form-group row border p-3 mb-3'>
                    <label for='{expressionStart}' class='control-label col-md-2'><strong>{displayName}</strong></label>
                    <div class='col-md-5'>
                        <input type='text' id='{expressionStart}' name='{expressionStart}' value='{valueStart}' class='form-control' placeholder='At Start' />
                        <span class='text-danger' data-valmsg-for='{expressionStart}' data-valmsg-replace='true'></span>
                    </div>
                    <div class='col-md-5'>
                        <input type='text' id='{expressionEnd}' name='{expressionEnd}' value='{valueEnd}' class='form-control' placeholder='At End' />
                        <span class='text-danger' data-valmsg-for='{expressionEnd}' data-valmsg-replace='true'></span>
                    </div>
                </div>
            ");

        return builder;
    }
}