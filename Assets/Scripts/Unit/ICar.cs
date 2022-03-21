using Accelerations;
using Steerings;

namespace Unit
{
    public interface ICar
    {
        public Acceleration Acceleration { get; set; }
        public Steering Steering { get; set; } 
    }
}