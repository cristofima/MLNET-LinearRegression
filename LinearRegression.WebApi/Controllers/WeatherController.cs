using LinearRegression.WebApi.DataModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.ML;

namespace LinearRegression.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WeatherController : ControllerBase
    {
        private readonly PredictionEnginePool<WeatherModelInput, WearherModelOutput> _predictionEnginePool;

        public WeatherController(PredictionEnginePool<WeatherModelInput, WearherModelOutput> predictionEnginePool)
        {
            _predictionEnginePool = predictionEnginePool;
        }

        [HttpPost("Predict")]
        public ActionResult Post([FromBody] WeatherModelInput input)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }

            var predictionResult = _predictionEnginePool.Predict(modelName: "LinearRegression.MLModels.WeatherMLModel", example: input);

            return Ok(predictionResult);
        }
    }
}