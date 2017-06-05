using System.Collections.Generic;

namespace webapp{
    public class FamilyService:IFamilyService {
        private FamilyContext _familyContext {get;set;}
        public FamilyService(FamilyContext familyContext){
            _familyContext=familyContext;
        }
        public IEnumerable<Family> Get(){
            return _familyContext.Families;
        }
        public Family Add(Family family){
            _familyContext.Families.Add(family);
            _familyContext.SaveChanges();
            return _familyContext.Families.Find(family);
        }
    }
}