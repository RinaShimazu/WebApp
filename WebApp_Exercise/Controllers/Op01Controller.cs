using Microsoft.AspNetCore.Mvc;
/// <summary>
/// 演習-04 [FormQuery]属性を利用してクエリパラメータを受け取る
/// </summary>
[Route("Option01")]
public class Op01Controller : Controller
{

    [HttpGet("Calc")]
    public IActionResult Calc([FromQuery] int value1, [FromQuery] int value2, [FromQuery] int opt)
    {
        var result1 = value1 + value2;
        var result2 = value1 - value2;
        var result3 = value1 * value2;
        var result4 = value1 / value2;
        var result5 = value1 % value2;

        if (opt == 1)
        {
            return Content($"{value1} + {value2} = {result1}");
        }
        else if (opt == 2)
        {
            return Content($"{value1} - {value2} = {result2}");
        }
        else if (opt == 3)
        {
            return Content($"{value1} * {value2} = {result3}");
        }
        else if (opt == 4)
        {
            return Content($"{value1} / {value2} = {result4}");
        }
        else if (opt == 5)
        {
            return Content($"{value1} % {value2} = {result5}");
        }
        else
        {
            return Content("不明な計算種別です。");
        }
    }
}