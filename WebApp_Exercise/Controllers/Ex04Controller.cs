using Microsoft.AspNetCore.Mvc;
/// <summary>
/// 演習-04 [FormQuery]属性を利用してクエリパラメータを受け取る
/// </summary>
[Route("Exercise04")]
public class Ex04Controller : Controller
{

    [HttpGet("C")]
    public IActionResult Calc([FromQuery] int v1, [FromQuery] int v2)
    {
        // 演習-05 型変換エラーの場合、エラーメッセージを出力する
        /** 追加 **/
        if (!ModelState.IsValid) // 型変換エラー?
        {
            // value1とvalue2で型変換エラー
            if ((ModelState["v1"]?.Errors.Count ?? 0) > 0
            && (ModelState["v2"]?.Errors.Count ?? 0) > 0)
            {
                return Content("value1とvalue2は整数ではありません。");
            }
            // value1で型変換エラー
            if ((ModelState["v1"]?.Errors.Count ?? 0) > 0)
            {
                return Content("value1は整数ではありません。");
            }
            // value2で型変換エラー
            if ((ModelState["v2"]?.Errors.Count ?? 0) > 0)
            {
                return Content("value2は整数ではありません。");
            }
        }
        var result = v1 + v2;
        return Content($"{v1} + {v2} = {result}");
    }

}