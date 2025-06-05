using Calculator.Application.Services;
using Calculator.Core.Abstractions;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using System.Linq.Expressions;

namespace Calculator.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CalculatorController : ControllerBase
    {
        private readonly IMathService _mathService;
        private readonly ILogger<CalculatorController> _logger;

        public CalculatorController(IMathService mathService, ILogger<CalculatorController> logger)
        {
            _mathService = mathService;
            _logger = logger;
        }

        [HttpGet("addition")]
        public Results<Ok<double>, BadRequest<string>> GetAddition([FromQuery] double? firstInput, [FromQuery] double? secondInput)
        {
            if (!firstInput.HasValue || !secondInput.HasValue)
                return TypedResults.BadRequest("Input error.");

            var result = _mathService.Add(firstInput.Value, secondInput.Value);
            return TypedResults.Ok(result);
        }

        [HttpGet("subtraction")]
        public Results<Ok<double>, BadRequest<string>> GetSubtraction([FromQuery] double? firstInput, [FromQuery] double? secondInput)
        {
            if (!firstInput.HasValue || !secondInput.HasValue)
                return TypedResults.BadRequest("Input error.");

            var result = _mathService.Subtract(firstInput.Value, secondInput.Value);
            return TypedResults.Ok(result);
        }

        [HttpGet("multiplication")]
        public Results<Ok<double>, BadRequest<string>> GetMultiplication([FromQuery] double? firstInput, [FromQuery] double? secondInput)
        {
            if (!firstInput.HasValue || !secondInput.HasValue)
                return TypedResults.BadRequest("Input error.");

            var result = _mathService.Multiply(firstInput.Value, secondInput.Value);
            return TypedResults.Ok(result);
        }

        [HttpGet("division")]
        public Results<Ok<double>, BadRequest<string>> GetDivision([FromQuery] double? firstInput, [FromQuery] double? secondInput)
        {
            if (!firstInput.HasValue || !secondInput.HasValue)
                return TypedResults.BadRequest("Input error.");

            try
            {
                var result = _mathService.Divide(firstInput.Value, secondInput.Value);
                return TypedResults.Ok(result);
            }
            catch (Exception e)
            {
                return TypedResults.BadRequest($"{e.Message}");
            }
        }

        [HttpGet("power")]
        public Results<Ok<double>, BadRequest<string>> GetPow([FromQuery] double? _base, [FromQuery] double? exponent)
        {
            if (!_base.HasValue || !exponent.HasValue)
                return TypedResults.BadRequest("Input error.");

            try
            {
                var result = _mathService.Pow(_base.Value, exponent.Value);
                return TypedResults.Ok(result);
            }
            catch (Exception e)
            {
                return TypedResults.BadRequest($"{e.Message}");
            }
        }

        [HttpGet("root")]
        public Results<Ok<double>, BadRequest<string>> GetRoot([FromQuery] double? value, [FromQuery] double? degree)
        {
            if (!value.HasValue || !degree.HasValue)
                return TypedResults.BadRequest("Input error.");

            try
            {
                var result = _mathService.Root(value.Value, degree.Value);
                return TypedResults.Ok(result);
            }
            catch (Exception e)
            {
                return TypedResults.BadRequest($"{e.Message}");
            }
        }

        [HttpGet("hardExpression")]
        public Results<Ok<double>, BadRequest<string>> GetHardExpression([FromQuery] string expression)
        {
            try
            {
                var result = _mathService.HardExpression(expression);
                return TypedResults.Ok(result);
            }
            catch (Exception e)
            {
                return TypedResults.BadRequest($"{e.Message}");
            }
        }
    }
}
