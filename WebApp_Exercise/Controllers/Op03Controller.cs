using Microsoft.AspNetCore.Mvc;

[Route("Option03")]
public class Op03Controller : Controller
{
    [HttpPost("Calc")]
    public IActionResult Calc(Op03Form form)
    {
        if (form.Opt == 1)
        {
            var result1 = form.Value1 + form.Value2;
            return Content($"{form.Value1} + {form.Value2} = {result1}");
        }
        else if (form.Opt == 2)
        {
            var result2 = form.Value1 - form.Value2;
            return Content($"{form.Value1} - {form.Value2} = {result2}");
        }
        else if (form.Opt == 3)
        {
            var result3 = form.Value1 * form.Value2;
            return Content($"{form.Value1} * {form.Value2} = {result3}");
        }
        else if (form.Opt == 4)
        {
            var result4 = form.Value1 / form.Value2;
            return Content($"{form.Value1} / {form.Value2} = {result4}");
        }
        else if (form.Opt == 5)
        {
            var result5 = form.Value1 % form.Value2;
            return Content($"{form.Value1} % {form.Value2} = {result5}");
        }
        else
        {
            return Content("不明な計算種別です。");
        }
    }
}