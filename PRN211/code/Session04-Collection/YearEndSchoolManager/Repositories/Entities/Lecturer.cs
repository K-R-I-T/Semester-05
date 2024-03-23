using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.Entities
{
    public class Lecturer
    {
        //put properties here, ToString() here
        public string Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public int Yob { get; set; }
        public double Salary { get; set; }
        public override string ToString() => $"Student: {Id} | {Name} | {Email} | {Yob} | {Salary}";
    }
}
