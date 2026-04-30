namespace FizzBuzzLib
{
    public class FizzBuzz : IFizzBuzz, IFizzBuzzRange, IFlexiFizzBuzz
    {
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
