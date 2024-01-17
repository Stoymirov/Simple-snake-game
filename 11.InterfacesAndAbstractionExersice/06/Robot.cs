using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BirthdayCelebrations
{
    public class Robot:ISomethingable
    {

        public Robot(string id,string model)
        {
            Model = model;
            Id = id;
        }
        public string Id { get; }
        public string Model { get; }
        
    }
}
