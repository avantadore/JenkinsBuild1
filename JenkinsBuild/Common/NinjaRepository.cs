using System.Collections.Generic;
using System.Linq;

namespace Common
{
    public class NinjaRepository
    {
        private readonly INinjaDataProvider _dataProvider;

        public NinjaRepository(INinjaDataProvider dataProvider)
        {
            _dataProvider = dataProvider;
        }

        public List<INinja> BestNinja()
        {
            if (!_dataProvider.GetNinjas().Any()) return new List<INinja>();
            var maxSkill = _dataProvider.GetNinjas().Max(x => x.Skills);
            return _dataProvider.GetNinjas().Where(x => x.Skills == maxSkill).ToList();
        }

        public List<INinja> NinjasWithSkillMinimunSkillLevel(int minSkillLevel)
        {
            return _dataProvider.GetNinjas().Where(x => x.Skills >= minSkillLevel).ToList();
        }
    }
}
