public class Solution {
    public IList<IList<int>> GroupThePeople(int[] groupSizes) {
        var dict = new Dictionary<int,List<int>>();

        for(var i = 0; i < groupSizes.Length; i++){
            if(dict.ContainsKey(groupSizes[i])){
                dict[groupSizes[i]].Add(i);
            }
            else{
                dict.Add(groupSizes[i], new List<int>{ i });
            }
        }

        var result = new List<IList<int>>();

        foreach(var kv in dict){
            var sub = new List<int>();
            var counter = 1;
            if(kv.Key < kv.Value.Count){

                for(var i = 0; i < kv.Value.Count; i++){
                    if(counter > kv.Key){
                        result.Add(sub);
                        sub = new List<int>();
                        counter = 1;
                    }
                    sub.Add(kv.Value[i]);
                    counter++;
                }
                result.Add(sub);
            }
            else{
                for(var i = 0; i < kv.Value.Count; i++){
                    sub.Add(kv.Value[i]);
                }
                result.Add(sub);
            }
        }

        return result;
    }
}