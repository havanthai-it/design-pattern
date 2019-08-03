using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.StructuralDesignPatterns.Bridge
{
    class BridgeProgram
    {
        public static void Run()
        {
            School middleSchool = new MiddleSchool();
            School highSchool = new HighSchool();

            middleSchool.SchoolOperation = new LocalOperation();
            middleSchool.AddClass();
            middleSchool.AddCourse();

            middleSchool.SchoolOperation = new GlobalOperation();
            middleSchool.AddClass();
            middleSchool.AddCourse();
        }
    }

    abstract class School
    {
        public ISchoolOperation SchoolOperation { get; set; }

        public abstract void AddCourse();
        public abstract void AddClass();
    }

    class MiddleSchool : School
    {
        public override void AddClass()
        {
            SchoolOperation.CreateClassSchedule("Middle School");
        }

        public override void AddCourse()
        {
            SchoolOperation.CreateCourseSchedule("Middle School");
        }
    }

    class HighSchool : School
    {
        public override void AddClass()
        {
            SchoolOperation.CreateClassSchedule("High School");
        }

        public override void AddCourse()
        {
            SchoolOperation.CreateCourseSchedule("High School");
        }
    }





    interface ISchoolOperation
    {
        void CreateClassSchedule(string schoolType);

        void CreateCourseSchedule(string schoolType);
    }

    class LocalOperation : ISchoolOperation
    {
        public void CreateClassSchedule(string schoolType)
        {
            Console.WriteLine($"Local school, created class schedule for {schoolType}");
        }

        public void CreateCourseSchedule(string schoolType)
        {
            Console.WriteLine($"Local school, created course schedule for {schoolType}");
        }
    }

    class GlobalOperation : ISchoolOperation
    {
        public void CreateClassSchedule(string schoolType)
        {
            Console.WriteLine($"Global school, created class schedule for {schoolType}");
        }

        public void CreateCourseSchedule(string schoolType)
        {
            Console.WriteLine($"Global school, created course schedule for {schoolType}");
        }
    }

}
