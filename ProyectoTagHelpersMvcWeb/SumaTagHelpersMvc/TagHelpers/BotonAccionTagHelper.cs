using Microsoft.AspNetCore.Razor.TagHelpers;

namespace SumaTagHelpersMvc.TagHelpers;

[HtmlTargetElement("boton-accion")]
public class BotonAccionTagHelper : TagHelper
{
    public string Texto { get; set; } = "Enviar";
    public string Tipo { get; set; } = "submit";

    public override void Process(TagHelperContext context, TagHelperOutput output)
    {
        output.TagName = "button";
        output.Attributes.SetAttribute("type", Tipo);
        output.Attributes.SetAttribute("class", "primary-button");
        output.Content.SetContent(Texto);
    }
}
