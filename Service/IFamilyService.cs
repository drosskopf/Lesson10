using System.Collections.Generic;

namespace webapp{
    public interface IFamilyService{
         IEnumerable<Family> Get();
         Family Add(Family family);

    }
}