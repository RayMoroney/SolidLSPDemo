using System;
using System.Collections.Generic;
using System.Text;

namespace DemoLibrary
{
    public interface IManager : IEmployee
    {
        void GeneratePerformanceReview();
    }
}
