using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.StructuralDesignPatterns.Bridge
{
    class ProblemWithOutBridge
    {
        /*
         * Has class SCHOOL with two childs MIDDLESCHOOL & HIGHSCHOOL
         * Each school has two childs LOCALSCHOOL & GLOBALSCHOOL
         */
    }

    abstract class SchoolTemp
    {
        public abstract void AddCourse();
        public abstract void AddClass();
    }

    class MiddleSchoolTemp : SchoolTemp
    {
        public override void AddClass()
        {
            throw new NotImplementedException();
        }

        public override void AddCourse()
        {
            throw new NotImplementedException();
        }
    }

    class HighSchoolTemp : SchoolTemp
    {
        public override void AddClass()
        {
            throw new NotImplementedException();
        }

        public override void AddCourse()
        {
            throw new NotImplementedException();
        }
    }

    class LocalMiddleSchoolTemp : MiddleSchool { }

    class GlobalMiddleSchoolTemp : MiddleSchool { }

    class LocalHighSchool : HighSchoolTemp { }

    class GlobalHighSchool : HighSchoolTemp { }
}
