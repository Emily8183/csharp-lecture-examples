namespace Chapter05
{
    public class Constants
    {
        public const string DASHED_LINE = "------------------------------------------------";
        //const has the same value across all objects of a class
        //cannot be set at runtime, only compile time
        //must be public
        //set in SCREAMING_SNAKE_CASE
        //no need to add static, its behind the scenes
        //the value is stored at the class level and can't be changed    
        //call it this way: string line = Constant.DASHED_LINE;
        
    }
}
