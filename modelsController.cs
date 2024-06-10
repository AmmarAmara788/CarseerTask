using CarseerTask.Models;
using CarseerTask.Models.Base;
using CarseerTask.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
namespace CarseerTask.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class modelsController : ControllerBase
    {
        [HttpGet]
        [Route("models")]
        public async Task<ReturnResponse<CarModelRES_ENT>> models([FromQuery] CarModelREQ_ENT REQ)
        {
            ReturnResponse<CarModelRES_ENT> RES = new();
            Model obj = new();
            ReturnResponse<IList<Result>> RESList = new();
            Methods methods = new Methods();
            try
            {
                RESList = await methods.GetModelsForMakeIdYear(REQ);
                RES.Results = new();
                RES.Results.Models = new List<Model>();
                RES.Count = RESList.Count;
                RES.Message = RESList.Message;
                RES.SearchCriteria = RESList.SearchCriteria;
                foreach (var model in RESList.Results)
                {
                    obj.Make_Name = model.Make_Name;
                    obj.Model_Name = model.Model_Name;
                    obj.ModelId = model.Model_ID;
                    RES.Results.Models.Add(obj);
                    obj = new();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return RES;
        }
        
    }
}
