using GameRecomWebProject.Models.Utilities.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IResult = GameRecomWebProject.Models.Utilities.Results.IResult;

namespace GameRecomWebProject.Models.Utilities.Business
{
    public class BusinessRules
    {
        public static IResult Run(params IResult[] logics)
        {
            foreach (var logic in logics)
            {
                if (!logic.IsSuccess)
                {
                    return logic;
                }
            }

            return null;

        }
    }
}
