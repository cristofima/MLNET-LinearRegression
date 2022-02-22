using LinearRegression.WebApi.DataModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.ML;

namespace LinearRegression.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TaxiFareController : ControllerBase
    {
        private readonly PredictionEnginePool<TaxiFareModelInput, TaxiFareModelOutput> _predictionEnginePool;

        public TaxiFareController(PredictionEnginePool<TaxiFareModelInput, TaxiFareModelOutput> predictionEnginePool)
        {
            _predictionEnginePool = predictionEnginePool;
        }

        [HttpPost("Predict")]
        public ActionResult Post([FromBody] TaxiFareModelInput input)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }

            var predictionResult = _predictionEnginePool.Predict(modelName: "LinearRegression.MLModels.TaxiFareMLModel", example: input);

            return Ok(predictionResult);
        }
    }
}
