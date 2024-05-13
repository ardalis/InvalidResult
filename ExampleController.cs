using Ardalis.Result;
using Ardalis.Result.AspNetCore;
using Microsoft.AspNetCore.Mvc;

public class ExampleController : ControllerBase
{
    [HttpGet("throws")]
    [TranslateResultToActionResult]
    public Result<int> Throws()
    {
        return Result<int>.Invalid(new ValidationError("foo"));
    }

    [HttpGet("doesntthrow")]
    [TranslateResultToActionResult]
    public Result<int> DoesntThrow()
    {
        return Result<int>.Invalid(new ValidationError
        {
            ErrorMessage = "baz",
            Identifier = "bar"
        });
    }
}