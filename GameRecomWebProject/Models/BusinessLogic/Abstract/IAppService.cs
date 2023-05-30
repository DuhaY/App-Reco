using GameRecomWebProject.Models.Entities.Concrete;
using GameRecomWebProject.Models.Utilities.Results;

namespace GameRecomWebProject.Models.BusinessLogic.Abstract
{
    public interface IAppService
    {
        IDataResult<AppList> GetAppsByFilters(string mainQuery, Dictionary<string,string> filters);

        IDataResult<List<AppName>> GetAllAppNameAndSlug();

        IDataResult<List<string>> GetAllAppNames();

        IDataResult<AppList> GetApp(string filter);

    }
}
