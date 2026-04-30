namespace FizzBuzzLib
{
    public class FizzBuzz : IFizzBuzz, IFizzBuzzRange, IFlexiFizzBuzz
    {
        public Dictionary<int, string> ReplacementPairs {get;}
        public FizzBuzz()
        {
            ReplacementPairs = new Dictionary<int, string>(){
                {3, "Fizz"},
                {5, "Buzz"}
            };
        }
        public string FizzBuzzifyAnInt(int input)
        {
            //Step 1 Logic
           /*   if(input % 3 == 0 && input % 5 == 0)
              {
                  return "FizzBuzz";
              }
              else if(input % 3 == 0)
              {
                  return "Fizz";
              }
             else if(input % 5 == 0 )
             {
                 return "Buzz";
             }
             else
             {
                 return input.ToString();
             } */

            //Extended Task Logic
            string result = "";
            foreach(var item in ReplacementPairs){
                if(input % item.Key == 0) {
                    result += item.Value;
                }
            }
            
            if(string.IsNullOrEmpty(result)){
                return input.ToString();
            }      
           return result;
        }
            
        public IEnumerable<string> FizzBuzzValuesForRange(int start, int end)
        {
            var results = new List<string>();
            for(int i= start; i <= end; i++) {
                results.Add(FizzBuzzifyAnInt(i));
            }
            return results;    
        }
    }
}
