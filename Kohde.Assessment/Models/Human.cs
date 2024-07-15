using Kohde.Assessment.Models;

namespace Kohde.Assessment
{
    public class Human : Earthling
    {
        public string Gender { get; set; }

        public override string ToString()
        {
            return $"{base.GetDetails()} Gender: {Gender}";
        }
    }
}