using GameRecomWebProject.Controllers.Helpers.Deserialize.Default_Deserializer.RAWG_Deserializer;
using GameRecomWebProject.Models.BusinessLogic.Abstract;
using GameRecomWebProject.Models.BusinessLogic.Constants;
using GameRecomWebProject.Models.Entities.Concrete;
using GameRecomWebProject.Models.Utilities.Deserialize;
using GameRecomWebProject.Models.Utilities.Deserialize.Default_Deserializer.RAWG_Deserializer;
using GameRecomWebProject.Models.Utilities.Results;
using Microsoft.AspNetCore.DataProtection.AuthenticatedEncryption.ConfigurationModel;

namespace GameRecomWebProject.Models.BusinessLogic.Concrete
{
    public class AppManager : IAppService
    {
        IDeserializer _deserializer;

        public AppManager(IDeserializer deserialize)
        {
            _deserializer= deserialize;  
        }

        public IDataResult<List<AppName>> GetAllAppNameAndSlug()
        {
            return new SuccessDataResult<List<AppName>>(NameDeserializer.DeserializeNameAndSlug());
        }

        public IDataResult<List<string>> GetAllAppNames()
        {
            return new SuccessDataResult<List<string>>(NameDeserializer.GetAllNames());
        }

        public IDataResult<AppList> GetApp(string filter)
        {
            return new SuccessDataResult<AppList>(GetAppWithTag.GetApp(filter));
        }

        public IDataResult<AppList> GetAppsByFilters(string mainQuery, Dictionary<string, string> filters)
        {
            return new SuccessDataResult<AppList>(_deserializer.Deserialize(), Messages.gamesListed);
        }


    }
}
