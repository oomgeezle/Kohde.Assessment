using Kohde.Assessment.Interfaces;

namespace Kohde.Assessment.Models
{
    // For the purposes of this assessment and to pass AssessmentA ABonus1 this class is inheriting from an interface and implementing it's methods here.
    // I do think it's overkill for this specific implementation though
    public abstract class Earthling : IEarthling
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public virtual string GetDetails()
        {
            return $"Name: {Name} Age: {Age}";
        }
    }
}
